
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
Create an in-memory object for PyPiLibraryProperties.
.Description
Create an in-memory object for PyPiLibraryProperties.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.PyPiLibraryProperties
.Link
https://learn.microsoft.com/powershell/module/Az.HdInsightOnAks/new-azhdinsightonaksclusterpypilibraryobject
#>
function New-AzHdInsightOnAksClusterPyPiLibraryObject {
    [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.ModelCmdletAttribute()]
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterLibrary')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter(Mandatory, HelpMessage="Name of the PyPi package.")]
        [string]
        $Name,
        [Parameter(HelpMessage="Version of the PyPi package.")]
        [string]
        $Version,
        [Parameter(HelpMessage="Remark of the latest library management operation.")]
        [string]
        $Remark
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.PyPiLibraryProperties]::New()

        if ($PSBoundParameters.ContainsKey('Name')) {
            $Object.Name = $Name
        }
        if ($PSBoundParameters.ContainsKey('Version')) {
            $Object.Version = $Version
        }
        if ($PSBoundParameters.ContainsKey('Remark')) {
            $Object.Remark = $Remark
        }

        $LibraryObj = [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterLibrary]::New()

        $LibraryObj.Property = $Object

        return $LibraryObj
    }
}

