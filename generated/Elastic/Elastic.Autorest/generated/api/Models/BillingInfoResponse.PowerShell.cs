// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.PowerShell;

    /// <summary>
    /// Marketplace Subscription and Organization details to which resource gets billed into.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(BillingInfoResponseTypeConverter))]
    public partial class BillingInfoResponse
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.BillingInfoResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal BillingInfoResponse(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceSaasInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaasInfo = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfo) content.GetValueForProperty("MarketplaceSaasInfo",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaasInfo, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerBillingEntity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntity = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IPartnerBillingEntity) content.GetValueForProperty("PartnerBillingEntity",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntity, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.PartnerBillingEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerBillingEntityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityId = (string) content.GetValueForProperty("PartnerBillingEntityId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerBillingEntityName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityName = (string) content.GetValueForProperty("PartnerBillingEntityName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceSubscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceSubscription = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfoMarketplaceSubscription) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceSubscription",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceSubscription, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoMarketplaceSubscriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceName = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceResourceId = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceStatus = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceStatus",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoBilledAzureSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId = (string) content.GetValueForProperty("MarketplaceSaaInfoBilledAzureSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoSubscribed = (bool?) content.GetValueForProperty("MarketplaceSaaInfoSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoSubscribed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PartnerBillingEntityPartnerEntityUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityPartnerEntityUri = (string) content.GetValueForProperty("PartnerBillingEntityPartnerEntityUri",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityPartnerEntityUri, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.BillingInfoResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal BillingInfoResponse(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MarketplaceSaasInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaasInfo = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfo) content.GetValueForProperty("MarketplaceSaasInfo",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaasInfo, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerBillingEntity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntity = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IPartnerBillingEntity) content.GetValueForProperty("PartnerBillingEntity",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntity, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.PartnerBillingEntityTypeConverter.ConvertFrom);
            }
            if (content.Contains("PartnerBillingEntityId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityId = (string) content.GetValueForProperty("PartnerBillingEntityId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityId, global::System.Convert.ToString);
            }
            if (content.Contains("PartnerBillingEntityName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityName = (string) content.GetValueForProperty("PartnerBillingEntityName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceSubscription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceSubscription = (Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IMarketplaceSaaSInfoMarketplaceSubscription) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceSubscription",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceSubscription, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.MarketplaceSaaSInfoMarketplaceSubscriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceName = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceName",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceName, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceResourceId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceResourceId = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceResourceId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceResourceId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoMarketplaceStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceStatus = (string) content.GetValueForProperty("MarketplaceSaaInfoMarketplaceStatus",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoMarketplaceStatus, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoBilledAzureSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId = (string) content.GetValueForProperty("MarketplaceSaaInfoBilledAzureSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoBilledAzureSubscriptionId, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSaaInfoSubscribed"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoSubscribed = (bool?) content.GetValueForProperty("MarketplaceSaaInfoSubscribed",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSaaInfoSubscribed, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("PartnerBillingEntityPartnerEntityUri"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityPartnerEntityUri = (string) content.GetValueForProperty("PartnerBillingEntityPartnerEntityUri",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).PartnerBillingEntityPartnerEntityUri, global::System.Convert.ToString);
            }
            if (content.Contains("MarketplaceSubscriptionId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSubscriptionId = (string) content.GetValueForProperty("MarketplaceSubscriptionId",((Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponseInternal)this).MarketplaceSubscriptionId, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.BillingInfoResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponse DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new BillingInfoResponse(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.BillingInfoResponse"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponse" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponse DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new BillingInfoResponse(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="BillingInfoResponse" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="BillingInfoResponse" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.IBillingInfoResponse FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    /// Marketplace Subscription and Organization details to which resource gets billed into.
    [System.ComponentModel.TypeConverter(typeof(BillingInfoResponseTypeConverter))]
    public partial interface IBillingInfoResponse

    {

    }
}