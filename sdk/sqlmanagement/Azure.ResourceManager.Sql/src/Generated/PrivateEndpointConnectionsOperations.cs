// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> The PrivateEndpointConnections service client. </summary>
    public partial class PrivateEndpointConnectionsOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PrivateEndpointConnectionsRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionsOperations for mocking. </summary>
        protected PrivateEndpointConnectionsOperations()
        {
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionsOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription ID that identifies an Azure subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal PrivateEndpointConnectionsOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new PrivateEndpointConnectionsRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets a private endpoint connection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PrivateEndpointConnection>> GetAsync(string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, serverName, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a private endpoint connection. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PrivateEndpointConnection> Get(string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, serverName, privateEndpointConnectionName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all private endpoint connections on a server. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serverName"/> is null. </exception>
        public virtual AsyncPageable<PrivateEndpointConnection> ListByServerAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            async Task<Page<PrivateEndpointConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByServerAsync(resourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PrivateEndpointConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByServerNextPageAsync(nextLink, resourceGroupName, serverName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all private endpoint connections on a server. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="serverName"/> is null. </exception>
        public virtual Pageable<PrivateEndpointConnection> ListByServer(string resourceGroupName, string serverName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }

            Page<PrivateEndpointConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = RestClient.ListByServer(resourceGroupName, serverName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PrivateEndpointConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.ListByServer");
                scope.Start();
                try
                {
                    var response = RestClient.ListByServerNextPage(nextLink, resourceGroupName, serverName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Approve or reject a private endpoint connection with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="parameters"> The PrivateEndpointConnection to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="privateEndpointConnectionName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<PrivateEndpointConnectionsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string serverName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, serverName, privateEndpointConnectionName, parameters, cancellationToken).ConfigureAwait(false);
                return new PrivateEndpointConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, privateEndpointConnectionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Approve or reject a private endpoint connection with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="parameters"> The PrivateEndpointConnection to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, <paramref name="privateEndpointConnectionName"/>, or <paramref name="parameters"/> is null. </exception>
        public virtual PrivateEndpointConnectionsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string serverName, string privateEndpointConnectionName, PrivateEndpointConnection parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, serverName, privateEndpointConnectionName, parameters, cancellationToken);
                return new PrivateEndpointConnectionsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, serverName, privateEndpointConnectionName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a private endpoint connection with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<PrivateEndpointConnectionsDeleteOperation> StartDeleteAsync(string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, serverName, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                return new PrivateEndpointConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, serverName, privateEndpointConnectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a private endpoint connection with a given name. </summary>
        /// <param name="resourceGroupName"> The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="privateEndpointConnectionName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="serverName"/>, or <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual PrivateEndpointConnectionsDeleteOperation StartDelete(string resourceGroupName, string serverName, string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (serverName == null)
            {
                throw new ArgumentNullException(nameof(serverName));
            }
            if (privateEndpointConnectionName == null)
            {
                throw new ArgumentNullException(nameof(privateEndpointConnectionName));
            }

            using var scope = _clientDiagnostics.CreateScope("PrivateEndpointConnectionsOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, serverName, privateEndpointConnectionName, cancellationToken);
                return new PrivateEndpointConnectionsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, serverName, privateEndpointConnectionName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
