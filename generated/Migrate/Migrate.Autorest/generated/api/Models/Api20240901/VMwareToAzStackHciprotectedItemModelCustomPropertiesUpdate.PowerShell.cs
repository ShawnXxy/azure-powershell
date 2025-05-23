// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>VMware to AzStackHCI Protected item model custom properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateTypeConverter))]
    public partial class VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate" />, deserializing the
        /// content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NicsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHcinicInput[]) content.GetValueForProperty("NicsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHcinicInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.VMwareToAzStackHcinicInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("TargetCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore = (int?) content.GetValueForProperty("TargetCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsDynamicRam"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam = (bool?) content.GetValueForProperty("IsDynamicRam",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DynamicMemoryConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IProtectedItemDynamicMemoryConfig) content.GetValueForProperty("DynamicMemoryConfig",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.ProtectedItemDynamicMemoryConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte = (int?) content.GetValueForProperty("TargetMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("NicsToInclude"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHcinicInput[]) content.GetValueForProperty("NicsToInclude",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).NicsToInclude, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHcinicInput>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.VMwareToAzStackHcinicInputTypeConverter.ConvertFrom));
            }
            if (content.Contains("TargetCpuCore"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore = (int?) content.GetValueForProperty("TargetCpuCore",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetCpuCore, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsDynamicRam"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam = (bool?) content.GetValueForProperty("IsDynamicRam",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).IsDynamicRam, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DynamicMemoryConfig"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IProtectedItemDynamicMemoryConfig) content.GetValueForProperty("DynamicMemoryConfig",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).DynamicMemoryConfig, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.ProtectedItemDynamicMemoryConfigTypeConverter.ConvertFrom);
            }
            if (content.Contains("TargetMemoryInMegaByte"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte = (int?) content.GetValueForProperty("TargetMemoryInMegaByte",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).TargetMemoryInMegaByte, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("OSType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType = (string) content.GetValueForProperty("OSType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateInternal)this).OSType, global::System.Convert.ToString);
            }
            if (content.Contains("InstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType = (string) content.GetValueForProperty("InstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20240901.IProtectedItemModelCustomPropertiesUpdateInternal)this).InstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }
    }
    /// VMware to AzStackHCI Protected item model custom properties.
    [System.ComponentModel.TypeConverter(typeof(VMwareToAzStackHciprotectedItemModelCustomPropertiesUpdateTypeConverter))]
    public partial interface IVMwareToAzStackHciprotectedItemModelCustomPropertiesUpdate

    {

    }
}