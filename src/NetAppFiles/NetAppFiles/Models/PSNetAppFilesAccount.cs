// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Azure.Commands.NetAppFiles.Models
{
    /// <summary>
    /// ARM tracked resource
    /// </summary>
    public class PSNetAppFilesAccount
    {
        /// <summary>
        /// Gets or sets the Resource group name
        /// </summary>
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// Gets or sets Resource location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets resource Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        public object Tags { get; set; }

        /// <summary>
        /// Gets or sets resource etag
        /// </summary>
        /// <remarks>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </remarks>
        public string Etag { get; set; }

        /// <summary>
        /// Gets azure lifecycle management
        /// </summary>
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets active directory
        /// </summary>
        public List<PSNetAppFilesActiveDirectory> ActiveDirectories { get; set; }

        public PSNetAppFilesAccountEncryption Encryption { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        public PSManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets System Data
        /// </summary>
        public PSSystemData SystemData { get; set; }

        /// <summary>
        /// Gets or sets DisableShowmount 
        /// Shows the status of disableShowmount
        /// for all volumes under the subscription, null equals false
        /// </summary>
        public bool? DisableShowmount {get; set;}

        /// <summary>
        /// Gets or sets NfsV4IdDomain 
        /// Shows the status of NfsV4IdDomain
        /// </summary>
        public string NfsV4IdDomain  { get; set; }

        /// <summary>
        /// Gets or sets MultiAdStatus 
        /// Shows the status of MultiAdStatus
        /// </summary>
        public string MultiAdStatus { get; set; }
    }
}