// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>Status of the OpenAI Integration</summary>
    public partial class OpenAiIntegrationStatusResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationStatusResponseProperties,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IOpenAiIntegrationStatusResponsePropertiesInternal
    {

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private string _status;

        /// <summary>Status of the OpenAI Integration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public string Status { get => this._status; set => this._status = value; }

        /// <summary>
        /// Creates an new <see cref="OpenAiIntegrationStatusResponseProperties" /> instance.
        /// </summary>
        public OpenAiIntegrationStatusResponseProperties()
        {

        }
    }
    /// Status of the OpenAI Integration
    public partial interface IOpenAiIntegrationStatusResponseProperties :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>Status of the OpenAI Integration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Status of the OpenAI Integration",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        string Status { get; set; }

    }
    /// Status of the OpenAI Integration
    internal partial interface IOpenAiIntegrationStatusResponsePropertiesInternal

    {
        /// <summary>Status of the OpenAI Integration</summary>
        string Status { get; set; }

    }
}