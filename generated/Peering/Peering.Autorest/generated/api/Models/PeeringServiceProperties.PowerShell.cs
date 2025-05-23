// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.PowerShell;

    /// <summary>The properties that define connectivity to the Peering Service.</summary>
    [System.ComponentModel.TypeConverter(typeof(PeeringServicePropertiesTypeConverter))]
    public partial class PeeringServiceProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.PeeringServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServiceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServiceProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new PeeringServiceProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.PeeringServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServiceProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServiceProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new PeeringServiceProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="PeeringServiceProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="PeeringServiceProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServiceProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.PeeringServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal PeeringServiceProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogAnalyticsWorkspaceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticsWorkspaceProperty = (Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.ILogAnalyticsWorkspaceProperties) content.GetValueForProperty("LogAnalyticsWorkspaceProperty",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticsWorkspaceProperty, Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.LogAnalyticsWorkspacePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PeeringServiceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceLocation = (string) content.GetValueForProperty("PeeringServiceLocation",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("PeeringServiceProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceProvider = (string) content.GetValueForProperty("PeeringServiceProvider",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceProvider, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderPrimaryPeeringLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderPrimaryPeeringLocation = (string) content.GetValueForProperty("ProviderPrimaryPeeringLocation",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderPrimaryPeeringLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderBackupPeeringLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderBackupPeeringLocation = (string) content.GetValueForProperty("ProviderBackupPeeringLocation",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderBackupPeeringLocation, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticWorkspacePropertyWorkspaceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyWorkspaceId = (string) content.GetValueForProperty("LogAnalyticWorkspacePropertyWorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyWorkspaceId, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticWorkspacePropertyKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyKey = (string) content.GetValueForProperty("LogAnalyticWorkspacePropertyKey",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyKey, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticWorkspacePropertyConnectedAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyConnectedAgent = (System.Collections.Generic.List<string>) content.GetValueForProperty("LogAnalyticWorkspacePropertyConnectedAgent",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyConnectedAgent, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.PeeringServiceProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal PeeringServiceProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("LogAnalyticsWorkspaceProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticsWorkspaceProperty = (Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.ILogAnalyticsWorkspaceProperties) content.GetValueForProperty("LogAnalyticsWorkspaceProperty",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticsWorkspaceProperty, Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.LogAnalyticsWorkspacePropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("PeeringServiceLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceLocation = (string) content.GetValueForProperty("PeeringServiceLocation",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceLocation, global::System.Convert.ToString);
            }
            if (content.Contains("PeeringServiceProvider"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceProvider = (string) content.GetValueForProperty("PeeringServiceProvider",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).PeeringServiceProvider, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderPrimaryPeeringLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderPrimaryPeeringLocation = (string) content.GetValueForProperty("ProviderPrimaryPeeringLocation",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderPrimaryPeeringLocation, global::System.Convert.ToString);
            }
            if (content.Contains("ProviderBackupPeeringLocation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderBackupPeeringLocation = (string) content.GetValueForProperty("ProviderBackupPeeringLocation",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).ProviderBackupPeeringLocation, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticWorkspacePropertyWorkspaceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyWorkspaceId = (string) content.GetValueForProperty("LogAnalyticWorkspacePropertyWorkspaceId",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyWorkspaceId, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticWorkspacePropertyKey"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyKey = (string) content.GetValueForProperty("LogAnalyticWorkspacePropertyKey",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyKey, global::System.Convert.ToString);
            }
            if (content.Contains("LogAnalyticWorkspacePropertyConnectedAgent"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyConnectedAgent = (System.Collections.Generic.List<string>) content.GetValueForProperty("LogAnalyticWorkspacePropertyConnectedAgent",((Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.IPeeringServicePropertiesInternal)this).LogAnalyticWorkspacePropertyConnectedAgent, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The properties that define connectivity to the Peering Service.
    [System.ComponentModel.TypeConverter(typeof(PeeringServicePropertiesTypeConverter))]
    public partial interface IPeeringServiceProperties

    {

    }
}