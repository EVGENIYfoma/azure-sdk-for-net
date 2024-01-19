// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Messages
{
    public partial class MessageTemplateImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("url"u8);
            writer.WriteStringValue(Uri.AbsoluteUri);
            if (Optional.IsDefined(Caption))
            {
                writer.WritePropertyName("caption"u8);
                writer.WriteStringValue(Caption);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
