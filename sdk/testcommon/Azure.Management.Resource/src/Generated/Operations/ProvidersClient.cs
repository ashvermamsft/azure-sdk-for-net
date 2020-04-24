// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resource.Models;

namespace Azure.Management.Resource
{
    /// <summary> The Providers service client. </summary>
    public partial class ProvidersClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ProvidersRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ProvidersClient for mocking. </summary>
        protected ProvidersClient()
        {
        }

        /// <summary> Initializes a new instance of ProvidersClient. </summary>
        public ProvidersClient(string subscriptionId, TokenCredential tokenCredential, ResourceManagementClientOptions options = null)
        {
            options = options ?? new ResourceManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new ProvidersRestClient(_clientDiagnostics, _pipeline, subscriptionId, apiVersion: options.Version);
        }

        /// <summary> Unregisters provider from a subscription. </summary>
        /// <param name="resourceProviderNamespace"> Namespace of the resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> UnregisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            return await RestClient.UnregisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Unregisters provider from a subscription. </summary>
        /// <param name="resourceProviderNamespace"> Namespace of the resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Unregister(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            return RestClient.Unregister(resourceProviderNamespace, cancellationToken);
        }

        /// <summary> Registers provider to be used with a subscription. </summary>
        /// <param name="resourceProviderNamespace"> Namespace of the resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> RegisterAsync(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            return await RestClient.RegisterAsync(resourceProviderNamespace, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Registers provider to be used with a subscription. </summary>
        /// <param name="resourceProviderNamespace"> Namespace of the resource provider. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Register(string resourceProviderNamespace, CancellationToken cancellationToken = default)
        {
            return RestClient.Register(resourceProviderNamespace, cancellationToken);
        }

        /// <summary> Gets a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> Namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. e.g. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Provider>> GetAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets a resource provider. </summary>
        /// <param name="resourceProviderNamespace"> Namespace of the resource provider. </param>
        /// <param name="expand"> The $expand query parameter. e.g. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Provider> Get(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceProviderNamespace, expand, cancellationToken);
        }

        /// <summary> Gets a list of resource providers. </summary>
        /// <param name="top"> Query parameters. If null is passed returns all deployments. </param>
        /// <param name="expand"> The $expand query parameter. e.g. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Provider> ListAsync(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Provider>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(top, expand, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<Provider>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, top, expand, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of resource providers. </summary>
        /// <param name="top"> Query parameters. If null is passed returns all deployments. </param>
        /// <param name="expand"> The $expand query parameter. e.g. To include property aliases in response, use $expand=resourceTypes/aliases. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Provider> List(int? top = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<Provider> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(top, expand, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<Provider> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, top, expand, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
