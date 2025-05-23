// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Version related details.
    /// </summary>
    public partial class VersionDetails
    {
        /// <summary>
        /// Initializes a new instance of the VersionDetails class.
        /// </summary>
        public VersionDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VersionDetails class.
        /// </summary>

        /// <param name="version">The agent version.
        /// </param>

        /// <param name="expiryDate">Version expiry date.
        /// </param>

        /// <param name="status">A value indicating whether security update required.
        /// Possible values include: &#39;Supported&#39;, &#39;NotSupported&#39;, &#39;Deprecated&#39;,
        /// &#39;UpdateRequired&#39;, &#39;SecurityUpdateRequired&#39;</param>
        public VersionDetails(string version = default(string), System.DateTime? expiryDate = default(System.DateTime?), string status = default(string))

        {
            this.Version = version;
            this.ExpiryDate = expiryDate;
            this.Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the agent version.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "version")]
        public string Version {get; set; }

        /// <summary>
        /// Gets or sets version expiry date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "expiryDate")]
        public System.DateTime? ExpiryDate {get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether security update required. Possible values include: &#39;Supported&#39;, &#39;NotSupported&#39;, &#39;Deprecated&#39;, &#39;UpdateRequired&#39;, &#39;SecurityUpdateRequired&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }
    }
}