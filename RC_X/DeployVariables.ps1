#
# DeployVariables.ps1
#

$commitId= $env:BUILD_SOURCEVERSION
$shortCommitId = $commitId.Substring(0, 8)
$definitionName= "$env:BUILD_DEFINITIONNAME"
$DateNow= $(Get-Date)
$FullBuildName = $definitionName + "---" + $shortCommitId + "---" + $DateNow


Write-Host ("##vso[task.setvariable variable=rcx_commit;]$commitId")
Write-Host ("##vso[task.setvariable variable=rcx_commit_short;]$shortCommitId")
Write-Host ("##vso[task.setvariable variable=rcx_branch;]$env:BUILD_SOURCEBRANCHNAME")
Write-Host ("##vso[task.setvariable variable=rcx_build_definition;]$definitionName")
Write-Host ("##vso[task.setvariable variable=rcx_build_name;]$FullBuildName")
Write-Host ("##vso[task.setvariable variable=rcx_repo_origin;]$env:BUILD_REPOSITORY_PROVIDER")
Write-Host ("##vso[task.setvariable variable=rcx_repo_pull;]$env:SYSTEM_PULLREQUEST_PULLREQUESTID)")
Write-Host ("##vso[task.setvariable variable=rcx_repo_pullfrom;]$env:SYSTEM_PULLREQUEST_SOURCEBRANCH")
Write-Host ("##vso[task.setvariable variable=rcx_repo_pullto;]$env:SYSTEM_PULLREQUEST_TARGETBRANCH")
Write-Host ("##vso[task.setvariable variable=rcx_commit_message;]$env:BUILD_SOURCEVERSIONMESSAGE")

