param(
    [Parameter(Mandatory = $true)][string]$Dotnet,
    [Parameter(Mandatory = $true)][string]$Checkout,
    [Parameter(Mandatory = $true)][string]$Evidence,
    [string]$Revision = 'HEAD'
)
$ErrorActionPreference = 'Stop'
$repo = (git rev-parse --show-toplevel).Trim()
$head = (git rev-parse $Revision).Trim()
if (Test-Path -LiteralPath $Checkout) { throw 'Mutation checkout must be new.' }
New-Item -ItemType Directory -Path $Evidence -Force | Out-Null
git worktree add --detach $Checkout $head
if ($LASTEXITCODE -ne 0) { throw 'Cannot create detached mutation checkout.' }
$records = @()
function Replace-Exact([string]$file, [string]$old, [string]$replacement) {
    $path = Join-Path $Checkout $file
    $text = [IO.File]::ReadAllText($path)
    if (($text.Split([string[]]@($old), [StringSplitOptions]::None).Count - 1) -ne 1) { throw "Mutation seam not unique: $file / $old" }
    [IO.File]::WriteAllText($path, $text.Replace($old, $replacement))
}
$mutants = @(
    @{ Name = 'structural-hidden-eligibility'; Filter = 'FullyQualifiedName~ExecuteFrozenSlice4Evidence|FullyQualifiedName~NonparticipantCannotNominateOrOccupyRole'; Edit = {
        Replace-Exact 'src/Mesopotamia.Sim/HouseholdState.cs' '    private long nextHeadRole = 1;' "    internal bool CachedNomineeEligible = true;`n    private long nextHeadRole = 1;"
        Replace-Exact 'src/Mesopotamia.Sim/HouseholdHeadExecution.cs' 'if (!current.Any(a => a.Person == terms.Nominee))' 'if (!households.CachedNomineeEligible && !current.Any(a => a.Person == terms.Nominee))'
    } },
    @{ Name = '53-current-need-only'; Filter = 'FullyQualifiedName~Slice4ReconsiderationTests'; Edit = {
        Replace-Exact 'src/Mesopotamia.Sim/HouseholdCollectiveRules.cs' 'refusal.MaterialNeedChange is null) return' '(refusal.MaterialNeedChange is null || now.NeedyParticipants.IsEmpty)) return'
    } },
    @{ Name = '54-funding-required-for-need'; Filter = 'FullyQualifiedName~Slice4ReconsiderationTests'; Edit = {
        Replace-Exact 'src/Mesopotamia.Sim/HouseholdCollectiveExecution.cs' 'if (proposal.Terms is ProposeMediatedMarriage demand)' 'if (proposal.Terms is ProposeMediatedMarriage demand && HouseholdFunding.Evaluate(world, households.Snapshot(cycle), authority, cost, null, proposal.Actor).Failure is null)'
    } },
    @{ Name = '55-old-need-survives-new-refusal'; Filter = 'FullyQualifiedName~Slice4ReconsiderationTests'; Edit = {
        Replace-Exact 'src/Mesopotamia.Sim/HouseholdCollectiveExecution.cs' '{ EligibleSupportCohort = EligibleSupportCohort(authority.Household) };' '{ EligibleSupportCohort = EligibleSupportCohort(authority.Household), MaterialNeedChange = households.ProvisionRefusals.GetValueOrDefault(new(authority.Household, provision.Contributor))?.MaterialNeedChange };'
    } },
    @{ Name = '56-invalid-retry-manufactures-need'; Filter = 'FullyQualifiedName~Slice4ReconsiderationTests'; Edit = {
        Replace-Exact 'src/Mesopotamia.Sim/HouseholdCollectiveExecution.cs' '{ Finish(proposal, OutcomeKind.Unable, failure, request, outcomes); return null; }' '{ if (proposal.Terms is ProposeMediatedMarriage invalidDemand && HouseholdCollectiveRules.Authority(proposal, households) is { } invalidAuthority) materialNeeds.Add(new(HouseholdMaterialNeedKind.MediatedDowry, invalidAuthority, proposal.Actor, null, request, new(cycle, reactionIndex - 1), invalidDemand, [])); Finish(proposal, OutcomeKind.Unable, failure, request, outcomes); return null; }'
    } }
)
Push-Location $Checkout
try {
    & $Dotnet restore Mesopotamia.Sim.slnx *> (Join-Path $Evidence 'restore.log')
    if ($LASTEXITCODE -ne 0) { throw 'Mutant restore failed.' }
    foreach ($mutant in $mutants) {
        & $mutant.Edit
        $patchPath = Join-Path $Evidence ($mutant.Name + '.patch')
        git diff "--output=$patchPath"
        if ($LASTEXITCODE -ne 0) { throw 'Cannot save exact mutant patch.' }
        & $Dotnet build Mesopotamia.Sim.slnx --configuration Release --no-restore *> (Join-Path $Evidence ($mutant.Name + '-build.log'))
        if ($LASTEXITCODE -ne 0) { throw "Mutant did not compile: $($mutant.Name)" }
        & $Dotnet 'tests/Mesopotamia.Sim.AcceptanceTests/bin/Release/net10.0/Mesopotamia.Sim.AcceptanceTests.dll' --filter $mutant.Filter --no-ansi --progress off --report-trx --report-trx-filename (Join-Path $Evidence ($mutant.Name + '.trx')) *> (Join-Path $Evidence ($mutant.Name + '-test.log'))
        $exitCode = $LASTEXITCODE
        [xml]$trx = Get-Content -LiteralPath (Join-Path $Evidence ($mutant.Name + '.trx')) -Raw
        $failed = @($trx.TestRun.Results.UnitTestResult | Where-Object outcome -eq 'Failed' | ForEach-Object { $_.testName })
        $records += [pscustomobject]@{ Name = $mutant.Name; BaseHead = $head; ExitCode = $exitCode; FailedTests = $failed; Detected = ($exitCode -eq 2 -and $failed.Count -gt 0) }
        $records | ConvertTo-Json -Depth 6 | Set-Content -LiteralPath (Join-Path $Evidence 'mutant-results.json') -Encoding utf8
        Write-Output "$($mutant.Name): exit=$exitCode; failed=$($failed -join ', ')"
        git restore -- src/Mesopotamia.Sim/HouseholdState.cs src/Mesopotamia.Sim/HouseholdHeadExecution.cs src/Mesopotamia.Sim/HouseholdCollectiveRules.cs src/Mesopotamia.Sim/HouseholdCollectiveExecution.cs
        if ($exitCode -ne 2 -or $failed.Count -eq 0) { throw "Mutant not detected by an assertion: $($mutant.Name)" }
    }
} finally { Pop-Location }
