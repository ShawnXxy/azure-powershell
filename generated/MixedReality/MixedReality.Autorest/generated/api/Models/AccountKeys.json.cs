// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Extensions;

    /// <summary>Developer Keys of account</summary>
    public partial class AccountKeys
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject into a new instance of <see cref="AccountKeys" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal AccountKeys(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_primaryKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonString>("primaryKey"), out var __jsonPrimaryKey) ? (string)__jsonPrimaryKey : (string)_primaryKey;}
            {_secondaryKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonString>("secondaryKey"), out var __jsonSecondaryKey) ? (string)__jsonSecondaryKey : (string)_secondaryKey;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IAccountKeys.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IAccountKeys.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Models.IAccountKeys FromJson(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject json ? new AccountKeys(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="AccountKeys" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="AccountKeys" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._primaryKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonString(this._primaryKey.ToString()) : null, "primaryKey" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._secondaryKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.MixedReality.Runtime.Json.JsonString(this._secondaryKey.ToString()) : null, "secondaryKey" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}