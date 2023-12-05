// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class GuestAgentInstallStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static GuestAgentInstallStatus DeserializeGuestAgentInstallStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vmUuid = default;
            Optional<StatusType> status = default;
            Optional<DateTimeOffset> lastStatusChange = default;
            Optional<string> agentVersion = default;
            Optional<IReadOnlyList<ResponseError>> errorDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vmUuid"u8))
                {
                    vmUuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new StatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStatusChange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStatusChange = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResponseError> array = new List<ResponseError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<ResponseError>(item.GetRawText()));
                    }
                    errorDetails = array;
                    continue;
                }
            }
            return new GuestAgentInstallStatus(vmUuid.Value, Optional.ToNullable(status), Optional.ToNullable(lastStatusChange), agentVersion.Value, Optional.ToList(errorDetails));
        }
    }
}
