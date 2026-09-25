param(
    [Parameter(Mandatory = $true)][string]$Dotnet,
    [Parameter(Mandatory = $true)][string]$Checkout,
    [Parameter(Mandatory = $true)][string]$Evidence,
    [string]$Revision = 'HEAD'
)
$ErrorActionPreference = 'Stop'
$repo = (git rev-parse --show-toplevel).Trim()
$head = (git rev-parse $Revision).Trim()
$Checkout = [IO.Path]::GetFullPath($Checkout)
$Evidence = [IO.Path]::GetFullPath($Evidence)
if (Test-Path -LiteralPath $Checkout) { throw 'Mutation checkout must be new.' }
New-Item -ItemType Directory -Force -Path $Evidence | Out-Null
$primaryPath = Join-Path $repo 'artifacts/acceptance/slice1-v2-results.json'
$primary = Get-Content -LiteralPath $primaryPath -Raw | ConvertFrom-Json
if ($primary.ImplementationHead -ne $head -or $primary.WorkingTreeDirty -or !$primary.ExecutableEvidenceReady) {
    throw 'Run canonical successor evidence on the clean exact committed revision before mutation.'
}
if ($primary.ManifestBlob -ne '174ccbae57a64f06bd88de233b11a011b4a2b115' -or
    @($primary.Rows | Where-Object { $_.Classification -eq 'REQUIRED' -and $_.State -eq 'PASS' }).Count -ne 133 -or
    ($primary.Rows | Where-Object Id -eq 'S1-GLOBAL-CONFORMANCE').State -ne 'AWAITING FRESH INDEPENDENT REVIEW') {
    throw 'Invalid successor evidence census/review state.'
}
$gatePath = Join-Path $repo 'artifacts/acceptance/slice1-v2-candidate-gate.json'
@{ ImplementationHead = $head; CandidateReady = $false; MutationState = 'IN PROGRESS'; FullFrozenCompletionGate = $false } |
    ConvertTo-Json | Set-Content -LiteralPath $gatePath -Encoding utf8
