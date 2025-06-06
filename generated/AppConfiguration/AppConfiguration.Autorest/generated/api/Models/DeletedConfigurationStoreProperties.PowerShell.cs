// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.PowerShell;

    /// <summary>Properties of the deleted configuration store.</summary>
    [System.ComponentModel.TypeConverter(typeof(DeletedConfigurationStorePropertiesTypeConverter))]
    public partial class DeletedConfigurationStoreProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.DeletedConfigurationStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DeletedConfigurationStoreProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConfigurationStoreId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ConfigurationStoreId = (string) content.GetValueForProperty("ConfigurationStoreId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ConfigurationStoreId, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).DeletionDate = (global::System.DateTime?) content.GetValueForProperty("DeletionDate",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).DeletionDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduledPurgeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ScheduledPurgeDate = (global::System.DateTime?) content.GetValueForProperty("ScheduledPurgeDate",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ScheduledPurgeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.DeletedConfigurationStorePropertiesTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PurgeProtectionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).PurgeProtectionEnabled = (bool?) content.GetValueForProperty("PurgeProtectionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).PurgeProtectionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.DeletedConfigurationStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DeletedConfigurationStoreProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ConfigurationStoreId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ConfigurationStoreId = (string) content.GetValueForProperty("ConfigurationStoreId",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ConfigurationStoreId, global::System.Convert.ToString);
            }
            if (content.Contains("Location"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Location, global::System.Convert.ToString);
            }
            if (content.Contains("DeletionDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).DeletionDate = (global::System.DateTime?) content.GetValueForProperty("DeletionDate",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).DeletionDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("ScheduledPurgeDate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ScheduledPurgeDate = (global::System.DateTime?) content.GetValueForProperty("ScheduledPurgeDate",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).ScheduledPurgeDate, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Tag"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.DeletedConfigurationStorePropertiesTagsTypeConverter.ConvertFrom);
            }
            if (content.Contains("PurgeProtectionEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).PurgeProtectionEnabled = (bool?) content.GetValueForProperty("PurgeProtectionEnabled",((Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStorePropertiesInternal)this).PurgeProtectionEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.DeletedConfigurationStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStoreProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStoreProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DeletedConfigurationStoreProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.DeletedConfigurationStoreProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStoreProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStoreProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DeletedConfigurationStoreProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DeletedConfigurationStoreProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="DeletedConfigurationStoreProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IDeletedConfigurationStoreProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Properties of the deleted configuration store.
    [System.ComponentModel.TypeConverter(typeof(DeletedConfigurationStorePropertiesTypeConverter))]
    public partial interface IDeletedConfigurationStoreProperties

    {

    }
}