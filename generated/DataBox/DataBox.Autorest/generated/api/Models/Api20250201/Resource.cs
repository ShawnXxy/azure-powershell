// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Extensions;

    /// <summary>Model of the Resource.</summary>
    public partial class Resource :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResource,
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceInternal
    {

        /// <summary>Backing field for <see cref="Identity" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentity _identity;

        /// <summary>Msi identity of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentity Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ResourceIdentity()); set => this._identity = value; }

        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).PrincipalId; }

        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).TenantId; }

        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string IdentityType { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).Type = value ?? null; }

        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).UserAssignedIdentity; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).UserAssignedIdentity = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>
        /// The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast
        /// Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on
        /// update the request will succeed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Internal Acessors for Identity</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentity Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceInternal.Identity { get => (this._identity = this._identity ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ResourceIdentity()); set { {_identity = value;} } }

        /// <summary>Internal Acessors for IdentityPrincipalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceInternal.IdentityPrincipalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).PrincipalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).PrincipalId = value; }

        /// <summary>Internal Acessors for IdentityTenantId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceInternal.IdentityTenantId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).TenantId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityInternal)Identity).TenantId = value; }

        /// <summary>Internal Acessors for Sku</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISku Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceInternal.Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.Sku()); set { {_sku = value;} } }

        /// <summary>Backing field for <see cref="Sku" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISku _sku;

        /// <summary>The sku type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISku Sku { get => (this._sku = this._sku ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.Sku()); set => this._sku = value; }

        /// <summary>The display name of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).DisplayName = value ?? null; }

        /// <summary>The sku family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public string SkuFamily { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).Family; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).Family = value ?? null; }

        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName? SkuModel { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).Model; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).Model = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName)""); }

        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName SkuName { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISkuInternal)Sku).Name = value ; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceTags _tag;

        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataBox.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ResourceTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="Resource" /> instance.</summary>
        public Resource()
        {

        }
    }
    /// Model of the Resource.
    public partial interface IResource :
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.IJsonSerializable
    {
        /// <summary>Service Principal Id backing the Msi</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Service Principal Id backing the Msi",
        SerializedName = @"principalId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityPrincipalId { get;  }
        /// <summary>Home Tenant Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Home Tenant Id",
        SerializedName = @"tenantId",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityTenantId { get;  }
        /// <summary>Identity type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Identity type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User Assigned Identities",
        SerializedName = @"userAssignedIdentities",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityUserAssignedIdentities) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast
        /// Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on
        /// update the request will succeed.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on update the request will succeed.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The display name of the sku.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The display name of the sku.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string SkuDisplayName { get; set; }
        /// <summary>The sku family.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The sku family.",
        SerializedName = @"family",
        PossibleTypes = new [] { typeof(string) })]
        string SkuFamily { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025",
        SerializedName = @"model",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName? SkuModel { get; set; }
        /// <summary>The sku name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The sku name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName SkuName { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups).",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceTags Tag { get; set; }

    }
    /// Model of the Resource.
    internal partial interface IResourceInternal

    {
        /// <summary>Msi identity of the resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentity Identity { get; set; }
        /// <summary>Service Principal Id backing the Msi</summary>
        string IdentityPrincipalId { get; set; }
        /// <summary>Home Tenant Id</summary>
        string IdentityTenantId { get; set; }
        /// <summary>Identity type</summary>
        string IdentityType { get; set; }
        /// <summary>User Assigned Identities</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceIdentityUserAssignedIdentities IdentityUserAssignedIdentity { get; set; }
        /// <summary>
        /// The location of the resource. This will be one of the supported and registered Azure Regions (e.g. West US, East US, Southeast
        /// Asia, etc.). The region of a resource cannot be changed once it is created, but if an identical region is specified on
        /// update the request will succeed.
        /// </summary>
        string Location { get; set; }
        /// <summary>The sku type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ISku Sku { get; set; }
        /// <summary>The display name of the sku.</summary>
        string SkuDisplayName { get; set; }
        /// <summary>The sku family.</summary>
        string SkuFamily { get; set; }
        /// <summary>
        /// The customer friendly name of the combination of version and capacity of the device. This field is necessary only at the
        /// time of ordering the newer generation device i.e. AzureDataBox120 and AzureDataBox525 as of Feb/2025
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.ModelName? SkuModel { get; set; }
        /// <summary>The sku name.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.SkuName SkuName { get; set; }
        /// <summary>
        /// The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across
        /// resource groups).
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.IResourceTags Tag { get; set; }

    }
}