// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Extensions;

    /// <summary>Dataflow Destination Operation properties</summary>
    public partial class DataflowDestinationOperationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowDestinationOperationSettings,
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Models.IDataflowDestinationOperationSettingsInternal
    {

        /// <summary>Backing field for <see cref="DataDestination" /> property.</summary>
        private string _dataDestination;

        /// <summary>
        /// Destination location, can be a topic or table name. Supports dynamic values with $topic, $systemProperties, $userProperties,
        /// $payload, $context, and $subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string DataDestination { get => this._dataDestination; set => this._dataDestination = value; }

        /// <summary>Backing field for <see cref="EndpointRef" /> property.</summary>
        private string _endpointRef;

        /// <summary>Reference to the Endpoint CR. Can be of Broker, Kafka, Fabric, ADLS, ADX type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Origin(Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.PropertyOrigin.Owned)]
        public string EndpointRef { get => this._endpointRef; set => this._endpointRef = value; }

        /// <summary>Creates an new <see cref="DataflowDestinationOperationSettings" /> instance.</summary>
        public DataflowDestinationOperationSettings()
        {

        }
    }
    /// Dataflow Destination Operation properties
    public partial interface IDataflowDestinationOperationSettings :
        Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Destination location, can be a topic or table name. Supports dynamic values with $topic, $systemProperties, $userProperties,
        /// $payload, $context, and $subscription.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Destination location, can be a topic or table name. Supports dynamic values with $topic, $systemProperties, $userProperties, $payload, $context, and $subscription.",
        SerializedName = @"dataDestination",
        PossibleTypes = new [] { typeof(string) })]
        string DataDestination { get; set; }
        /// <summary>Reference to the Endpoint CR. Can be of Broker, Kafka, Fabric, ADLS, ADX type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.IoTOperationsService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Reference to the Endpoint CR. Can be of Broker, Kafka, Fabric, ADLS, ADX type.",
        SerializedName = @"endpointRef",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointRef { get; set; }

    }
    /// Dataflow Destination Operation properties
    internal partial interface IDataflowDestinationOperationSettingsInternal

    {
        /// <summary>
        /// Destination location, can be a topic or table name. Supports dynamic values with $topic, $systemProperties, $userProperties,
        /// $payload, $context, and $subscription.
        /// </summary>
        string DataDestination { get; set; }
        /// <summary>Reference to the Endpoint CR. Can be of Broker, Kafka, Fabric, ADLS, ADX type.</summary>
        string EndpointRef { get; set; }

    }
}