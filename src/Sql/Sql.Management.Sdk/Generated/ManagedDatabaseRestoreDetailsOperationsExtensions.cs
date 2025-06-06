// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for ManagedDatabaseRestoreDetailsOperations
    /// </summary>
    public static partial class ManagedDatabaseRestoreDetailsOperationsExtensions
    {
        /// <summary>
        /// Gets managed database restore details.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain
        /// this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        public static ManagedDatabaseRestoreDetailsResult Get(this IManagedDatabaseRestoreDetailsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName)
        {
                return ((IManagedDatabaseRestoreDetailsOperations)operations).GetAsync(resourceGroupName, managedInstanceName, databaseName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets managed database restore details.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains the resource. You can obtain
        /// this value from the Azure Resource Manager API or the portal.
        /// </param>
        /// <param name='managedInstanceName'>
        /// The name of the managed instance.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<ManagedDatabaseRestoreDetailsResult> GetAsync(this IManagedDatabaseRestoreDetailsOperations operations, string resourceGroupName, string managedInstanceName, string databaseName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedInstanceName, databaseName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
