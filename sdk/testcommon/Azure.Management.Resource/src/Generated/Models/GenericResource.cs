// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Resource.Models
{
    /// <summary> Resource information. </summary>
    public partial class GenericResource : Resource
    {
        /// <summary> Initializes a new instance of GenericResource. </summary>
        public GenericResource()
        {
        }

        /// <summary> Initializes a new instance of GenericResource. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="plan"> The plan of the resource. </param>
        /// <param name="properties"> The resource properties. </param>
        /// <param name="kind"> The kind of the resource. </param>
        /// <param name="managedBy"> Id of the resource that manages this resource. </param>
        /// <param name="sku"> The sku of the resource. </param>
        /// <param name="identity"> The identity of the resource. </param>
        internal GenericResource(string id, string name, string type, string location, IDictionary<string, string> tags, Plan plan, object properties, string kind, string managedBy, Sku sku, Identity identity) : base(id, name, type, location, tags)
        {
            Plan = plan;
            Properties = properties;
            Kind = kind;
            ManagedBy = managedBy;
            Sku = sku;
            Identity = identity;
        }

        /// <summary> The plan of the resource. </summary>
        public Plan Plan { get; set; }
        /// <summary> The resource properties. </summary>
        public object Properties { get; set; }
        /// <summary> The kind of the resource. </summary>
        public string Kind { get; set; }
        /// <summary> Id of the resource that manages this resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> The sku of the resource. </summary>
        public Sku Sku { get; set; }
        /// <summary> The identity of the resource. </summary>
        public Identity Identity { get; set; }
    }
}
