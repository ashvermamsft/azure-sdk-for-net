// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadEventInThreadBasePropertiesConverter))]
    public partial class AcsChatThreadEventInThreadBaseProperties
    {
        internal static AcsChatThreadEventInThreadBaseProperties DeserializeAcsChatThreadEventInThreadBaseProperties(JsonElement element)
        {
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadEventInThreadBaseProperties(threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version));
        }

        internal partial class AcsChatThreadEventInThreadBasePropertiesConverter : JsonConverter<AcsChatThreadEventInThreadBaseProperties>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadEventInThreadBaseProperties model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatThreadEventInThreadBaseProperties Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadEventInThreadBaseProperties(document.RootElement);
            }
        }
    }
}
