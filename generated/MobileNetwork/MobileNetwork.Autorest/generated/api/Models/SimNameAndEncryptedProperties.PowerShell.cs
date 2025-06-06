// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.PowerShell;

    /// <summary>SIM name and encrypted properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(SimNameAndEncryptedPropertiesTypeConverter))]
    public partial class SimNameAndEncryptedProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimNameAndEncryptedProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new SimNameAndEncryptedProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimNameAndEncryptedProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new SimNameAndEncryptedProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="SimNameAndEncryptedProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="SimNameAndEncryptedProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimNameAndEncryptedProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal SimNameAndEncryptedProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.EncryptedSimPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("SimState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimState = (string) content.GetValueForProperty("SimState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimState, global::System.Convert.ToString);
            }
            if (content.Contains("SiteProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SiteProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning) content.GetValueForProperty("SiteProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SiteProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SiteProvisioningTypeConverter.ConvertFrom);
            }
            if (content.Contains("SimPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicy = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimPolicyResourceId) content.GetValueForProperty("SimPolicy",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicy, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimPolicyResourceIdTypeConverter.ConvertFrom);
            }
            if (content.Contains("InternationalMobileSubscriberIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).InternationalMobileSubscriberIdentity = (string) content.GetValueForProperty("InternationalMobileSubscriberIdentity",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).InternationalMobileSubscriberIdentity, global::System.Convert.ToString);
            }
            if (content.Contains("IntegratedCircuitCardIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).IntegratedCircuitCardIdentifier = (string) content.GetValueForProperty("IntegratedCircuitCardIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).IntegratedCircuitCardIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).DeviceType = (string) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).DeviceType, global::System.Convert.ToString);
            }
            if (content.Contains("StaticIPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).StaticIPConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties>) content.GetValueForProperty("StaticIPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).StaticIPConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimStaticIPPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("VendorName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorName = (string) content.GetValueForProperty("VendorName",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorName, global::System.Convert.ToString);
            }
            if (content.Contains("VendorKeyFingerprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorKeyFingerprint = (string) content.GetValueForProperty("VendorKeyFingerprint",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorKeyFingerprint, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptedCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).EncryptedCredentials = (string) content.GetValueForProperty("EncryptedCredentials",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).EncryptedCredentials, global::System.Convert.ToString);
            }
            if (content.Contains("SimPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicyId = (string) content.GetValueForProperty("SimPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicyId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimNameAndEncryptedProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal SimNameAndEncryptedProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.IEncryptedSimPropertiesFormat) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.EncryptedSimPropertiesFormatTypeConverter.ConvertFrom);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("SimState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimState = (string) content.GetValueForProperty("SimState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimState, global::System.Convert.ToString);
            }
            if (content.Contains("SiteProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SiteProvisioningState = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISiteProvisioning) content.GetValueForProperty("SiteProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SiteProvisioningState, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SiteProvisioningTypeConverter.ConvertFrom);
            }
            if (content.Contains("SimPolicy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicy = (Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimPolicyResourceId) content.GetValueForProperty("SimPolicy",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicy, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimPolicyResourceIdTypeConverter.ConvertFrom);
            }
            if (content.Contains("InternationalMobileSubscriberIdentity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).InternationalMobileSubscriberIdentity = (string) content.GetValueForProperty("InternationalMobileSubscriberIdentity",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).InternationalMobileSubscriberIdentity, global::System.Convert.ToString);
            }
            if (content.Contains("IntegratedCircuitCardIdentifier"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).IntegratedCircuitCardIdentifier = (string) content.GetValueForProperty("IntegratedCircuitCardIdentifier",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).IntegratedCircuitCardIdentifier, global::System.Convert.ToString);
            }
            if (content.Contains("DeviceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).DeviceType = (string) content.GetValueForProperty("DeviceType",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).DeviceType, global::System.Convert.ToString);
            }
            if (content.Contains("StaticIPConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).StaticIPConfiguration = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties>) content.GetValueForProperty("StaticIPConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).StaticIPConfiguration, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimStaticIPProperties>(__y, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.SimStaticIPPropertiesTypeConverter.ConvertFrom));
            }
            if (content.Contains("VendorName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorName = (string) content.GetValueForProperty("VendorName",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorName, global::System.Convert.ToString);
            }
            if (content.Contains("VendorKeyFingerprint"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorKeyFingerprint = (string) content.GetValueForProperty("VendorKeyFingerprint",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).VendorKeyFingerprint, global::System.Convert.ToString);
            }
            if (content.Contains("EncryptedCredentials"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).EncryptedCredentials = (string) content.GetValueForProperty("EncryptedCredentials",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).EncryptedCredentials, global::System.Convert.ToString);
            }
            if (content.Contains("SimPolicyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicyId = (string) content.GetValueForProperty("SimPolicyId",((Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.ISimNameAndEncryptedPropertiesInternal)this).SimPolicyId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// SIM name and encrypted properties.
    [System.ComponentModel.TypeConverter(typeof(SimNameAndEncryptedPropertiesTypeConverter))]
    public partial interface ISimNameAndEncryptedProperties

    {

    }
}