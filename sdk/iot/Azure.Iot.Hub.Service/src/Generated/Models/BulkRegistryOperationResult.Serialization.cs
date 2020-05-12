// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class BulkRegistryOperationResult
    {
        internal static BulkRegistryOperationResult DeserializeBulkRegistryOperationResult(JsonElement element)
        {
            bool? isSuccessful = default;
            IReadOnlyList<DeviceRegistryOperationError> errors = default;
            IReadOnlyList<DeviceRegistryOperationWarning> warnings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSuccessful"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSuccessful = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryOperationError> array = new List<DeviceRegistryOperationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DeviceRegistryOperationError.DeserializeDeviceRegistryOperationError(item));
                        }
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceRegistryOperationWarning> array = new List<DeviceRegistryOperationWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(DeviceRegistryOperationWarning.DeserializeDeviceRegistryOperationWarning(item));
                        }
                    }
                    warnings = array;
                    continue;
                }
            }
            return new BulkRegistryOperationResult(isSuccessful, errors, warnings);
        }
    }
}