// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>A site for the channel</summary>
    public partial class Site :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISite,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal
    {

        /// <summary>Backing field for <see cref="AppId" /> property.</summary>
        private string _appId;

        /// <summary>DirectLine application id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string AppId { get => this._appId; set => this._appId = value; }

        /// <summary>Backing field for <see cref="ETag" /> property.</summary>
        private string _eTag;

        /// <summary>Entity Tag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string ETag { get => this._eTag; set => this._eTag = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Site Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Backing field for <see cref="IsBlockUserUploadEnabled" /> property.</summary>
        private bool? _isBlockUserUploadEnabled;

        /// <summary>Whether this site is enabled for block user upload.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsBlockUserUploadEnabled { get => this._isBlockUserUploadEnabled; set => this._isBlockUserUploadEnabled = value; }

        /// <summary>Backing field for <see cref="IsDetailedLoggingEnabled" /> property.</summary>
        private bool? _isDetailedLoggingEnabled;

        /// <summary>Whether this site is disabled detailed logging for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsDetailedLoggingEnabled { get => this._isDetailedLoggingEnabled; set => this._isDetailedLoggingEnabled = value; }

        /// <summary>Backing field for <see cref="IsEnabled" /> property.</summary>
        private bool _isEnabled;

        /// <summary>Whether this site is enabled for DirectLine channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool IsEnabled { get => this._isEnabled; set => this._isEnabled = value; }

        /// <summary>Backing field for <see cref="IsEndpointParametersEnabled" /> property.</summary>
        private bool? _isEndpointParametersEnabled;

        /// <summary>Whether this site is EndpointParameters enabled for channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsEndpointParametersEnabled { get => this._isEndpointParametersEnabled; set => this._isEndpointParametersEnabled = value; }

        /// <summary>Backing field for <see cref="IsNoStorageEnabled" /> property.</summary>
        private bool? _isNoStorageEnabled;

        /// <summary>Whether this no-storage site is disabled detailed logging for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsNoStorageEnabled { get => this._isNoStorageEnabled; set => this._isNoStorageEnabled = value; }

        /// <summary>Backing field for <see cref="IsSecureSiteEnabled" /> property.</summary>
        private bool? _isSecureSiteEnabled;

        /// <summary>Whether this site is enabled for authentication with Bot Framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsSecureSiteEnabled { get => this._isSecureSiteEnabled; set => this._isSecureSiteEnabled = value; }

        /// <summary>Backing field for <see cref="IsTokenEnabled" /> property.</summary>
        private bool? _isTokenEnabled;

        /// <summary>Whether this site is token enabled for channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsTokenEnabled { get => this._isTokenEnabled; }

        /// <summary>Backing field for <see cref="IsV1Enabled" /> property.</summary>
        private bool? _isV1Enabled;

        /// <summary>Whether this site is enabled for Bot Framework V1 protocol.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsV1Enabled { get => this._isV1Enabled; set => this._isV1Enabled = value; }

        /// <summary>Backing field for <see cref="IsV3Enabled" /> property.</summary>
        private bool? _isV3Enabled;

        /// <summary>Whether this site is enabled for Bot Framework V1 protocol.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsV3Enabled { get => this._isV3Enabled; set => this._isV3Enabled = value; }

        /// <summary>Backing field for <see cref="IsWebchatPreviewEnabled" /> property.</summary>
        private bool? _isWebchatPreviewEnabled;

        /// <summary>Whether this site is enabled for preview versions of Webchat</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public bool? IsWebchatPreviewEnabled { get => this._isWebchatPreviewEnabled; set => this._isWebchatPreviewEnabled = value; }

        /// <summary>Backing field for <see cref="Key" /> property.</summary>
        private string _key;

        /// <summary>
        /// Primary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string Key { get => this._key; }

        /// <summary>Backing field for <see cref="Key2" /> property.</summary>
        private string _key2;

        /// <summary>
        /// Secondary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string Key2 { get => this._key2; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for IsTokenEnabled</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal.IsTokenEnabled { get => this._isTokenEnabled; set { {_isTokenEnabled = value;} } }

        /// <summary>Internal Acessors for Key</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal.Key { get => this._key; set { {_key = value;} } }

        /// <summary>Internal Acessors for Key2</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.ISiteInternal.Key2 { get => this._key2; set { {_key2 = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Site name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="TrustedOrigin" /> property.</summary>
        private System.Collections.Generic.List<string> _trustedOrigin;

        /// <summary>
        /// List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> TrustedOrigin { get => this._trustedOrigin; set => this._trustedOrigin = value; }

        /// <summary>Creates an new <see cref="Site" /> instance.</summary>
        public Site()
        {

        }
    }
    /// A site for the channel
    public partial interface ISite :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable
    {
        /// <summary>DirectLine application id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"DirectLine application id",
        SerializedName = @"appId",
        PossibleTypes = new [] { typeof(string) })]
        string AppId { get; set; }
        /// <summary>Entity Tag</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Entity Tag",
        SerializedName = @"eTag",
        PossibleTypes = new [] { typeof(string) })]
        string ETag { get; set; }
        /// <summary>Site Id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Site Id",
        SerializedName = @"siteId",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Whether this site is enabled for block user upload.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is enabled for block user upload.",
        SerializedName = @"isBlockUserUploadEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsBlockUserUploadEnabled { get; set; }
        /// <summary>Whether this site is disabled detailed logging for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is disabled detailed logging for",
        SerializedName = @"isDetailedLoggingEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDetailedLoggingEnabled { get; set; }
        /// <summary>Whether this site is enabled for DirectLine channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is enabled for DirectLine channel",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool IsEnabled { get; set; }
        /// <summary>Whether this site is EndpointParameters enabled for channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is EndpointParameters enabled for channel",
        SerializedName = @"isEndpointParametersEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEndpointParametersEnabled { get; set; }
        /// <summary>Whether this no-storage site is disabled detailed logging for</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this no-storage site is disabled detailed logging for",
        SerializedName = @"isNoStorageEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsNoStorageEnabled { get; set; }
        /// <summary>Whether this site is enabled for authentication with Bot Framework.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is enabled for authentication with Bot Framework.",
        SerializedName = @"isSecureSiteEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsSecureSiteEnabled { get; set; }
        /// <summary>Whether this site is token enabled for channel</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Whether this site is token enabled for channel",
        SerializedName = @"isTokenEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsTokenEnabled { get;  }
        /// <summary>Whether this site is enabled for Bot Framework V1 protocol.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is enabled for Bot Framework V1 protocol.",
        SerializedName = @"isV1Enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsV1Enabled { get; set; }
        /// <summary>Whether this site is enabled for Bot Framework V1 protocol.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is enabled for Bot Framework V1 protocol.",
        SerializedName = @"isV3Enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsV3Enabled { get; set; }
        /// <summary>Whether this site is enabled for preview versions of Webchat</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Whether this site is enabled for preview versions of Webchat",
        SerializedName = @"isWebchatPreviewEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsWebchatPreviewEnabled { get; set; }
        /// <summary>
        /// Primary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Primary key. Value only returned through POST to the action Channel List API, otherwise empty.",
        SerializedName = @"key",
        PossibleTypes = new [] { typeof(string) })]
        string Key { get;  }
        /// <summary>
        /// Secondary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Secondary key. Value only returned through POST to the action Channel List API, otherwise empty.",
        SerializedName = @"key2",
        PossibleTypes = new [] { typeof(string) })]
        string Key2 { get;  }
        /// <summary>Site name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Site name",
        SerializedName = @"siteName",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True.",
        SerializedName = @"trustedOrigins",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> TrustedOrigin { get; set; }

    }
    /// A site for the channel
    internal partial interface ISiteInternal

    {
        /// <summary>DirectLine application id</summary>
        string AppId { get; set; }
        /// <summary>Entity Tag</summary>
        string ETag { get; set; }
        /// <summary>Site Id</summary>
        string Id { get; set; }
        /// <summary>Whether this site is enabled for block user upload.</summary>
        bool? IsBlockUserUploadEnabled { get; set; }
        /// <summary>Whether this site is disabled detailed logging for</summary>
        bool? IsDetailedLoggingEnabled { get; set; }
        /// <summary>Whether this site is enabled for DirectLine channel</summary>
        bool IsEnabled { get; set; }
        /// <summary>Whether this site is EndpointParameters enabled for channel</summary>
        bool? IsEndpointParametersEnabled { get; set; }
        /// <summary>Whether this no-storage site is disabled detailed logging for</summary>
        bool? IsNoStorageEnabled { get; set; }
        /// <summary>Whether this site is enabled for authentication with Bot Framework.</summary>
        bool? IsSecureSiteEnabled { get; set; }
        /// <summary>Whether this site is token enabled for channel</summary>
        bool? IsTokenEnabled { get; set; }
        /// <summary>Whether this site is enabled for Bot Framework V1 protocol.</summary>
        bool? IsV1Enabled { get; set; }
        /// <summary>Whether this site is enabled for Bot Framework V1 protocol.</summary>
        bool? IsV3Enabled { get; set; }
        /// <summary>Whether this site is enabled for preview versions of Webchat</summary>
        bool? IsWebchatPreviewEnabled { get; set; }
        /// <summary>
        /// Primary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        string Key { get; set; }
        /// <summary>
        /// Secondary key. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        string Key2 { get; set; }
        /// <summary>Site name</summary>
        string Name { get; set; }
        /// <summary>
        /// List of Trusted Origin URLs for this site. This field is applicable only if isSecureSiteEnabled is True.
        /// </summary>
        System.Collections.Generic.List<string> TrustedOrigin { get; set; }

    }
}