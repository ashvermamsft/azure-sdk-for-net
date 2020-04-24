// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.KeyVault.Models;

namespace Azure.Management.KeyVault
{
    public partial class VaultsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VaultsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VaultsClient for mocking. </summary>
        protected VaultsClient()
        {
        }

        /// <summary> Initializes a new instance of VaultsClient. </summary>
        public VaultsClient(string subscriptionId, TokenCredential tokenCredential, KeyVaultManagementClientOptions options = null)
        {
            options = options ?? new KeyVaultManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, options);
            RestClient = new VaultsRestClient(_clientDiagnostics, _pipeline, subscriptionId, apiVersion: options.Version);
        }

        /// <summary> Update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="tags"> The tags that will be assigned to the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Vault>> UpdateAsync(string resourceGroupName, string vaultName, IDictionary<string, string> tags = null, VaultPatchProperties properties = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateAsync(resourceGroupName, vaultName, tags, properties, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="tags"> The tags that will be assigned to the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Vault> Update(string resourceGroupName, string vaultName, IDictionary<string, string> tags = null, VaultPatchProperties properties = null, CancellationToken cancellationToken = default)
        {
            return RestClient.Update(resourceGroupName, vaultName, tags, properties, cancellationToken);
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> DeleteAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            return await RestClient.DeleteAsync(resourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Deletes the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault to delete. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            return RestClient.Delete(resourceGroupName, vaultName, cancellationToken);
        }

        /// <summary> Gets the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Vault>> GetAsync(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetAsync(resourceGroupName, vaultName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the specified Azure key vault. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Vault> Get(string resourceGroupName, string vaultName, CancellationToken cancellationToken = default)
        {
            return RestClient.Get(resourceGroupName, vaultName, cancellationToken);
        }

        /// <summary> Update access policies in a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="operationKind"> Name of the operation. </param>
        /// <param name="properties"> Properties of the access policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VaultAccessPolicyParameters>> UpdateAccessPolicyAsync(string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyProperties properties, CancellationToken cancellationToken = default)
        {
            return await RestClient.UpdateAccessPolicyAsync(resourceGroupName, vaultName, operationKind, properties, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Update access policies in a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="operationKind"> Name of the operation. </param>
        /// <param name="properties"> Properties of the access policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VaultAccessPolicyParameters> UpdateAccessPolicy(string resourceGroupName, string vaultName, AccessPolicyUpdateKind operationKind, VaultAccessPolicyProperties properties, CancellationToken cancellationToken = default)
        {
            return RestClient.UpdateAccessPolicy(resourceGroupName, vaultName, operationKind, properties, cancellationToken);
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DeletedVault>> GetDeletedAsync(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetDeletedAsync(vaultName, location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the vault. </param>
        /// <param name="location"> The location of the deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DeletedVault> GetDeleted(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            return RestClient.GetDeleted(vaultName, location, cancellationToken);
        }

        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="name"> The vault name. </param>
        /// <param name="type"> The type of resource, Microsoft.KeyVault/vaults. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResult>> CheckNameAvailabilityAsync(string name, string type = "Microsoft.KeyVault/vaults", CancellationToken cancellationToken = default)
        {
            return await RestClient.CheckNameAvailabilityAsync(name, type, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Checks that the vault name is valid and is not already in use. </summary>
        /// <param name="name"> The vault name. </param>
        /// <param name="type"> The type of resource, Microsoft.KeyVault/vaults. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResult> CheckNameAvailability(string name, string type = "Microsoft.KeyVault/vaults", CancellationToken cancellationToken = default)
        {
            return RestClient.CheckNameAvailability(name, type, cancellationToken);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription and within the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Vault> ListByResourceGroupAsync(string resourceGroupName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<Vault>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<Vault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription and within the specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the vault belongs. </param>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Vault> ListByResourceGroup(string resourceGroupName, int? top = null, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<Vault> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListByResourceGroup(resourceGroupName, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<Vault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Vault> ListBySubscriptionAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Vault>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListBySubscriptionAsync(top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<Vault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Vault> ListBySubscription(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Vault> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListBySubscription(top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<Vault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListBySubscriptionNextPage(nextLink, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about the deleted vaults in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<DeletedVault> ListDeletedAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DeletedVault>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListDeletedAsync(cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<DeletedVault>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListDeletedNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about the deleted vaults in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<DeletedVault> ListDeleted(CancellationToken cancellationToken = default)
        {
            Page<DeletedVault> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.ListDeleted(cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<DeletedVault> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListDeletedNextPage(nextLink, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Resource> ListAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Resource>> FirstPageFunc(int? pageSizeHint)
            {
                var response = await RestClient.ListAsync(top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            async Task<Page<Resource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = await RestClient.ListNextPageAsync(nextLink, top, cancellationToken).ConfigureAwait(false);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The List operation gets information about the vaults associated with the subscription. </summary>
        /// <param name="top"> Maximum number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Resource> List(int? top = null, CancellationToken cancellationToken = default)
        {
            Page<Resource> FirstPageFunc(int? pageSizeHint)
            {
                var response = RestClient.List(top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            Page<Resource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                var response = RestClient.ListNextPage(nextLink, top, cancellationToken);
                return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Vault> CreateCreateOrUpdate(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Put, "VaultsClient.CreateOrUpdate", OperationFinalStateVia.Location, createOriginalHttpMessage,
            (response, cancellationToken) =>
            {
                using var document = JsonDocument.Parse(response.ContentStream);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return Vault.DeserializeVault(document.RootElement);
                }
            },
            async (response, cancellationToken) =>
            {
                using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                if (document.RootElement.ValueKind == JsonValueKind.Null)
                {
                    return null;
                }
                else
                {
                    return Vault.DeserializeVault(document.RootElement);
                }
            });
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Vault>> StartCreateOrUpdateAsync(string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, vaultName, parameters, cancellationToken).ConfigureAwait(false);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vaultName, parameters));
        }

        /// <summary> Create or update a key vault in the specified subscription. </summary>
        /// <param name="resourceGroupName"> The name of the Resource Group to which the server belongs. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="parameters"> Parameters to create or update the vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Vault> StartCreateOrUpdate(string resourceGroupName, string vaultName, VaultCreateOrUpdateParameters parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, vaultName, parameters, cancellationToken);
            return CreateCreateOrUpdate(originalResponse, () => RestClient.CreateCreateOrUpdateRequest(resourceGroupName, vaultName, parameters));
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="originalResponse"> The original response from starting the operation. </param>
        /// <param name="createOriginalHttpMessage"> Creates the HTTP message used for the original request. </param>
        internal Operation<Response> CreatePurgeDeleted(Response originalResponse, Func<HttpMessage> createOriginalHttpMessage)
        {
            if (originalResponse == null)
            {
                throw new ArgumentNullException(nameof(originalResponse));
            }
            if (createOriginalHttpMessage == null)
            {
                throw new ArgumentNullException(nameof(createOriginalHttpMessage));
            }

            return ArmOperationHelpers.Create(_pipeline, _clientDiagnostics, originalResponse, RequestMethod.Post, "VaultsClient.PurgeDeleted", OperationFinalStateVia.Location, createOriginalHttpMessage);
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the soft-deleted vault. </param>
        /// <param name="location"> The location of the soft-deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<Operation<Response>> StartPurgeDeletedAsync(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            var originalResponse = await RestClient.PurgeDeletedAsync(vaultName, location, cancellationToken).ConfigureAwait(false);
            return CreatePurgeDeleted(originalResponse, () => RestClient.CreatePurgeDeletedRequest(vaultName, location));
        }

        /// <summary> Permanently deletes the specified vault. aka Purges the deleted Azure key vault. </summary>
        /// <param name="vaultName"> The name of the soft-deleted vault. </param>
        /// <param name="location"> The location of the soft-deleted vault. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Operation<Response> StartPurgeDeleted(string vaultName, string location, CancellationToken cancellationToken = default)
        {
            if (vaultName == null)
            {
                throw new ArgumentNullException(nameof(vaultName));
            }
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            var originalResponse = RestClient.PurgeDeleted(vaultName, location, cancellationToken);
            return CreatePurgeDeleted(originalResponse, () => RestClient.CreatePurgeDeletedRequest(vaultName, location));
        }
    }
}
