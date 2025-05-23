// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Extensions;

    /// <summary>Payload for iSCSI Target update requests.</summary>
    public partial class IscsiTargetUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdate,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdateInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.ProxyResource();

        /// <summary>
        /// Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun> Lun { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdatePropertiesInternal)Property).Lun; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdatePropertiesInternal)Property).Lun = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="ManagedBy" /> property.</summary>
        private string _managedBy;

        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public string ManagedBy { get => this._managedBy; set => this._managedBy = value; }

        /// <summary>Backing field for <see cref="ManagedByExtended" /> property.</summary>
        private System.Collections.Generic.List<string> _managedByExtended;

        /// <summary>List of Azure resource ids that manage this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ManagedByExtended { get => this._managedByExtended; set => this._managedByExtended = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdateProperties Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdateInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IscsiTargetUpdateProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdateProperties _property;

        /// <summary>Properties for iSCSI Target update request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdateProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IscsiTargetUpdateProperties()); set => this._property = value; }

        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl> StaticAcls { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdatePropertiesInternal)Property).StaticAcls; set => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdatePropertiesInternal)Property).StaticAcls = value ?? null /* arrayOf */; }

        /// <summary>
        /// The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Origin(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="IscsiTargetUpdate" /> instance.</summary>
        public IscsiTargetUpdate()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Payload for iSCSI Target update requests.
    public partial interface IIscsiTargetUpdate :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResource
    {
        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of LUNs to be exposed through iSCSI Target.",
        SerializedName = @"luns",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun> Lun { get; set; }
        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure resource id. Indicates if this resource is managed by another Azure resource.",
        SerializedName = @"managedBy",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedBy { get; set; }
        /// <summary>List of Azure resource ids that manage this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Azure resource ids that manage this resource.",
        SerializedName = @"managedByExtended",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ManagedByExtended { get; set; }
        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Access Control List (ACL) for an iSCSI Target; defines LUN masking policy",
        SerializedName = @"staticAcls",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl> StaticAcls { get; set; }

    }
    /// Payload for iSCSI Target update requests.
    internal partial interface IIscsiTargetUpdateInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IProxyResourceInternal
    {
        /// <summary>List of LUNs to be exposed through iSCSI Target.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiLun> Lun { get; set; }
        /// <summary>
        /// Azure resource id. Indicates if this resource is managed by another Azure resource.
        /// </summary>
        string ManagedBy { get; set; }
        /// <summary>List of Azure resource ids that manage this resource.</summary>
        System.Collections.Generic.List<string> ManagedByExtended { get; set; }
        /// <summary>Properties for iSCSI Target update request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IIscsiTargetUpdateProperties Property { get; set; }
        /// <summary>Access Control List (ACL) for an iSCSI Target; defines LUN masking policy</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.DiskPool.Models.IAcl> StaticAcls { get; set; }

    }
}