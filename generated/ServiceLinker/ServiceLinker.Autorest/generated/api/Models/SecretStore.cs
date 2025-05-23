// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Extensions;

    /// <summary>An option to store secret value in secure place</summary>
    public partial class SecretStore :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretStore,
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Models.ISecretStoreInternal
    {

        /// <summary>Backing field for <see cref="KeyVaultId" /> property.</summary>
        private string _keyVaultId;

        /// <summary>The key vault id to store secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        public string KeyVaultId { get => this._keyVaultId; set => this._keyVaultId = value; }

        /// <summary>Backing field for <see cref="KeyVaultSecretName" /> property.</summary>
        private string _keyVaultSecretName;

        /// <summary>The key vault secret name to store secret, only valid when storing one secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Origin(Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.PropertyOrigin.Owned)]
        public string KeyVaultSecretName { get => this._keyVaultSecretName; set => this._keyVaultSecretName = value; }

        /// <summary>Creates an new <see cref="SecretStore" /> instance.</summary>
        public SecretStore()
        {

        }
    }
    /// An option to store secret value in secure place
    public partial interface ISecretStore :
        Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.IJsonSerializable
    {
        /// <summary>The key vault id to store secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key vault id to store secret",
        SerializedName = @"keyVaultId",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultId { get; set; }
        /// <summary>The key vault secret name to store secret, only valid when storing one secret</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ServiceLinker.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The key vault secret name to store secret, only valid when storing one secret",
        SerializedName = @"keyVaultSecretName",
        PossibleTypes = new [] { typeof(string) })]
        string KeyVaultSecretName { get; set; }

    }
    /// An option to store secret value in secure place
    internal partial interface ISecretStoreInternal

    {
        /// <summary>The key vault id to store secret</summary>
        string KeyVaultId { get; set; }
        /// <summary>The key vault secret name to store secret, only valid when storing one secret</summary>
        string KeyVaultSecretName { get; set; }

    }
}