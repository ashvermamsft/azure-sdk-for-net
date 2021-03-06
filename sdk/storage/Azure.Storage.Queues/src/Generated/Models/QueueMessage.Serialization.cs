// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Xml;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    public partial class QueueMessage : IXmlSerializable
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "QueueMessage");
            writer.WriteStartElement("MessageText");
            writer.WriteValue(MessageText);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
