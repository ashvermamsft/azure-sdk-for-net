// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    internal partial class MongoDBDatabaseListResult
    {
        internal static MongoDBDatabaseListResult DeserializeMongoDBDatabaseListResult(JsonElement element)
        {
            Optional<IReadOnlyList<MongoDBDatabaseGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<MongoDBDatabaseGetResults> array = new List<MongoDBDatabaseGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBDatabaseGetResults.DeserializeMongoDBDatabaseGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MongoDBDatabaseListResult(Optional.ToList(value));
        }
    }
}
