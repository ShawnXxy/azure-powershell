// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>
    /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults
    /// to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    /// </summary>
    public partial class VolumeClaimResourceRequirementsRequests :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IVolumeClaimResourceRequirementsRequests,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IVolumeClaimResourceRequirementsRequestsInternal
    {

        /// <summary>Creates an new <see cref="VolumeClaimResourceRequirementsRequests" /> instance.</summary>
        public VolumeClaimResourceRequirementsRequests()
        {

        }
    }
    /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults
    /// to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    public partial interface IVolumeClaimResourceRequirementsRequests :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IAssociativeArray<string>
    {

    }
    /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults
    /// to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
    internal partial interface IVolumeClaimResourceRequirementsRequestsInternal

    {

    }
}