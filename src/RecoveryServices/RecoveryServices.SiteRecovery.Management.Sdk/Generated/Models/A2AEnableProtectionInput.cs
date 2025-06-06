// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// A2A enable protection input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2AEnableProtectionInput : EnableProtectionProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the A2AEnableProtectionInput class.
        /// </summary>
        public A2AEnableProtectionInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2AEnableProtectionInput class.
        /// </summary>

        /// <param name="fabricObjectId">The fabric specific object Id of the virtual machine.
        /// </param>

        /// <param name="recoveryContainerId">The recovery container Id.
        /// </param>

        /// <param name="recoveryResourceGroupId">The recovery resource group Id. Valid for V2 scenarios.
        /// </param>

        /// <param name="recoveryCloudServiceId">The recovery cloud service Id. Valid for V1 scenarios.
        /// </param>

        /// <param name="recoveryAvailabilitySetId">The recovery availability set Id.
        /// </param>

        /// <param name="recoveryProximityPlacementGroupId">The recovery proximity placement group Id.
        /// </param>

        /// <param name="vmDisks">The list of vm disk details.
        /// </param>

        /// <param name="vmManagedDisks">The list of vm managed disk details.
        /// </param>

        /// <param name="multiVMGroupName">The multi vm group name.
        /// </param>

        /// <param name="multiVMGroupId">The multi vm group id.
        /// </param>

        /// <param name="protectionClusterId">The replication protection cluster Id.
        /// </param>

        /// <param name="recoveryBootDiagStorageAccountId">The boot diagnostic storage account.
        /// </param>

        /// <param name="diskEncryptionInfo">The recovery disk encryption information (for two pass flows).
        /// </param>

        /// <param name="recoveryAvailabilityZone">The recovery availability zone.
        /// </param>

        /// <param name="recoveryExtendedLocation">The recovery extended location.
        /// </param>

        /// <param name="recoveryAzureNetworkId">The recovery Azure virtual network ARM id.
        /// </param>

        /// <param name="recoverySubnetName">The recovery subnet name.
        /// </param>

        /// <param name="recoveryVirtualMachineScaleSetId">The virtual machine scale set Id.
        /// </param>

        /// <param name="recoveryCapacityReservationGroupId">The recovery capacity reservation group Id.
        /// </param>

        /// <param name="autoProtectionOfDataDisk">A value indicating whether the auto protection is enabled.
        /// Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;</param>
        public A2AEnableProtectionInput(string fabricObjectId, string recoveryContainerId = default(string), string recoveryResourceGroupId = default(string), string recoveryCloudServiceId = default(string), string recoveryAvailabilitySetId = default(string), string recoveryProximityPlacementGroupId = default(string), System.Collections.Generic.IList<A2AVmDiskInputDetails> vmDisks = default(System.Collections.Generic.IList<A2AVmDiskInputDetails>), System.Collections.Generic.IList<A2AVmManagedDiskInputDetails> vmManagedDisks = default(System.Collections.Generic.IList<A2AVmManagedDiskInputDetails>), string multiVMGroupName = default(string), string multiVMGroupId = default(string), string protectionClusterId = default(string), string recoveryBootDiagStorageAccountId = default(string), DiskEncryptionInfo diskEncryptionInfo = default(DiskEncryptionInfo), string recoveryAvailabilityZone = default(string), ExtendedLocation recoveryExtendedLocation = default(ExtendedLocation), string recoveryAzureNetworkId = default(string), string recoverySubnetName = default(string), string recoveryVirtualMachineScaleSetId = default(string), string recoveryCapacityReservationGroupId = default(string), string autoProtectionOfDataDisk = default(string))

        {
            this.FabricObjectId = fabricObjectId;
            this.RecoveryContainerId = recoveryContainerId;
            this.RecoveryResourceGroupId = recoveryResourceGroupId;
            this.RecoveryCloudServiceId = recoveryCloudServiceId;
            this.RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            this.RecoveryProximityPlacementGroupId = recoveryProximityPlacementGroupId;
            this.VMDisks = vmDisks;
            this.VMManagedDisks = vmManagedDisks;
            this.MultiVMGroupName = multiVMGroupName;
            this.MultiVMGroupId = multiVMGroupId;
            this.ProtectionClusterId = protectionClusterId;
            this.RecoveryBootDiagStorageAccountId = recoveryBootDiagStorageAccountId;
            this.DiskEncryptionInfo = diskEncryptionInfo;
            this.RecoveryAvailabilityZone = recoveryAvailabilityZone;
            this.RecoveryExtendedLocation = recoveryExtendedLocation;
            this.RecoveryAzureNetworkId = recoveryAzureNetworkId;
            this.RecoverySubnetName = recoverySubnetName;
            this.RecoveryVirtualMachineScaleSetId = recoveryVirtualMachineScaleSetId;
            this.RecoveryCapacityReservationGroupId = recoveryCapacityReservationGroupId;
            this.AutoProtectionOfDataDisk = autoProtectionOfDataDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the fabric specific object Id of the virtual machine.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fabricObjectId")]
        public string FabricObjectId {get; set; }

        /// <summary>
        /// Gets or sets the recovery container Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryContainerId")]
        public string RecoveryContainerId {get; set; }

        /// <summary>
        /// Gets or sets the recovery resource group Id. Valid for V2 scenarios.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryResourceGroupId")]
        public string RecoveryResourceGroupId {get; set; }

        /// <summary>
        /// Gets or sets the recovery cloud service Id. Valid for V1 scenarios.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryCloudServiceId")]
        public string RecoveryCloudServiceId {get; set; }

        /// <summary>
        /// Gets or sets the recovery availability set Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAvailabilitySetId")]
        public string RecoveryAvailabilitySetId {get; set; }

        /// <summary>
        /// Gets or sets the recovery proximity placement group Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryProximityPlacementGroupId")]
        public string RecoveryProximityPlacementGroupId {get; set; }

        /// <summary>
        /// Gets or sets the list of vm disk details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmDisks")]
        public System.Collections.Generic.IList<A2AVmDiskInputDetails> VMDisks {get; set; }

        /// <summary>
        /// Gets or sets the list of vm managed disk details.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "vmManagedDisks")]
        public System.Collections.Generic.IList<A2AVmManagedDiskInputDetails> VMManagedDisks {get; set; }

        /// <summary>
        /// Gets or sets the multi vm group name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVMGroupName {get; set; }

        /// <summary>
        /// Gets or sets the multi vm group id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiVmGroupId")]
        public string MultiVMGroupId {get; set; }

        /// <summary>
        /// Gets or sets the replication protection cluster Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "protectionClusterId")]
        public string ProtectionClusterId {get; set; }

        /// <summary>
        /// Gets or sets the boot diagnostic storage account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryBootDiagStorageAccountId")]
        public string RecoveryBootDiagStorageAccountId {get; set; }

        /// <summary>
        /// Gets or sets the recovery disk encryption information (for two pass flows).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "diskEncryptionInfo")]
        public DiskEncryptionInfo DiskEncryptionInfo {get; set; }

        /// <summary>
        /// Gets or sets the recovery availability zone.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAvailabilityZone")]
        public string RecoveryAvailabilityZone {get; set; }

        /// <summary>
        /// Gets or sets the recovery extended location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryExtendedLocation")]
        public ExtendedLocation RecoveryExtendedLocation {get; set; }

        /// <summary>
        /// Gets or sets the recovery Azure virtual network ARM id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryAzureNetworkId")]
        public string RecoveryAzureNetworkId {get; set; }

        /// <summary>
        /// Gets or sets the recovery subnet name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoverySubnetName")]
        public string RecoverySubnetName {get; set; }

        /// <summary>
        /// Gets or sets the virtual machine scale set Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryVirtualMachineScaleSetId")]
        public string RecoveryVirtualMachineScaleSetId {get; set; }

        /// <summary>
        /// Gets or sets the recovery capacity reservation group Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryCapacityReservationGroupId")]
        public string RecoveryCapacityReservationGroupId {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the auto protection is enabled. Possible values include: &#39;Disabled&#39;, &#39;Enabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "autoProtectionOfDataDisk")]
        public string AutoProtectionOfDataDisk {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.FabricObjectId == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "FabricObjectId");
            }






            if (this.VMDisks != null)
            {
                foreach (var element in this.VMDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.VMManagedDisks != null)
            {
                foreach (var element in this.VMManagedDisks)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }






            if (this.RecoveryExtendedLocation != null)
            {
                this.RecoveryExtendedLocation.Validate();
            }





        }
    }
}