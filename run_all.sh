#!/usr/bin/env bash
set -euo pipefail
ROOT="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
OUT="$ROOT/artifacts"
mkdir -p "$OUT/system" "$OUT/dotnet" "$OUT/jvm" "$OUT/rust" "$OUT/python" "$OUT/julia"
EXPECTED="e98c59d10d761975b153df07bb14d40514b1c2ced09529df198895d8ac784c9b"

{
  echo "utc=$(date -u +%Y-%m-%dT%H:%M:%SZ)"
  echo "runner_os=${RUNNER_OS:-unknown}"
  echo "runner_arch=${RUNNER_ARCH:-unknown}"
  uname -a
  echo "--- lscpu ---"; lscpu || true
  echo "--- memory ---"; free -h || true
  echo "--- disk ---"; df -h . || true
  echo "--- time ---"; /usr/bin/time --version 2>&1 | head -5 || true
} > "$OUT/system/machine.txt" 2>&1

{
  echo "dotnet=$(dotnet --version)"
  java -version 2>&1 | head -1
  javac -version 2>&1
  rustc --version
  cargo --version
  python --version
  julia --version
} > "$OUT/system/runtimes.txt" 2>&1

run_dotnet() {
  echo "=== .NET ==="
  cd "$ROOT/benchmarks/dotnet"
  chmod +x scripts/*.sh
  REPS=4 RUN_P4=1 ./scripts/run-benchmarks.sh "$OUT/dotnet"
}

run_jvm() {
  echo "=== JVM ==="
  cd "$ROOT/benchmarks/jvm"
  chmod +x ./*.sh scripts/*.sh
  ./scripts/run_contract_suite.sh
  cp -a rerun-evidence/. "$OUT/jvm/"
  java -version > "$OUT/jvm/java-version.txt" 2>&1
  javac -version >> "$OUT/jvm/java-version.txt" 2>&1
}

run_rust() {
  echo "=== Rust ==="
  cd "$ROOT/benchmarks/rust"
  chmod +x scripts/*.sh
  ./scripts/run_correctness.sh | tee "$OUT/rust/correctness.txt"
  REPS=4 RUN_P4=1 ./scripts/run_benchmarks.sh | tee "$OUT/rust/benchmark-driver.txt"
  cp -a evidence/bench "$OUT/rust/bench"
  cp -a evidence/benchmark_summary.json "$OUT/rust/benchmark_summary.json"
  cargo run --release -- churn > "$OUT/rust/churn.txt"
  ./scripts/capture_environment.sh > "$OUT/rust/environment.txt" 2>&1 || true
}

run_python() {
  echo "=== Python ==="
  cd "$ROOT/benchmarks/python"
  export PYTHONPATH="$PWD/src"
  python -m unittest discover -s tests -v > "$OUT/python/tests.txt" 2>&1
  python -m tresbench.cli runtime-info > "$OUT/python/runtime-info.json"
  python -m tresbench.cli fixture --workdir "$OUT/python/work-fixture" > "$OUT/python/fixture.json"
  grep -q "$EXPECTED" "$OUT/python/fixture.json"
  for c in P1 P2 P3 P4; do
    mkdir -p "$OUT/python/$c"
    for r in 1 2 3; do
      /usr/bin/time -v -o "$OUT/python/$c/run${r}.time.txt" \
        python -m tresbench.cli case "$c" --workdir "$OUT/python/work-$c-$r" \
        > "$OUT/python/$c/run${r}.json"
    done
  done
  /usr/bin/time -v -o "$OUT/python/churn.time.txt" \
    python -m tresbench.cli churn --workdir "$OUT/python/work-churn" \
    > "$OUT/python/churn.json"
  python -m tresbench.cli memory-shape > "$OUT/python/memory-shape.json"
}

run_julia() {
  echo "=== Julia ==="
  cd "$ROOT/benchmarks/julia"
  chmod +x scripts/*.sh
  export JULIA_NUM_THREADS=1
  julia --project=. --threads=1 -e 'using Pkg; Pkg.test()' > "$OUT/julia/tests.txt" 2>&1
  julia --project=. --threads=1 scripts/run_fixture.jl > "$OUT/julia/fixture.txt"
  grep -q "$EXPECTED" "$OUT/julia/fixture.txt"
  ./scripts/verify_fresh_restore.sh > "$OUT/julia/fresh-restore.txt" 2>&1
  grep -q "$EXPECTED" "$OUT/julia/fresh-restore.txt"
  for c in P1 P2 P3 P4; do
    /usr/bin/time -v -o "$OUT/julia/${c}.time.txt" \
      julia --project=. --threads=1 scripts/benchmark_case.jl "$c" 3 \
      > "$OUT/julia/${c}.txt"
  done
  /usr/bin/time -v -o "$OUT/julia/churn.time.txt" \
    julia --project=. --threads=1 scripts/churn_p2.jl \
    > "$OUT/julia/churn.txt"
  julia --project=. --threads=1 scripts/inspect_types.jl > "$OUT/julia/type-inspection.txt" 2>&1 || true
  julia --project=. --threads=1 scripts/allocations.jl > "$OUT/julia/allocations.txt" 2>&1 || true
}

run_dotnet
run_jvm
run_rust
run_python
run_julia

echo "ALL_STACKS_COMPLETED" | tee "$OUT/system/completion.txt"
