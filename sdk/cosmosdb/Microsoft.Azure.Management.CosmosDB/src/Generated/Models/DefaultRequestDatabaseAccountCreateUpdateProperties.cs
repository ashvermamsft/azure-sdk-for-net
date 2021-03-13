// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties for non-restore Azure Cosmos DB database account requests.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Default")]
    public partial class DefaultRequestDatabaseAccountCreateUpdateProperties : DatabaseAccountCreateUpdateProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DefaultRequestDatabaseAccountCreateUpdateProperties class.
        /// </summary>
        public DefaultRequestDatabaseAccountCreateUpdateProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DefaultRequestDatabaseAccountCreateUpdateProperties class.
        /// </summary>
        /// <param name="locations">An array that contains the georeplication
        /// locations enabled for the Cosmos DB account.</param>
        /// <param name="consistencyPolicy">The consistency policy for the
        /// Cosmos DB account.</param>
        /// <param name="ipRules">List of IpRules.</param>
        /// <param name="isVirtualNetworkFilterEnabled">Flag to indicate
        /// whether to enable/disable Virtual Network ACL rules.</param>
        /// <param name="enableAutomaticFailover">Enables automatic failover of
        /// the write region in the rare event that the region is unavailable
        /// due to an outage. Automatic failover will result in a new write
        /// region for the account and is chosen based on the failover
        /// priorities configured for the account.</param>
        /// <param name="capabilities">List of Cosmos DB capabilities for the
        /// account</param>
        /// <param name="virtualNetworkRules">List of Virtual Network ACL rules
        /// configured for the Cosmos DB account.</param>
        /// <param name="enableMultipleWriteLocations">Enables the account to
        /// write in multiple locations</param>
        /// <param name="enableCassandraConnector">Enables the cassandra
        /// connector on the Cosmos DB C* account</param>
        /// <param name="connectorOffer">The cassandra connector offer type for
        /// the Cosmos DB database C* account. Possible values include:
        /// 'Small'</param>
        /// <param name="disableKeyBasedMetadataWriteAccess">Disable write
        /// operations on metadata resources (databases, containers,
        /// throughput) via account keys</param>
        /// <param name="keyVaultKeyUri">The URI of the key vault</param>
        /// <param name="publicNetworkAccess">Whether requests from Public
        /// Network are allowed. Possible values include: 'Enabled',
        /// 'Disabled'</param>
        /// <param name="enableFreeTier">Flag to indicate whether Free Tier is
        /// enabled.</param>
        /// <param name="apiProperties">API specific properties. Currently,
        /// supported only for MongoDB API.</param>
        /// <param name="enableAnalyticalStorage">Flag to indicate whether to
        /// enable storage analytics.</param>
        /// <param name="backupPolicy">The object representing the policy for
        /// taking backups on an account.</param>
        /// <param name="cors">The CORS policy for the Cosmos DB database
        /// account.</param>
        /// <param name="networkAclBypass">Indicates what services are allowed
        /// to bypass firewall checks. Possible values include: 'None',
        /// 'AzureServices'</param>
        /// <param name="networkAclBypassResourceIds">An array that contains
        /// the Resource Ids for Network Acl Bypass for the Cosmos DB
        /// account.</param>
        public DefaultRequestDatabaseAccountCreateUpdateProperties(IList<Location> locations, ConsistencyPolicy consistencyPolicy = default(ConsistencyPolicy), IList<IpAddressOrRange> ipRules = default(IList<IpAddressOrRange>), bool? isVirtualNetworkFilterEnabled = default(bool?), bool? enableAutomaticFailover = default(bool?), IList<Capability> capabilities = default(IList<Capability>), IList<VirtualNetworkRule> virtualNetworkRules = default(IList<VirtualNetworkRule>), bool? enableMultipleWriteLocations = default(bool?), bool? enableCassandraConnector = default(bool?), string connectorOffer = default(string), bool? disableKeyBasedMetadataWriteAccess = default(bool?), string keyVaultKeyUri = default(string), string publicNetworkAccess = default(string), bool? enableFreeTier = default(bool?), ApiProperties apiProperties = default(ApiProperties), bool? enableAnalyticalStorage = default(bool?), BackupPolicy backupPolicy = default(BackupPolicy), IList<CorsPolicy> cors = default(IList<CorsPolicy>), NetworkAclBypass? networkAclBypass = default(NetworkAclBypass?), IList<string> networkAclBypassResourceIds = default(IList<string>))
            : base(locations, consistencyPolicy, ipRules, isVirtualNetworkFilterEnabled, enableAutomaticFailover, capabilities, virtualNetworkRules, enableMultipleWriteLocations, enableCassandraConnector, connectorOffer, disableKeyBasedMetadataWriteAccess, keyVaultKeyUri, publicNetworkAccess, enableFreeTier, apiProperties, enableAnalyticalStorage, backupPolicy, cors, networkAclBypass, networkAclBypassResourceIds)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
