// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.PowerShell;

    /// <summary>Query filter parameter to configure TopItemsSummaryReport queries.</summary>
    [System.ComponentModel.TypeConverter(typeof(TopItemsSummaryReportQueryFilterTypeConverter))]
    public partial class TopItemsSummaryReportQueryFilter
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilter" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilter DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new TopItemsSummaryReportQueryFilter(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilter" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilter DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new TopItemsSummaryReportQueryFilter(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="TopItemsSummaryReportQueryFilter" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="TopItemsSummaryReportQueryFilter" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilter FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Carbon.Runtime.SerializationMode.IncludeAll)?.ToString();

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

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal TopItemsSummaryReportQueryFilter(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CategoryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).CategoryType = (string) content.GetValueForProperty("CategoryType",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).CategoryType, global::System.Convert.ToString);
            }
            if (content.Contains("TopItem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).TopItem = (int) content.GetValueForProperty("TopItem",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).TopItem, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DateRangeStart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeStart = (global::System.DateTime) content.GetValueForProperty("DateRangeStart",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeStart, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateRangeEnd"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeEnd = (global::System.DateTime) content.GetValueForProperty("DateRangeEnd",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeEnd, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRange = (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IDateRange) content.GetValueForProperty("DateRange",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRange, Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.DateRangeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReportType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ReportType = (string) content.GetValueForProperty("ReportType",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ReportType, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).SubscriptionList = (System.Collections.Generic.List<string>) content.GetValueForProperty("SubscriptionList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).SubscriptionList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ResourceGroupUrlList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceGroupUrlList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGroupUrlList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceGroupUrlList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ResourceTypeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceTypeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceTypeList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceTypeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocationList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).LocationList = (System.Collections.Generic.List<string>) content.GetValueForProperty("LocationList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).LocationList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CarbonScopeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).CarbonScopeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("CarbonScopeList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).CarbonScopeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.TopItemsSummaryReportQueryFilter"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal TopItemsSummaryReportQueryFilter(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("CategoryType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).CategoryType = (string) content.GetValueForProperty("CategoryType",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).CategoryType, global::System.Convert.ToString);
            }
            if (content.Contains("TopItem"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).TopItem = (int) content.GetValueForProperty("TopItem",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.ITopItemsSummaryReportQueryFilterInternal)this).TopItem, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("DateRangeStart"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeStart = (global::System.DateTime) content.GetValueForProperty("DateRangeStart",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeStart, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateRangeEnd"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeEnd = (global::System.DateTime) content.GetValueForProperty("DateRangeEnd",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRangeEnd, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("DateRange"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRange = (Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IDateRange) content.GetValueForProperty("DateRange",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).DateRange, Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.DateRangeTypeConverter.ConvertFrom);
            }
            if (content.Contains("ReportType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ReportType = (string) content.GetValueForProperty("ReportType",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ReportType, global::System.Convert.ToString);
            }
            if (content.Contains("SubscriptionList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).SubscriptionList = (System.Collections.Generic.List<string>) content.GetValueForProperty("SubscriptionList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).SubscriptionList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ResourceGroupUrlList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceGroupUrlList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceGroupUrlList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceGroupUrlList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("ResourceTypeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceTypeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("ResourceTypeList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).ResourceTypeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("LocationList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).LocationList = (System.Collections.Generic.List<string>) content.GetValueForProperty("LocationList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).LocationList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("CarbonScopeList"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).CarbonScopeList = (System.Collections.Generic.List<string>) content.GetValueForProperty("CarbonScopeList",((Microsoft.Azure.PowerShell.Cmdlets.Carbon.Models.IQueryFilterInternal)this).CarbonScopeList, __y => TypeConverterExtensions.SelectToList<string>(__y, global::System.Convert.ToString));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// Query filter parameter to configure TopItemsSummaryReport queries.
    [System.ComponentModel.TypeConverter(typeof(TopItemsSummaryReportQueryFilterTypeConverter))]
    public partial interface ITopItemsSummaryReportQueryFilter

    {

    }
}