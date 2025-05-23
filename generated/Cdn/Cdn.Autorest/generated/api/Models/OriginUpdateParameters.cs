// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Extensions;

    /// <summary>Origin properties needed for origin update.</summary>
    public partial class OriginUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdateParametersInternal
    {

        /// <summary>Origin is enabled for load balancing or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public bool? Enabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).Enabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).Enabled = value ?? default(bool); }

        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).HostName = value ?? null; }

        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? HttpPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).HttpPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).HttpPort = value ?? default(int); }

        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? HttpsPort { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).HttpsPort; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).HttpsPort = value ?? default(int); }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParameters Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.OriginUpdatePropertiesParameters()); set { {_property = value;} } }

        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string OriginHostHeader { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).OriginHostHeader; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).OriginHostHeader = value ?? null; }

        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? Priority { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).Priority; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).Priority = value ?? default(int); }

        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkAlias { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkAlias; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkAlias = value ?? null; }

        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkApprovalMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkApprovalMessage; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkApprovalMessage = value ?? null; }

        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkLocation { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkLocation; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkLocation = value ?? null; }

        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public string PrivateLinkResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).PrivateLinkResourceId = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParameters _property;

        /// <summary>The JSON object that contains the properties of the origin.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParameters Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.OriginUpdatePropertiesParameters()); set => this._property = value; }

        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Origin(Microsoft.Azure.PowerShell.Cmdlets.Cdn.PropertyOrigin.Inlined)]
        public int? Weight { get => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).Weight; set => ((Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParametersInternal)Property).Weight = value ?? default(int); }

        /// <summary>Creates an new <see cref="OriginUpdateParameters" /> instance.</summary>
        public OriginUpdateParameters()
        {

        }
    }
    /// Origin properties needed for origin update.
    public partial interface IOriginUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.IJsonSerializable
    {
        /// <summary>Origin is enabled for load balancing or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Origin is enabled for load balancing or not",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across all origins in an endpoint.",
        SerializedName = @"hostName",
        PossibleTypes = new [] { typeof(string) })]
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of the HTTP port. Must be between 1 and 65535.",
        SerializedName = @"httpPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The value of the HTTPS port. Must be between 1 and 65535.",
        SerializedName = @"httpsPort",
        PossibleTypes = new [] { typeof(int) })]
        int? HttpsPort { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. This overrides the host header defined at Endpoint",
        SerializedName = @"originHostHeader",
        PossibleTypes = new [] { typeof(string) })]
        string OriginHostHeader { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if any lower priority origin is healthy.Must be between 1 and 5",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'",
        SerializedName = @"privateLinkAlias",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkAlias { get; set; }
        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"A custom message to be included in the approval request to connect to the Private Link.",
        SerializedName = @"privateLinkApprovalMessage",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkApprovalMessage { get; set; }
        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated",
        SerializedName = @"privateLinkLocation",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'",
        SerializedName = @"privateLinkResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkResourceId { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Cdn.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Weight of the origin in given origin group for load balancing. Must be between 1 and 1000",
        SerializedName = @"weight",
        PossibleTypes = new [] { typeof(int) })]
        int? Weight { get; set; }

    }
    /// Origin properties needed for origin update.
    internal partial interface IOriginUpdateParametersInternal

    {
        /// <summary>Origin is enabled for load balancing or not</summary>
        bool? Enabled { get; set; }
        /// <summary>
        /// The address of the origin. Domain names, IPv4 addresses, and IPv6 addresses are supported.This should be unique across
        /// all origins in an endpoint.
        /// </summary>
        string HostName { get; set; }
        /// <summary>The value of the HTTP port. Must be between 1 and 65535.</summary>
        int? HttpPort { get; set; }
        /// <summary>The value of the HTTPS port. Must be between 1 and 65535.</summary>
        int? HttpsPort { get; set; }
        /// <summary>
        /// The host header value sent to the origin with each request. If you leave this blank, the request hostname determines this
        /// value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the
        /// origin hostname by default. This overrides the host header defined at Endpoint
        /// </summary>
        string OriginHostHeader { get; set; }
        /// <summary>
        /// Priority of origin in given origin group for load balancing. Higher priorities will not be used for load balancing if
        /// any lower priority origin is healthy.Must be between 1 and 5
        /// </summary>
        int? Priority { get; set; }
        /// <summary>
        /// The Alias of the Private Link resource. Populating this optional field indicates that this origin is 'Private'
        /// </summary>
        string PrivateLinkAlias { get; set; }
        /// <summary>
        /// A custom message to be included in the approval request to connect to the Private Link.
        /// </summary>
        string PrivateLinkApprovalMessage { get; set; }
        /// <summary>
        /// The location of the Private Link resource. Required only if 'privateLinkResourceId' is populated
        /// </summary>
        string PrivateLinkLocation { get; set; }
        /// <summary>
        /// The Resource Id of the Private Link resource. Populating this optional field indicates that this backend is 'Private'
        /// </summary>
        string PrivateLinkResourceId { get; set; }
        /// <summary>The JSON object that contains the properties of the origin.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IOriginUpdatePropertiesParameters Property { get; set; }
        /// <summary>
        /// Weight of the origin in given origin group for load balancing. Must be between 1 and 1000
        /// </summary>
        int? Weight { get; set; }

    }
}