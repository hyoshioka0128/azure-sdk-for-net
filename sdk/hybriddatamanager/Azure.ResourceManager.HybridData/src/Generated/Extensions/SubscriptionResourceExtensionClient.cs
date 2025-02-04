// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridData
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _dataManagerClientDiagnostics;
        private DataManagersRestOperations _dataManagerRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DataManagerClientDiagnostics => _dataManagerClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HybridData", DataManagerResource.ResourceType.Namespace, Diagnostics);
        private DataManagersRestOperations DataManagerRestClient => _dataManagerRestClient ??= new DataManagersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(DataManagerResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the data manager resources available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridData/dataManagers
        /// Operation Id: DataManagers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataManagerResource> GetDataManagersAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataManagerResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataManagerClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataManagers");
                scope.Start();
                try
                {
                    var response = await DataManagerRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataManagerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all the data manager resources available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.HybridData/dataManagers
        /// Operation Id: DataManagers_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataManagerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataManagerResource> GetDataManagers(CancellationToken cancellationToken = default)
        {
            Page<DataManagerResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = DataManagerClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetDataManagers");
                scope.Start();
                try
                {
                    var response = DataManagerRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataManagerResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
