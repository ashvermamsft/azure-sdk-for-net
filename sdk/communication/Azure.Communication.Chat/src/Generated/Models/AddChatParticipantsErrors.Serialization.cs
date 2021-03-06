// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Chat
{
    public partial class AddChatParticipantsErrors
    {
        internal static AddChatParticipantsErrors DeserializeAddChatParticipantsErrors(JsonElement element)
        {
            IReadOnlyList<CommunicationError> invalidParticipants = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("invalidParticipants"))
                {
                    List<CommunicationError> array = new List<CommunicationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(CommunicationError.DeserializeCommunicationError(item));
                        }
                    }
                    invalidParticipants = array;
                    continue;
                }
            }
            return new AddChatParticipantsErrors(invalidParticipants);
        }
    }
}
