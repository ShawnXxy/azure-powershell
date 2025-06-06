// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Extensions;

    /// <summary>Solution Invocation with additional params needed for invocation.</summary>
    public partial class DiagnosticInvocation :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocation,
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocationInternal
    {

        /// <summary>Backing field for <see cref="AdditionalParameter" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocationAdditionalParameters _additionalParameter;

        /// <summary>Additional parameters required to invoke the solutionId.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocationAdditionalParameters AdditionalParameter { get => (this._additionalParameter = this._additionalParameter ?? new Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.DiagnosticInvocationAdditionalParameters()); set => this._additionalParameter = value; }

        /// <summary>Backing field for <see cref="SolutionId" /> property.</summary>
        private string _solutionId;

        /// <summary>Solution Id to invoke.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Origin(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.PropertyOrigin.Owned)]
        public string SolutionId { get => this._solutionId; set => this._solutionId = value; }

        /// <summary>Creates an new <see cref="DiagnosticInvocation" /> instance.</summary>
        public DiagnosticInvocation()
        {

        }
    }
    /// Solution Invocation with additional params needed for invocation.
    public partial interface IDiagnosticInvocation :
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.IJsonSerializable
    {
        /// <summary>Additional parameters required to invoke the solutionId.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional parameters required to invoke the solutionId.",
        SerializedName = @"additionalParameters",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocationAdditionalParameters) })]
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocationAdditionalParameters AdditionalParameter { get; set; }
        /// <summary>Solution Id to invoke.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Solution Id to invoke.",
        SerializedName = @"solutionId",
        PossibleTypes = new [] { typeof(string) })]
        string SolutionId { get; set; }

    }
    /// Solution Invocation with additional params needed for invocation.
    internal partial interface IDiagnosticInvocationInternal

    {
        /// <summary>Additional parameters required to invoke the solutionId.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.SelfHelp.Models.IDiagnosticInvocationAdditionalParameters AdditionalParameter { get; set; }
        /// <summary>Solution Id to invoke.</summary>
        string SolutionId { get; set; }

    }
}