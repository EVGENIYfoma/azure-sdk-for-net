// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.Messages
{
    internal partial class WhatsAppMessageTemplateResponse
    {
        internal static WhatsAppMessageTemplateResponse DeserializeWhatsAppMessageTemplateResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> content = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    content = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new WhatsAppMessageTemplateResponse(content.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static WhatsAppMessageTemplateResponse FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeWhatsAppMessageTemplateResponse(document.RootElement);
        }
    }
}
