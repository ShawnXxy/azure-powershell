// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// Provider specific input for InMage unplanned failover.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMage")]
    public partial class InMageUnplannedFailoverInput : UnplannedFailoverProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageUnplannedFailoverInput class.
        /// </summary>
        public InMageUnplannedFailoverInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageUnplannedFailoverInput class.
        /// </summary>

        /// <param name="recoveryPointType">The recovery point type. Values from LatestTime, LatestTag or Custom. In
        /// the case of custom, the recovery point provided by RecoveryPointId will be
        /// used. In the other two cases, recovery point id will be ignored.
        /// Possible values include: &#39;LatestTime&#39;, &#39;LatestTag&#39;, &#39;Custom&#39;</param>

        /// <param name="recoveryPointId">The recovery point id to be passed to failover to a particular recovery
        /// point. In case of latest recovery point, null should be passed.
        /// </param>
        public InMageUnplannedFailoverInput(string recoveryPointType = default(string), string recoveryPointId = default(string))

        {
            this.RecoveryPointType = recoveryPointType;
            this.RecoveryPointId = recoveryPointId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the recovery point type. Values from LatestTime, LatestTag or
        /// Custom. In the case of custom, the recovery point provided by
        /// RecoveryPointId will be used. In the other two cases, recovery point id
        /// will be ignored. Possible values include: &#39;LatestTime&#39;, &#39;LatestTag&#39;, &#39;Custom&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointType")]
        public string RecoveryPointType {get; set; }

        /// <summary>
        /// Gets or sets the recovery point id to be passed to failover to a particular
        /// recovery point. In case of latest recovery point, null should be passed.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "recoveryPointId")]
        public string RecoveryPointId {get; set; }
    }
}