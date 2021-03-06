// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The Notebooks service client. </summary>
    public partial class NotebooksOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal NotebooksRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of NotebooksOperations for mocking. </summary>
        protected NotebooksOperations()
        {
        }

        /// <summary> Initializes a new instance of NotebooksOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal NotebooksOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01-preview")
        {
            RestClient = new NotebooksRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ListNotebookKeysResult>> ListKeysAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebooksOperations.ListKeys");
            scope.Start();
            try
            {
                return await RestClient.ListKeysAsync(resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ListNotebookKeysResult> ListKeys(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NotebooksOperations.ListKeys");
            scope.Start();
            try
            {
                return RestClient.ListKeys(resourceGroupName, workspaceName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public virtual async Task<NotebooksPrepareOperation> StartPrepareAsync(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebooksOperations.StartPrepare");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.PrepareAsync(resourceGroupName, workspaceName, cancellationToken).ConfigureAwait(false);
                return new NotebooksPrepareOperation(_clientDiagnostics, _pipeline, RestClient.CreatePrepareRequest(resourceGroupName, workspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <param name="resourceGroupName"> Name of the resource group in which workspace is located. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="workspaceName"/> is null. </exception>
        public virtual NotebooksPrepareOperation StartPrepare(string resourceGroupName, string workspaceName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }

            using var scope = _clientDiagnostics.CreateScope("NotebooksOperations.StartPrepare");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Prepare(resourceGroupName, workspaceName, cancellationToken);
                return new NotebooksPrepareOperation(_clientDiagnostics, _pipeline, RestClient.CreatePrepareRequest(resourceGroupName, workspaceName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
