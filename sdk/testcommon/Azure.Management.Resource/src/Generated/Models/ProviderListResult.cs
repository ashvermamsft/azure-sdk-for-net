// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resource.Models
{
    /// <summary> List of resource providers. </summary>
    public partial class ProviderListResult
    {
        /// <summary> Initializes a new instance of ProviderListResult. </summary>
        internal ProviderListResult()
        {
        }

        /// <summary> Initializes a new instance of ProviderListResult. </summary>
        /// <param name="value"> The list of resource providers. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal ProviderListResult(IReadOnlyList<Provider> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of resource providers. </summary>
        public IReadOnlyList<Provider> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
