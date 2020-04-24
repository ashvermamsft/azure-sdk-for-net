// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Graph.Rbac.Models;

namespace Azure.Graph.Rbac
{
    public partial class ServicePrincipalsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ServicePrincipalsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ServicePrincipalsClient for mocking. </summary>
        protected ServicePrincipalsClient()
        {
        }

        /// <summary> Initializes a new instance of ServicePrincipalsClient. </summary>
        public ServicePrincipalsClient(string tenantID, TokenCredential tokenCredential, RbacManagementClientOptions options = null)
        {
            options = options ?? new RbacManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new ServicePrincipalsRestClient(_clientDiagnostics, _pipeline, tenantID, apiVersion: options.Version);
        }

        /// <summary> Creates a service principal in the directory. </summary>
        /// <param name="parameters"> Parameters to create a service principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServicePrincipal>> CreateAsync(ServicePrincipalCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateAsync(parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a service principal in the directory. </summary>
        /// <param name="parameters"> Parameters to create a service principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServicePrincipal> Create(ServicePrincipalCreateParameters parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.Create(parameters, cancellationToken);
        }

        /// <summary> Updates a service principal in the directory. </summary>
        /// <param name="objectId"> The object ID of the service principal to delete. </param>
        /// <param name="parameters"> Parameters to update a service principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateAsync(string objectId, ServicePrincipalUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateAsync(objectId, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates a service principal in the directory. </summary>
        /// <param name="objectId"> The object ID of the service principal to delete. </param>
        /// <param name="parameters"> Parameters to update a service principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Update(string objectId, ServicePrincipalUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            return RestClient.Update(objectId, parameters, cancellationToken);
        }

        /// <summary> Deletes a service principal from the directory. </summary>
        /// <param name="objectId"> The object ID of the service principal to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string objectId, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(objectId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes a service principal from the directory. </summary>
        /// <param name="objectId"> The object ID of the service principal to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string objectId, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(objectId, cancellationToken);
        }

        /// <summary> Gets service principal information from the directory. Query by objectId or pass a filter to query by appId. </summary>
        /// <param name="objectId"> The object ID of the service principal to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ServicePrincipal>> GetAsync(string objectId, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(objectId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets service principal information from the directory. Query by objectId or pass a filter to query by appId. </summary>
        /// <param name="objectId"> The object ID of the service principal to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ServicePrincipal> Get(string objectId, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(objectId, cancellationToken);
        }

        /// <summary> Update the keyCredentials associated with a service principal. </summary>
        /// <param name="objectId"> The object ID for which to get service principal information. </param>
        /// <param name="value"> A collection of KeyCredentials. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdateKeyCredentialsAsync(string objectId, IEnumerable<KeyCredential> value, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateKeyCredentialsAsync(objectId, value, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Update the keyCredentials associated with a service principal. </summary>
        /// <param name="objectId"> The object ID for which to get service principal information. </param>
        /// <param name="value"> A collection of KeyCredentials. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdateKeyCredentials(string objectId, IEnumerable<KeyCredential> value, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateKeyCredentials(objectId, value, cancellationToken);
        }

        /// <summary> Updates the passwordCredentials associated with a service principal. </summary>
        /// <param name="objectId"> The object ID of the service principal. </param>
        /// <param name="value"> A collection of PasswordCredentials. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UpdatePasswordCredentialsAsync(string objectId, IEnumerable<PasswordCredential> value, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdatePasswordCredentialsAsync(objectId, value, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Updates the passwordCredentials associated with a service principal. </summary>
        /// <param name="objectId"> The object ID of the service principal. </param>
        /// <param name="value"> A collection of PasswordCredentials. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response UpdatePasswordCredentials(string objectId, IEnumerable<PasswordCredential> value, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdatePasswordCredentials(objectId, value, cancellationToken);
        }

        /// <summary> Gets a list of service principals from the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ServicePrincipal> ListAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ServicePrincipal>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(filter, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            async Task<Page<ServicePrincipal>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of service principals from the current tenant. </summary>
        /// <param name="filter"> The filter to apply to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ServicePrincipal> List(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ServicePrincipal> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(filter, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            Page<ServicePrincipal> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNext(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The owners are a set of non-admin users who are allowed to modify this object. </summary>
        /// <param name="objectId"> The object ID of the service principal for which to get owners. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DirectoryObject> ListOwnersAsync(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            async Task<Page<DirectoryObject>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListOwnersAsync(objectId, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            async Task<Page<DirectoryObject>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListOwnersNextPageAsync(nextLink, objectId, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The owners are a set of non-admin users who are allowed to modify this object. </summary>
        /// <param name="objectId"> The object ID of the service principal for which to get owners. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DirectoryObject> ListOwners(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            Page<DirectoryObject> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListOwners(objectId, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            Page<DirectoryObject> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListOwnersNextPage(nextLink, objectId, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get the keyCredentials associated with the specified service principal. </summary>
        /// <param name="objectId"> The object ID of the service principal for which to get keyCredentials. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<KeyCredential> ListKeyCredentialsAsync(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            async Task<Page<KeyCredential>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListKeyCredentialsAsync(objectId, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            async Task<Page<KeyCredential>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListKeyCredentialsNextPageAsync(nextLink, objectId, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get the keyCredentials associated with the specified service principal. </summary>
        /// <param name="objectId"> The object ID of the service principal for which to get keyCredentials. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<KeyCredential> ListKeyCredentials(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            Page<KeyCredential> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListKeyCredentials(objectId, cancellationToken);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            Page<KeyCredential> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListKeyCredentialsNextPage(nextLink, objectId, cancellationToken);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the passwordCredentials associated with a service principal. </summary>
        /// <param name="objectId"> The object ID of the service principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PasswordCredential> ListPasswordCredentialsAsync(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            async Task<Page<PasswordCredential>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListPasswordCredentialsAsync(objectId, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            async Task<Page<PasswordCredential>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListPasswordCredentialsNextPageAsync(nextLink, objectId, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets the passwordCredentials associated with a service principal. </summary>
        /// <param name="objectId"> The object ID of the service principal. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PasswordCredential> ListPasswordCredentials(string objectId, CancellationToken cancellationToken = default)
        {
            if (objectId == null)
            {
                throw new ArgumentNullException(nameof(objectId));
            }

            Page<PasswordCredential> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListPasswordCredentials(objectId, cancellationToken);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            Page<PasswordCredential> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListPasswordCredentialsNextPage(nextLink, objectId, cancellationToken);
                return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of service principals from the current tenant. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ServicePrincipal> ListNextAsync(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            async Task<Page<ServicePrincipal>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListNextAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            async Task<Page<ServicePrincipal>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of service principals from the current tenant. </summary>
        /// <param name="nextLink"> Next link for the list operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ServicePrincipal> ListNext(string nextLink, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Page<ServicePrincipal> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListNext(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            Page<ServicePrincipal> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.OdataNextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
