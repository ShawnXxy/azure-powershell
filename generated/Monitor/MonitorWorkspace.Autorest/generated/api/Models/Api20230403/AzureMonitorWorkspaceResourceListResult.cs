// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Runtime.Extensions;

    /// <summary>A pageable list of resources</summary>
    public partial class AzureMonitorWorkspaceResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResourceListResult,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResourceListResultInternal
    {

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to use for getting the next set of results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; set => this._nextLink = value; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResource[] _value;

        /// <summary>A list of resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResource[] Value { get => this._value; set => this._value = value; }

        /// <summary>Creates an new <see cref="AzureMonitorWorkspaceResourceListResult" /> instance.</summary>
        public AzureMonitorWorkspaceResourceListResult()
        {

        }
    }
    /// A pageable list of resources
    public partial interface IAzureMonitorWorkspaceResourceListResult :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Runtime.IJsonSerializable
    {
        /// <summary>The URL to use for getting the next set of results</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The URL to use for getting the next set of results",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get; set; }
        /// <summary>A list of resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"A list of resources",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResource) })]
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResource[] Value { get; set; }

    }
    /// A pageable list of resources
    internal partial interface IAzureMonitorWorkspaceResourceListResultInternal

    {
        /// <summary>The URL to use for getting the next set of results</summary>
        string NextLink { get; set; }
        /// <summary>A list of resources</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.MonitorWorkspace.Models.Api20230403.IAzureMonitorWorkspaceResource[] Value { get; set; }

    }
}