git worktree add --detach $Checkout $head
if ($LASTEXITCODE -ne 0) { throw 'Cannot create isolated mutation checkout.' }
$records = @()
function Invoke-Dotnet([string[]]$Arguments, [string]$Name) {
    $info = [Diagnostics.ProcessStartInfo]::new()
    $info.FileName = $Dotnet
    $info.WorkingDirectory = $Checkout
    $info.UseShellExecute = $false
    $info.CreateNoWindow = $true
    $info.RedirectStandardOutput = $true
    $info.RedirectStandardError = $true
    foreach ($argument in $Arguments) { $info.ArgumentList.Add($argument) }
    $process = [Diagnostics.Process]::Start($info)
    $stdout = $process.StandardOutput.ReadToEndAsync()
    $stderr = $process.StandardError.ReadToEndAsync()
    if (!$process.WaitForExit(180000)) {
        $process.Kill($true)
        $process.WaitForExit()
        $exitCode = -999
    } else { $exitCode = $process.ExitCode }
    [IO.File]::WriteAllText((Join-Path $Evidence ($Name + '.log')), $stdout.Result + $stderr.Result)
    $process.Dispose()
    return $exitCode
}
function Replace-Exact([string]$File, [string]$Before, [string]$After) {
    $path = Join-Path $Checkout $File
    $content = [IO.File]::ReadAllText($path).Replace("`r`n", "`n")
    if (($content.Split([string[]]@($Before), [StringSplitOptions]::None).Count - 1) -ne 1) {
        throw "Mutation seam is not unique: $File / $Before"
    }
    [IO.File]::WriteAllText($path, $content.Replace($Before, $After))
}
$state = 'src/Mesopotamia.Sim/State.cs'
$actions = 'src/Mesopotamia.Sim/Decisions.cs'
$execution = 'src/Mesopotamia.Sim/Execution.cs'
$guard = 'if (target is { } person && (person == proposal.Actor || !snapshot.People.ContainsKey(person)))'
$mutants = @(
    @{ Name = 'generic-endpoint-inequality'; Detector = 'Dec0015AttitudeDiagonal'; File = $state; Before =
        'if (!People.ContainsKey(a) || !People.ContainsKey(b))'; After =
        'if (a == b || !People.ContainsKey(a) || !People.ContainsKey(b))' },
    @{ Name = 'self-gift-response'; Detector = 'Dec0015SelfCounterpartyBoundary'; File = $actions; Before = $guard; After =
        'if (target is { } person && ((person == proposal.Actor && proposal.Terms is not OfferGift) || !snapshot.People.ContainsKey(person)))' },
    @{ Name = 'self-loan-response'; Detector = 'Dec0015SelfCounterpartyBoundary'; File = $actions; Before = $guard; After =
        'if (target is { } person && ((person == proposal.Actor && proposal.Terms is not OfferLoan) || !snapshot.People.ContainsKey(person)))' },
    @{ Name = 'diagonal-debt-enabled'; Detector = 'Dec0015DebtDiagonal'; File = $state; Before =
        '            if (debt.Creditor == debt.Debtor) throw new ArgumentException("Debt requires distinct people.");'; After =
        '            // MUTANT: Debt distinctness omitted.' },
    @{ Name = 'diagonal-favour-enabled'; Detector = 'Dec0015FavourDiagonal'; File = $state; Before =
        '            if (favour.Debtor == favour.Holder) throw new ArgumentException("Favour requires distinct people.");'; After =
        '            // MUTANT: Favour distinctness omitted.' },
    @{ Name = 'broad-response-alias-prohibition'; Detector = 'Dec0015InheritedSharedSnapshotScarceGrain'; File = $execution; Before =
        '                    bool called = proposal.Terms is CallFavor;'; After =
        '                    if (decisions.Any(d => d.Actor == respondent)) continue;' + "`n" +
        '                    bool called = proposal.Terms is CallFavor;' },
    @{ Name = 'diagonal-attitude-authorizes-self-action'; Detector = 'Dec0015SelfCounterpartyBoundary'; File = $actions; Before = $guard; After =
        'if (target is { } person && ((person == proposal.Actor && !snapshot.Attitudes.Values.Any(a => a.From == person && a.To == person)) || !snapshot.People.ContainsKey(person)))' }
)
$dll = 'tests/Mesopotamia.Sim.AcceptanceTests/bin/Release/net10.0/Mesopotamia.Sim.AcceptanceTests.dll'
$filter = 'FullyQualifiedName~SuccessorFaultDetector'
Push-Location $Checkout
try {
    if ((Invoke-Dotnet @('restore', 'Mesopotamia.Sim.slnx') 'restore') -ne 0) { throw 'Mutation restore failed.' }
    if ((Invoke-Dotnet @('build', 'Mesopotamia.Sim.slnx', '--configuration', 'Release', '--no-restore') 'control-build') -ne 0) { throw 'Control build failed.' }
    $controlTrx = Join-Path $Evidence 'control.trx'
    if ((Invoke-Dotnet @($dll, '--filter', $filter, '--no-ansi', '--progress', 'off', '--report-trx', '--report-trx-filename', $controlTrx) 'control-test') -ne 0) {
        throw 'Unmutated control failed.'
    }
    [xml]$control = Get-Content -LiteralPath $controlTrx -Raw
    if (@($control.TestRun.Results.UnitTestResult).Count -ne 6 -or
        @($control.TestRun.Results.UnitTestResult | Where-Object outcome -ne 'Passed').Count -ne 0) {
        throw 'Control did not execute all six named detector cases.'
    }
    foreach ($mutant in $mutants) {
        Replace-Exact $mutant.File $mutant.Before $mutant.After
        $format = Invoke-Dotnet @('format', 'whitespace', 'Mesopotamia.Sim.slnx', '--no-restore', '--include', $mutant.File) ($mutant.Name + '-format')
        $patch = Join-Path $Evidence ($mutant.Name + '.patch')
        git diff "--output=$patch"
        if ($LASTEXITCODE -ne 0) { throw 'Cannot retain mutation patch.' }
        $build = Invoke-Dotnet @('build', 'Mesopotamia.Sim.slnx', '--configuration', 'Release', '--no-restore') ($mutant.Name + '-build')
        $test = $null
        $detected = $false
        $failures = @()
        $classification = if ($format -ne 0 -or $build -ne 0) { 'invalid/build-failure' } else { 'unexercised' }
        if ($format -eq 0 -and $build -eq 0) {
            $trxPath = Join-Path $Evidence ($mutant.Name + '.trx')
            $test = Invoke-Dotnet @($dll, '--filter', $filter, '--no-ansi', '--progress', 'off', '--report-trx', '--report-trx-filename', $trxPath) ($mutant.Name + '-test')
            if (Test-Path -LiteralPath $trxPath) {
                [xml]$trx = Get-Content -LiteralPath $trxPath -Raw
                $failures = @($trx.TestRun.Results.UnitTestResult | Where-Object outcome -eq 'Failed' | ForEach-Object {
                    [pscustomobject]@{ Name = $_.testName; Message = [string]$_.Output.ErrorInfo.Message }
                })
                $detected = $test -eq 2 -and @($failures | Where-Object {
                    $_.Name.Contains($mutant.Detector) -and $_.Message -match 'Assertion failed|Assert\.'
                }).Count -gt 0
            }
            $classification = if ($detected) { 'detected' } elseif ($test -eq -999) { 'timeout' } elseif ($test -eq 0) { 'survived' } else { 'crash-or-unrelated-failure' }
        }
        $records += [pscustomobject]@{
            Name = $mutant.Name; BaseHead = $head; Detector = $mutant.Detector; Patch = $mutant.Name + '.patch'
            FormatExit = $format; BuildExit = $build; TestExit = $test
            Outcome = $classification; Detected = $detected; Failures = $failures
        }
        $records | ConvertTo-Json -Depth 8 | Set-Content -LiteralPath (Join-Path $Evidence 'mutant-results.json') -Encoding utf8
        git restore -- $mutant.File
        if ($LASTEXITCODE -ne 0) { throw 'Cannot restore isolated mutation target.' }
        Write-Output "$($mutant.Name): $classification"
        if (!$detected) { throw "Required mutant was not detected by its semantic assertion: $($mutant.Name)" }
    }
} finally { Pop-Location }
if ($records.Count -ne 7 -or @($records | Where-Object { !$_.Detected }).Count -ne 0) { throw 'Incomplete campaign.' }
$gate = [ordered]@{
    ImplementationHead = $head; ManifestVersion = $primary.ManifestVersion; ManifestBlob = $primary.ManifestBlob
    CoderOwnedRequiredPassed = 133; ExecutedMutants = $records.Count; CandidateReady = $true
    IndependentConformance = 'AWAITING FRESH INDEPENDENT REVIEW'; FullFrozenCompletionGate = $false
    Control = 'control.trx: all six detectors passed'; MutationEvidence = 'slice1-v2-mutants/mutant-results.json'
}
$gate | ConvertTo-Json -Depth 5 | Set-Content -LiteralPath $gatePath -Encoding utf8
Write-Output "COMPLETE CANDIDATE evidence gate: $head"
