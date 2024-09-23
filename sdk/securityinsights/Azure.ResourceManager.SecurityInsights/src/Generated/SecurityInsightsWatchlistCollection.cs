// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing a collection of <see cref="SecurityInsightsWatchlistResource"/> and their operations.
    /// Each <see cref="SecurityInsightsWatchlistResource"/> in the collection will belong to the same instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// To get a <see cref="SecurityInsightsWatchlistCollection"/> instance call the GetSecurityInsightsWatchlists method from an instance of <see cref="OperationalInsightsWorkspaceSecurityInsightsResource"/>.
    /// </summary>
    public partial class SecurityInsightsWatchlistCollection : ArmCollection, IEnumerable<SecurityInsightsWatchlistResource>, IAsyncEnumerable<SecurityInsightsWatchlistResource>
    {
        private readonly ClientDiagnostics _securityInsightsWatchlistWatchlistsClientDiagnostics;
        private readonly WatchlistsRestOperations _securityInsightsWatchlistWatchlistsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsWatchlistCollection"/> class for mocking. </summary>
        protected SecurityInsightsWatchlistCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecurityInsightsWatchlistCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecurityInsightsWatchlistCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securityInsightsWatchlistWatchlistsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityInsights", SecurityInsightsWatchlistResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecurityInsightsWatchlistResource.ResourceType, out string securityInsightsWatchlistWatchlistsApiVersion);
            _securityInsightsWatchlistWatchlistsRestClient = new WatchlistsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securityInsightsWatchlistWatchlistsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, OperationalInsightsWorkspaceSecurityInsightsResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Watchlist and its Watchlist Items (bulk creation, e.g. through text/csv content type). To create a Watchlist and its Items, we should call this endpoint with either rawContent or a valid SAR URI and contentType properties. The rawContent is mainly used for small watchlist (content size below 3.8 MB). The SAS URI enables the creation of large watchlist, where the content size can go up to 500 MB. The status of processing such large file can be polled through the URL returned in Azure-AsyncOperation header.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="data"> The watchlist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecurityInsightsWatchlistResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string watchlistAlias, SecurityInsightsWatchlistData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, data, cancellationToken).ConfigureAwait(false);
                var uri = _securityInsightsWatchlistWatchlistsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsWatchlistResource>(Response.FromValue(new SecurityInsightsWatchlistResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update a Watchlist and its Watchlist Items (bulk creation, e.g. through text/csv content type). To create a Watchlist and its Items, we should call this endpoint with either rawContent or a valid SAR URI and contentType properties. The rawContent is mainly used for small watchlist (content size below 3.8 MB). The SAS URI enables the creation of large watchlist, where the content size can go up to 500 MB. The status of processing such large file can be polled through the URL returned in Azure-AsyncOperation header.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="data"> The watchlist. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecurityInsightsWatchlistResource> CreateOrUpdate(WaitUntil waitUntil, string watchlistAlias, SecurityInsightsWatchlistData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, data, cancellationToken);
                var uri = _securityInsightsWatchlistWatchlistsRestClient.CreateCreateOrUpdateRequestUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, data);
                var rehydrationToken = NextLinkOperationImplementation.GetRehydrationToken(RequestMethod.Put, uri.ToUri(), uri.ToString(), "None", null, OperationFinalStateVia.OriginalUri.ToString());
                var operation = new SecurityInsightsArmOperation<SecurityInsightsWatchlistResource>(Response.FromValue(new SecurityInsightsWatchlistResource(Client, response), response.GetRawResponse()), rehydrationToken);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a watchlist, without its watchlist items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual async Task<Response<SecurityInsightsWatchlistResource>> GetAsync(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.Get");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a watchlist, without its watchlist items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual Response<SecurityInsightsWatchlistResource> Get(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.Get");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all watchlists, without watchlist items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecurityInsightsWatchlistResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecurityInsightsWatchlistResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsWatchlistWatchlistsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsWatchlistWatchlistsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsWatchlistResource(Client, SecurityInsightsWatchlistData.DeserializeSecurityInsightsWatchlistData(e)), _securityInsightsWatchlistWatchlistsClientDiagnostics, Pipeline, "SecurityInsightsWatchlistCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all watchlists, without watchlist items.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. Optional. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecurityInsightsWatchlistResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecurityInsightsWatchlistResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securityInsightsWatchlistWatchlistsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securityInsightsWatchlistWatchlistsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecurityInsightsWatchlistResource(Client, SecurityInsightsWatchlistData.DeserializeSecurityInsightsWatchlistData(e)), _securityInsightsWatchlistWatchlistsClientDiagnostics, Pipeline, "SecurityInsightsWatchlistCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual Response<bool> Exists(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.Exists");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual async Task<NullableResponse<SecurityInsightsWatchlistResource>> GetIfExistsAsync(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _securityInsightsWatchlistWatchlistsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsWatchlistResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.OperationalInsights/workspaces/{workspaceName}/providers/Microsoft.SecurityInsights/watchlists/{watchlistAlias}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Watchlists_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecurityInsightsWatchlistResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="watchlistAlias"> Watchlist Alias. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="watchlistAlias"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="watchlistAlias"/> is null. </exception>
        public virtual NullableResponse<SecurityInsightsWatchlistResource> GetIfExists(string watchlistAlias, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(watchlistAlias, nameof(watchlistAlias));

            using var scope = _securityInsightsWatchlistWatchlistsClientDiagnostics.CreateScope("SecurityInsightsWatchlistCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _securityInsightsWatchlistWatchlistsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, watchlistAlias, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SecurityInsightsWatchlistResource>(response.GetRawResponse());
                return Response.FromValue(new SecurityInsightsWatchlistResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecurityInsightsWatchlistResource> IEnumerable<SecurityInsightsWatchlistResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecurityInsightsWatchlistResource> IAsyncEnumerable<SecurityInsightsWatchlistResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
