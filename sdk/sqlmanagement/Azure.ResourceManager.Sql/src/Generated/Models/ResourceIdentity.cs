// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Azure Active Directory identity configuration for a resource. </summary>
    public partial class ResourceIdentity
    {
        /// <summary> Initializes a new instance of ResourceIdentity. </summary>
        public ResourceIdentity()
        {
        }

        /// <summary> Initializes a new instance of ResourceIdentity. </summary>
        /// <param name="principalId"> The Azure Active Directory principal id. </param>
        /// <param name="type"> The identity type. Set this to &apos;SystemAssigned&apos; in order to automatically create and assign an Azure Active Directory principal for the resource. </param>
        /// <param name="tenantId"> The Azure Active Directory tenant id. </param>
        internal ResourceIdentity(Guid? principalId, IdentityType? type, Guid? tenantId)
        {
            PrincipalId = principalId;
            Type = type;
            TenantId = tenantId;
        }

        /// <summary> The Azure Active Directory principal id. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The identity type. Set this to &apos;SystemAssigned&apos; in order to automatically create and assign an Azure Active Directory principal for the resource. </summary>
        public IdentityType? Type { get; set; }
        /// <summary> The Azure Active Directory tenant id. </summary>
        public Guid? TenantId { get; }
    }
}