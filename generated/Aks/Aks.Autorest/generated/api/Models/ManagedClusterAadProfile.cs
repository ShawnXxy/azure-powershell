// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Aks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Extensions;

    /// <summary>
    /// For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).
    /// </summary>
    public partial class ManagedClusterAadProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAadProfile,
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Models.IManagedClusterAadProfileInternal
    {

        /// <summary>Backing field for <see cref="AdminGroupObjectID" /> property.</summary>
        private System.Collections.Generic.List<string> _adminGroupObjectID;

        /// <summary>The list of AAD group object IDs that will have admin role of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> AdminGroupObjectID { get => this._adminGroupObjectID; set => this._adminGroupObjectID = value; }

        /// <summary>Backing field for <see cref="ClientAppId" /> property.</summary>
        private string _clientAppId;

        /// <summary>
        /// (DEPRECATED) The client AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string ClientAppId { get => this._clientAppId; set => this._clientAppId = value; }

        /// <summary>Backing field for <see cref="EnableAzureRbac" /> property.</summary>
        private bool? _enableAzureRbac;

        /// <summary>Whether to enable Azure RBAC for Kubernetes authorization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public bool? EnableAzureRbac { get => this._enableAzureRbac; set => this._enableAzureRbac = value; }

        /// <summary>Backing field for <see cref="Managed" /> property.</summary>
        private bool? _managed;

        /// <summary>Whether to enable managed AAD.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public bool? Managed { get => this._managed; set => this._managed = value; }

        /// <summary>Backing field for <see cref="ServerAppId" /> property.</summary>
        private string _serverAppId;

        /// <summary>
        /// (DEPRECATED) The server AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string ServerAppId { get => this._serverAppId; set => this._serverAppId = value; }

        /// <summary>Backing field for <see cref="ServerAppSecret" /> property.</summary>
        private string _serverAppSecret;

        /// <summary>
        /// (DEPRECATED) The server AAD application secret. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string ServerAppSecret { get => this._serverAppSecret; set => this._serverAppSecret = value; }

        /// <summary>Backing field for <see cref="TenantId" /> property.</summary>
        private string _tenantId;

        /// <summary>
        /// The AAD tenant ID to use for authentication. If not specified, will use the tenant of the deployment subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Origin(Microsoft.Azure.PowerShell.Cmdlets.Aks.PropertyOrigin.Owned)]
        public string TenantId { get => this._tenantId; set => this._tenantId = value; }

        /// <summary>Creates an new <see cref="ManagedClusterAadProfile" /> instance.</summary>
        public ManagedClusterAadProfile()
        {

        }
    }
    /// For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).
    public partial interface IManagedClusterAadProfile :
        Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.IJsonSerializable
    {
        /// <summary>The list of AAD group object IDs that will have admin role of the cluster.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The list of AAD group object IDs that will have admin role of the cluster.",
        SerializedName = @"adminGroupObjectIDs",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AdminGroupObjectID { get; set; }
        /// <summary>
        /// (DEPRECATED) The client AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"(DEPRECATED) The client AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.",
        SerializedName = @"clientAppID",
        PossibleTypes = new [] { typeof(string) })]
        string ClientAppId { get; set; }
        /// <summary>Whether to enable Azure RBAC for Kubernetes authorization.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to enable Azure RBAC for Kubernetes authorization.",
        SerializedName = @"enableAzureRBAC",
        PossibleTypes = new [] { typeof(bool) })]
        bool? EnableAzureRbac { get; set; }
        /// <summary>Whether to enable managed AAD.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether to enable managed AAD.",
        SerializedName = @"managed",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Managed { get; set; }
        /// <summary>
        /// (DEPRECATED) The server AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"(DEPRECATED) The server AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.",
        SerializedName = @"serverAppID",
        PossibleTypes = new [] { typeof(string) })]
        string ServerAppId { get; set; }
        /// <summary>
        /// (DEPRECATED) The server AAD application secret. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"(DEPRECATED) The server AAD application secret. Learn more at https://aka.ms/aks/aad-legacy.",
        SerializedName = @"serverAppSecret",
        PossibleTypes = new [] { typeof(string) })]
        string ServerAppSecret { get; set; }
        /// <summary>
        /// The AAD tenant ID to use for authentication. If not specified, will use the tenant of the deployment subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Aks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The AAD tenant ID to use for authentication. If not specified, will use the tenant of the deployment subscription.",
        SerializedName = @"tenantID",
        PossibleTypes = new [] { typeof(string) })]
        string TenantId { get; set; }

    }
    /// For more details see [managed AAD on AKS](https://docs.microsoft.com/azure/aks/managed-aad).
    internal partial interface IManagedClusterAadProfileInternal

    {
        /// <summary>The list of AAD group object IDs that will have admin role of the cluster.</summary>
        System.Collections.Generic.List<string> AdminGroupObjectID { get; set; }
        /// <summary>
        /// (DEPRECATED) The client AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        string ClientAppId { get; set; }
        /// <summary>Whether to enable Azure RBAC for Kubernetes authorization.</summary>
        bool? EnableAzureRbac { get; set; }
        /// <summary>Whether to enable managed AAD.</summary>
        bool? Managed { get; set; }
        /// <summary>
        /// (DEPRECATED) The server AAD application ID. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        string ServerAppId { get; set; }
        /// <summary>
        /// (DEPRECATED) The server AAD application secret. Learn more at https://aka.ms/aks/aad-legacy.
        /// </summary>
        string ServerAppSecret { get; set; }
        /// <summary>
        /// The AAD tenant ID to use for authentication. If not specified, will use the tenant of the deployment subscription.
        /// </summary>
        string TenantId { get; set; }

    }
}