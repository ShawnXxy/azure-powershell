
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Get the specified private endpoint connection associated with the container registry.
.Description
Get the specified private endpoint connection associated with the container registry.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.IContainerRegistryIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPrivateEndpointConnection
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IContainerRegistryIdentity>: Identity Parameter
  [AgentPoolName <String>]: The name of the agent pool.
  [CacheRuleName <String>]: The name of the cache rule.
  [ConnectedRegistryName <String>]: The name of the connected registry.
  [CredentialSetName <String>]: The name of the credential set.
  [ExportPipelineName <String>]: The name of the export pipeline.
  [GroupName <String>]: The name of the private link resource.
  [Id <String>]: Resource identity path
  [ImportPipelineName <String>]: The name of the import pipeline.
  [PipelineRunName <String>]: The name of the pipeline run.
  [PrivateEndpointConnectionName <String>]: The name of the private endpoint connection.
  [RegistryName <String>]: The name of the container registry.
  [ReplicationName <String>]: The name of the replication.
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RunId <String>]: The run ID.
  [ScopeMapName <String>]: The name of the scope map.
  [SubscriptionId <String>]: The ID of the target subscription. The value must be an UUID.
  [TaskName <String>]: The name of the container registry task.
  [TaskRunName <String>]: The name of the task run.
  [TokenName <String>]: The name of the token.
  [WebhookName <String>]: The name of the webhook.
.Link
https://learn.microsoft.com/powershell/module/az.containerregistry/get-azcontainerregistryprivateendpointconnection
#>
function Get-AzContainerRegistryPrivateEndpointConnection {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.Api202301Preview.IPrivateEndpointConnection])]
[CmdletBinding(DefaultParameterSetName='List', PositionalBinding=$false)]
param(
    [Parameter(ParameterSetName='Get', Mandatory)]
    [Alias('PrivateEndpointConnectionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the private endpoint connection.
    ${Name},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the container registry.
    ${RegistryName},

    [Parameter(ParameterSetName='Get', Mandatory)]
    [Parameter(ParameterSetName='List', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='Get')]
    [Parameter(ParameterSetName='List')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String[]]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter(ParameterSetName='GetViaIdentity', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Models.IContainerRegistryIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        $mapping = @{
            Get = 'Az.ContainerRegistry.private\Get-AzContainerRegistryPrivateEndpointConnection_Get';
            GetViaIdentity = 'Az.ContainerRegistry.private\Get-AzContainerRegistryPrivateEndpointConnection_GetViaIdentity';
            List = 'Az.ContainerRegistry.private\Get-AzContainerRegistryPrivateEndpointConnection_List';
        }
        if (('Get', 'List') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {

        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {

        throw
    }

}
end {
    try {
        $steppablePipeline.End()

    } catch {

        throw
    }
} 
}
