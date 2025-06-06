// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Extensions;

    /// <summary>Customer creates a contact resource for a spacecraft resource.</summary>
    public partial class Contact :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContact,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IProxyResource" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IProxyResource __proxyResource = new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ProxyResource();

        /// <summary>
        /// The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string AntennaConfigurationDestinationIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).AntennaConfigurationDestinationIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).AntennaConfigurationDestinationIP = value ?? null; }

        /// <summary>List of Source IP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public System.Collections.Generic.List<string> AntennaConfigurationSourceIP { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).AntennaConfigurationSourceIP; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).AntennaConfigurationSourceIP = value ?? null /* arrayOf */; }

        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? EndAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).EndAzimuthDegree; }

        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? EndElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).EndElevationDegree; }

        /// <summary>Any error message while scheduling a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ErrorMessage; }

        /// <summary>Azure Ground Station name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 1)]
        public string GroundStationName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).GroundStationName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).GroundStationName = value ; }

        /// <summary>
        /// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Id; }

        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? MaximumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).MaximumElevationDegree; }

        /// <summary>Internal Acessors for AntennaConfiguration</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesAntennaConfiguration Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.AntennaConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).AntennaConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).AntennaConfiguration = value; }

        /// <summary>Internal Acessors for EndAzimuthDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.EndAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).EndAzimuthDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).EndAzimuthDegree = value; }

        /// <summary>Internal Acessors for EndElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.EndElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).EndElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).EndElevationDegree = value; }

        /// <summary>Internal Acessors for ErrorMessage</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.ErrorMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ErrorMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ErrorMessage = value; }

        /// <summary>Internal Acessors for MaximumElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.MaximumElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).MaximumElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).MaximumElevationDegree = value; }

        /// <summary>Internal Acessors for Profile</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesContactProfile Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.Profile { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ContactProfile; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ContactProfile = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsProperties Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Internal Acessors for RxEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.RxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).RxEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).RxEndTime = value; }

        /// <summary>Internal Acessors for RxStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.RxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).RxStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).RxStartTime = value; }

        /// <summary>Internal Acessors for StartAzimuthDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.StartAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).StartAzimuthDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).StartAzimuthDegree = value; }

        /// <summary>Internal Acessors for StartElevationDegree</summary>
        float? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.StartElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).StartElevationDegree; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).StartElevationDegree = value; }

        /// <summary>Internal Acessors for Status</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).Status = value; }

        /// <summary>Internal Acessors for TxEndTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.TxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).TxEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).TxEndTime = value; }

        /// <summary>Internal Acessors for TxStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactInternal.TxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).TxStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).TxStartTime = value; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Name = value; }

        /// <summary>Internal Acessors for SystemData</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISystemData Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal.SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemData; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemData = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Type = value; }

        /// <summary>The name of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 0)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Name; }

        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string ProfileId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ContactProfileId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ContactProfileId = value ; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsProperties _property;

        /// <summary>Properties of the Contact Resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ContactsProperties()); set => this._property = value; }

        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Reservation end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 4)]
        public global::System.DateTime ReservationEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ReservationEndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ReservationEndTime = value ; }

        /// <summary>Reservation start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 3)]
        public global::System.DateTime ReservationStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ReservationStartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).ReservationStartTime = value ; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 5)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>Receive end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? RxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).RxEndTime; }

        /// <summary>Receive start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? RxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).RxStartTime; }

        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? StartAzimuthDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).StartAzimuthDegree; }

        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public float? StartElevationDegree { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).StartElevationDegree; }

        /// <summary>Status of a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.FormatTable(Index = 2)]
        public string Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).Status; }

        /// <summary>
        /// Azure Resource Manager metadata containing createdBy and modifiedBy information.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        internal Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.ISystemData SystemData { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemData; }

        /// <summary>The timestamp of resource creation (UTC).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? SystemDataCreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataCreatedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataCreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataCreatedBy = value ?? null; }

        /// <summary>The type of identity that created the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataCreatedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataCreatedByType = value ?? null; }

        /// <summary>The timestamp of resource last modification (UTC)</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? SystemDataLastModifiedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedAt = value ?? default(global::System.DateTime); }

        /// <summary>The identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataLastModifiedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedBy = value ?? null; }

        /// <summary>The type of identity that last modified the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string SystemDataLastModifiedByType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).SystemDataLastModifiedByType = value ?? null; }

        /// <summary>Transmit end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? TxEndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).TxEndTime; }

        /// <summary>Transmit start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public global::System.DateTime? TxStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesInternal)Property).TxStartTime; }

        /// <summary>
        /// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Origin(Microsoft.Azure.PowerShell.Cmdlets.Orbital.PropertyOrigin.Inherited)]
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.DoNotFormat]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IResourceInternal)__proxyResource).Type; }

        /// <summary>Creates an new <see cref="Contact" /> instance.</summary>
        public Contact()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyResource), __proxyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyResource), __proxyResource);
        }
    }
    /// Customer creates a contact resource for a spacecraft resource.
    public partial interface IContact :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IProxyResource
    {
        /// <summary>
        /// The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.",
        SerializedName = @"destinationIp",
        PossibleTypes = new [] { typeof(string) })]
        string AntennaConfigurationDestinationIP { get;  }
        /// <summary>List of Source IP</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of Source IP",
        SerializedName = @"sourceIps",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AntennaConfigurationSourceIP { get;  }
        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azimuth of the antenna at the end of the contact in decimal degrees.",
        SerializedName = @"endAzimuthDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? EndAzimuthDegree { get;  }
        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Spacecraft elevation above the horizon at contact end.",
        SerializedName = @"endElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? EndElevationDegree { get;  }
        /// <summary>Any error message while scheduling a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Any error message while scheduling a contact.",
        SerializedName = @"errorMessage",
        PossibleTypes = new [] { typeof(string) })]
        string ErrorMessage { get;  }
        /// <summary>Azure Ground Station name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Azure Ground Station name.",
        SerializedName = @"groundStationName",
        PossibleTypes = new [] { typeof(string) })]
        string GroundStationName { get; set; }
        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Maximum elevation of the antenna during the contact in decimal degrees.",
        SerializedName = @"maximumElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? MaximumElevationDegree { get;  }
        /// <summary>Resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string ProfileId { get; set; }
        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The current state of the resource's creation, deletion, or modification.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>Reservation end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Reservation end time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"reservationEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime ReservationEndTime { get; set; }
        /// <summary>Reservation start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Reservation start time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"reservationStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime ReservationStartTime { get; set; }
        /// <summary>Receive end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Receive end time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"rxEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RxEndTime { get;  }
        /// <summary>Receive start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Receive start time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"rxStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? RxStartTime { get;  }
        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Azimuth of the antenna at the start of the contact in decimal degrees.",
        SerializedName = @"startAzimuthDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? StartAzimuthDegree { get;  }
        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Spacecraft elevation above the horizon at contact start.",
        SerializedName = @"startElevationDegrees",
        PossibleTypes = new [] { typeof(float) })]
        float? StartElevationDegree { get;  }
        /// <summary>Status of a contact.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Status of a contact.",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.Orbital.PSArgumentCompleterAttribute("scheduled", "cancelled", "succeeded", "failed", "providerCancelled")]
        string Status { get;  }
        /// <summary>Transmit end time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Transmit end time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"txEndTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TxEndTime { get;  }
        /// <summary>Transmit start time of a contact (ISO 8601 UTC standard).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Orbital.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Transmit start time of a contact (ISO 8601 UTC standard).",
        SerializedName = @"txStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TxStartTime { get;  }

    }
    /// Customer creates a contact resource for a spacecraft resource.
    internal partial interface IContactInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IProxyResourceInternal
    {
        /// <summary>The configuration associated with the allocated antenna.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesAntennaConfiguration AntennaConfiguration { get; set; }
        /// <summary>
        /// The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to.
        /// </summary>
        string AntennaConfigurationDestinationIP { get; set; }
        /// <summary>List of Source IP</summary>
        System.Collections.Generic.List<string> AntennaConfigurationSourceIP { get; set; }
        /// <summary>Azimuth of the antenna at the end of the contact in decimal degrees.</summary>
        float? EndAzimuthDegree { get; set; }
        /// <summary>Spacecraft elevation above the horizon at contact end.</summary>
        float? EndElevationDegree { get; set; }
        /// <summary>Any error message while scheduling a contact.</summary>
        string ErrorMessage { get; set; }
        /// <summary>Azure Ground Station name.</summary>
        string GroundStationName { get; set; }
        /// <summary>Maximum elevation of the antenna during the contact in decimal degrees.</summary>
        float? MaximumElevationDegree { get; set; }
        /// <summary>The reference to the contact profile resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsPropertiesContactProfile Profile { get; set; }
        /// <summary>Resource ID.</summary>
        string ProfileId { get; set; }
        /// <summary>Properties of the Contact Resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Orbital.Models.IContactsProperties Property { get; set; }
        /// <summary>The current state of the resource's creation, deletion, or modification.</summary>
        string ProvisioningState { get; set; }
        /// <summary>Reservation end time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime ReservationEndTime { get; set; }
        /// <summary>Reservation start time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime ReservationStartTime { get; set; }
        /// <summary>Receive end time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? RxEndTime { get; set; }
        /// <summary>Receive start time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? RxStartTime { get; set; }
        /// <summary>Azimuth of the antenna at the start of the contact in decimal degrees.</summary>
        float? StartAzimuthDegree { get; set; }
        /// <summary>Spacecraft elevation above the horizon at contact start.</summary>
        float? StartElevationDegree { get; set; }
        /// <summary>Status of a contact.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.Orbital.PSArgumentCompleterAttribute("scheduled", "cancelled", "succeeded", "failed", "providerCancelled")]
        string Status { get; set; }
        /// <summary>Transmit end time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? TxEndTime { get; set; }
        /// <summary>Transmit start time of a contact (ISO 8601 UTC standard).</summary>
        global::System.DateTime? TxStartTime { get; set; }

    }
}