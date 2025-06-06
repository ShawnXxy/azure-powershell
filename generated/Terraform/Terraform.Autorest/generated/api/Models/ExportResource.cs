// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.Extensions;

    /// <summary>Export parameter for individual resources.</summary>
    public partial class ExportResource :
        Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IExportResource,
        Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IExportResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModel" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModel __baseExportModel = new Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.BaseExportModel();

        /// <summary>
        /// Whether to output all non-computed properties in the generated Terraform configuration? This probably needs manual modifications
        /// to make it valid
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Inherited)]
        public bool? FullProperty { get => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).FullProperty; set => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).FullProperty = value ?? default(bool); }

        /// <summary>Mask sensitive attributes in the Terraform configuration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Inherited)]
        public bool? MaskSensitive { get => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).MaskSensitive; set => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).MaskSensitive = value ?? default(bool); }

        /// <summary>Backing field for <see cref="NamePattern" /> property.</summary>
        private string _namePattern;

        /// <summary>The name pattern of the Terraform resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Owned)]
        public string NamePattern { get => this._namePattern; set => this._namePattern = value; }

        /// <summary>Backing field for <see cref="ResourceId" /> property.</summary>
        private System.Collections.Generic.List<string> _resourceId;

        /// <summary>The id of the resource to be exported</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> ResourceId { get => this._resourceId; set => this._resourceId = value; }

        /// <summary>Backing field for <see cref="ResourceName" /> property.</summary>
        private string _resourceName;

        /// <summary>
        /// The Terraform resource name. Only works when resourceIds contains only one item.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Owned)]
        public string ResourceName { get => this._resourceName; set => this._resourceName = value; }

        /// <summary>Backing field for <see cref="ResourceType" /> property.</summary>
        private string _resourceType;

        /// <summary>
        /// The Terraform resource type. Only works when resourceIds contains only one item.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Owned)]
        public string ResourceType { get => this._resourceType; set => this._resourceType = value; }

        /// <summary>The target Azure Terraform Provider</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Inherited)]
        public string TargetProvider { get => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).TargetProvider; set => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).TargetProvider = value ?? null; }

        /// <summary>The parameter type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Origin(Microsoft.Azure.PowerShell.Cmdlets.Terraform.PropertyOrigin.Inherited)]
        public string Type { get => "ExportResource"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal)__baseExportModel).Type = "ExportResource"; }

        /// <summary>Creates an new <see cref="ExportResource" /> instance.</summary>
        public ExportResource()
        {
            this.__baseExportModel.Type = "ExportResource";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__baseExportModel), __baseExportModel);
            await eventListener.AssertObjectIsValid(nameof(__baseExportModel), __baseExportModel);
        }
    }
    /// Export parameter for individual resources.
    public partial interface IExportResource :
        Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModel
    {
        /// <summary>The name pattern of the Terraform resources</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name pattern of the Terraform resources",
        SerializedName = @"namePattern",
        PossibleTypes = new [] { typeof(string) })]
        string NamePattern { get; set; }
        /// <summary>The id of the resource to be exported</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The id of the resource to be exported",
        SerializedName = @"resourceIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> ResourceId { get; set; }
        /// <summary>
        /// The Terraform resource name. Only works when resourceIds contains only one item.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Terraform resource name. Only works when resourceIds contains only one item.",
        SerializedName = @"resourceName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceName { get; set; }
        /// <summary>
        /// The Terraform resource type. Only works when resourceIds contains only one item.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Terraform.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Terraform resource type. Only works when resourceIds contains only one item.",
        SerializedName = @"resourceType",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceType { get; set; }

    }
    /// Export parameter for individual resources.
    internal partial interface IExportResourceInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Terraform.Models.IBaseExportModelInternal
    {
        /// <summary>The name pattern of the Terraform resources</summary>
        string NamePattern { get; set; }
        /// <summary>The id of the resource to be exported</summary>
        System.Collections.Generic.List<string> ResourceId { get; set; }
        /// <summary>
        /// The Terraform resource name. Only works when resourceIds contains only one item.
        /// </summary>
        string ResourceName { get; set; }
        /// <summary>
        /// The Terraform resource type. Only works when resourceIds contains only one item.
        /// </summary>
        string ResourceType { get; set; }

    }
}