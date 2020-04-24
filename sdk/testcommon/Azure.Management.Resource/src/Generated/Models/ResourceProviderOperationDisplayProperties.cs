// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Resource.Models
{
    /// <summary> Resource provider operation&apos;s display properties. </summary>
    public partial class ResourceProviderOperationDisplayProperties
    {
        /// <summary> Initializes a new instance of ResourceProviderOperationDisplayProperties. </summary>
        internal ResourceProviderOperationDisplayProperties()
        {
        }

        /// <summary> Initializes a new instance of ResourceProviderOperationDisplayProperties. </summary>
        /// <param name="publisher"> Operation description. </param>
        /// <param name="provider"> Operation provider. </param>
        /// <param name="resource"> Operation resource. </param>
        /// <param name="operation"> Operation. </param>
        /// <param name="description"> Operation description. </param>
        internal ResourceProviderOperationDisplayProperties(string publisher, string provider, string resource, string operation, string description)
        {
            Publisher = publisher;
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> Operation description. </summary>
        public string Publisher { get; }
        /// <summary> Operation provider. </summary>
        public string Provider { get; }
        /// <summary> Operation resource. </summary>
        public string Resource { get; }
        /// <summary> Operation. </summary>
        public string Operation { get; }
        /// <summary> Operation description. </summary>
        public string Description { get; }
    }
}
