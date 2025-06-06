// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Extensions;

    /// <summary>Provides information about an Azure data center location.</summary>
    public partial class Location :
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocation,
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationInternal
    {

        /// <summary>
        /// Additional shipping information for customer, specific to datacenter to which customer should send their disks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string AdditionalShippingInformation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).AdditionalShippingInformation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).AdditionalShippingInformation = value ?? null; }

        /// <summary>
        /// A list of location IDs that should be used to ship shipping drives to for jobs created against the current location. If
        /// the current location is active, it will be part of the list. If it is temporarily closed due to maintenance, this list
        /// may contain other locations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> AlternateLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).AlternateLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).AlternateLocation = value ?? null /* arrayOf */; }

        /// <summary>The city name to use when shipping the drives to the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string City { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).City; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).City = value ?? null; }

        /// <summary>
        /// The country or region to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string CountryOrRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).CountryOrRegion; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).CountryOrRegion = value ?? null; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Specifies the resource identifier of the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationProperties Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.LocationProperties()); set { {_property = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>
        /// Specifies the name of the location. Use List Locations to get all supported locations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>The phone number for the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string Phone { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).Phone; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).Phone = value ?? null; }

        /// <summary>The postal code to use when shipping the drives to the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string PostalCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).PostalCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).PostalCode = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationProperties _property;

        /// <summary>location properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.LocationProperties()); set => this._property = value; }

        /// <summary>The recipient name to use when shipping the drives to the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string RecipientName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).RecipientName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).RecipientName = value ?? null; }

        /// <summary>Gets the resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => (new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Success ? new global::System.Text.RegularExpressions.Regex("^/subscriptions/(?<subscriptionId>[^/]+)/resourceGroups/(?<resourceGroupName>[^/]+)/providers/", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase).Match(this.Id).Groups["resourceGroupName"].Value : null); }

        /// <summary>
        /// The state or province to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string StateOrProvince { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).StateOrProvince; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).StateOrProvince = value ?? null; }

        /// <summary>
        /// The first line of the street address to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string StreetAddress1 { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).StreetAddress1; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).StreetAddress1 = value ?? null; }

        /// <summary>
        /// The second line of the street address to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public string StreetAddress2 { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).StreetAddress2; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).StreetAddress2 = value ?? null; }

        /// <summary>A list of carriers that are supported at this location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<string> SupportedCarrier { get => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).SupportedCarrier; set => ((Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationPropertiesInternal)Property).SupportedCarrier = value ?? null /* arrayOf */; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Specifies the type of the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Origin(Microsoft.Azure.PowerShell.Cmdlets.ImportExport.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="Location" /> instance.</summary>
        public Location()
        {

        }
    }
    /// Provides information about an Azure data center location.
    public partial interface ILocation :
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.IJsonSerializable
    {
        /// <summary>
        /// Additional shipping information for customer, specific to datacenter to which customer should send their disks.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Additional shipping information for customer, specific to datacenter to which customer should send their disks.",
        SerializedName = @"additionalShippingInformation",
        PossibleTypes = new [] { typeof(string) })]
        string AdditionalShippingInformation { get; set; }
        /// <summary>
        /// A list of location IDs that should be used to ship shipping drives to for jobs created against the current location. If
        /// the current location is active, it will be part of the list. If it is temporarily closed due to maintenance, this list
        /// may contain other locations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of location IDs that should be used to ship shipping drives to for jobs created against the current location. If the current location is active, it will be part of the list. If it is temporarily closed due to maintenance, this list may contain other locations. ",
        SerializedName = @"alternateLocations",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> AlternateLocation { get; set; }
        /// <summary>The city name to use when shipping the drives to the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The city name to use when shipping the drives to the Azure data center. ",
        SerializedName = @"city",
        PossibleTypes = new [] { typeof(string) })]
        string City { get; set; }
        /// <summary>
        /// The country or region to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The country or region to use when shipping the drives to the Azure data center. ",
        SerializedName = @"countryOrRegion",
        PossibleTypes = new [] { typeof(string) })]
        string CountryOrRegion { get; set; }
        /// <summary>Specifies the resource identifier of the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the resource identifier of the location. ",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>
        /// Specifies the name of the location. Use List Locations to get all supported locations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the name of the location. Use List Locations to get all supported locations. ",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>The phone number for the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The phone number for the Azure data center. ",
        SerializedName = @"phone",
        PossibleTypes = new [] { typeof(string) })]
        string Phone { get; set; }
        /// <summary>The postal code to use when shipping the drives to the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The postal code to use when shipping the drives to the Azure data center. ",
        SerializedName = @"postalCode",
        PossibleTypes = new [] { typeof(string) })]
        string PostalCode { get; set; }
        /// <summary>The recipient name to use when shipping the drives to the Azure data center.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The recipient name to use when shipping the drives to the Azure data center. ",
        SerializedName = @"recipientName",
        PossibleTypes = new [] { typeof(string) })]
        string RecipientName { get; set; }
        /// <summary>
        /// The state or province to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The state or province to use when shipping the drives to the Azure data center. ",
        SerializedName = @"stateOrProvince",
        PossibleTypes = new [] { typeof(string) })]
        string StateOrProvince { get; set; }
        /// <summary>
        /// The first line of the street address to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The first line of the street address to use when shipping the drives to the Azure data center. ",
        SerializedName = @"streetAddress1",
        PossibleTypes = new [] { typeof(string) })]
        string StreetAddress1 { get; set; }
        /// <summary>
        /// The second line of the street address to use when shipping the drives to the Azure data center.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The second line of the street address to use when shipping the drives to the Azure data center. ",
        SerializedName = @"streetAddress2",
        PossibleTypes = new [] { typeof(string) })]
        string StreetAddress2 { get; set; }
        /// <summary>A list of carriers that are supported at this location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A list of carriers that are supported at this location. ",
        SerializedName = @"supportedCarriers",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SupportedCarrier { get; set; }
        /// <summary>Specifies the type of the location.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Specifies the type of the location. ",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }

    }
    /// Provides information about an Azure data center location.
    internal partial interface ILocationInternal

    {
        /// <summary>
        /// Additional shipping information for customer, specific to datacenter to which customer should send their disks.
        /// </summary>
        string AdditionalShippingInformation { get; set; }
        /// <summary>
        /// A list of location IDs that should be used to ship shipping drives to for jobs created against the current location. If
        /// the current location is active, it will be part of the list. If it is temporarily closed due to maintenance, this list
        /// may contain other locations.
        /// </summary>
        System.Collections.Generic.List<string> AlternateLocation { get; set; }
        /// <summary>The city name to use when shipping the drives to the Azure data center.</summary>
        string City { get; set; }
        /// <summary>
        /// The country or region to use when shipping the drives to the Azure data center.
        /// </summary>
        string CountryOrRegion { get; set; }
        /// <summary>Specifies the resource identifier of the location.</summary>
        string Id { get; set; }
        /// <summary>
        /// Specifies the name of the location. Use List Locations to get all supported locations.
        /// </summary>
        string Name { get; set; }
        /// <summary>The phone number for the Azure data center.</summary>
        string Phone { get; set; }
        /// <summary>The postal code to use when shipping the drives to the Azure data center.</summary>
        string PostalCode { get; set; }
        /// <summary>location properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.ImportExport.Models.ILocationProperties Property { get; set; }
        /// <summary>The recipient name to use when shipping the drives to the Azure data center.</summary>
        string RecipientName { get; set; }
        /// <summary>
        /// The state or province to use when shipping the drives to the Azure data center.
        /// </summary>
        string StateOrProvince { get; set; }
        /// <summary>
        /// The first line of the street address to use when shipping the drives to the Azure data center.
        /// </summary>
        string StreetAddress1 { get; set; }
        /// <summary>
        /// The second line of the street address to use when shipping the drives to the Azure data center.
        /// </summary>
        string StreetAddress2 { get; set; }
        /// <summary>A list of carriers that are supported at this location.</summary>
        System.Collections.Generic.List<string> SupportedCarrier { get; set; }
        /// <summary>Specifies the type of the location.</summary>
        string Type { get; set; }

    }
}