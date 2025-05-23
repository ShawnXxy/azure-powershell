// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.PolicyInsights.Models
{
    using System.Linq;

    /// <summary>
    /// The result of a check policy restrictions evaluation on a resource.
    /// </summary>
    public partial class CheckRestrictionsResult
    {
        /// <summary>
        /// Initializes a new instance of the CheckRestrictionsResult class.
        /// </summary>
        public CheckRestrictionsResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckRestrictionsResult class.
        /// </summary>

        /// <param name="fieldRestrictions">The restrictions that will be placed on various fields in the resource by
        /// policy.
        /// </param>

        /// <param name="contentEvaluationResult">Evaluation results for the provided partial resource content.
        /// </param>
        public CheckRestrictionsResult(System.Collections.Generic.IList<FieldRestrictions> fieldRestrictions = default(System.Collections.Generic.IList<FieldRestrictions>), CheckRestrictionsResultContentEvaluationResult contentEvaluationResult = default(CheckRestrictionsResultContentEvaluationResult))

        {
            this.FieldRestrictions = fieldRestrictions;
            this.ContentEvaluationResult = contentEvaluationResult;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets the restrictions that will be placed on various fields in the resource
        /// by policy.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "fieldRestrictions")]
        public System.Collections.Generic.IList<FieldRestrictions> FieldRestrictions {get; private set; }

        /// <summary>
        /// Gets evaluation results for the provided partial resource content.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "contentEvaluationResult")]
        public CheckRestrictionsResultContentEvaluationResult ContentEvaluationResult {get; private set; }
    }
}