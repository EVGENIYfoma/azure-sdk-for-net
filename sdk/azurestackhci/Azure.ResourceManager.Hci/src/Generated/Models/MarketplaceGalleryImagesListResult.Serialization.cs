// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class MarketplaceGalleryImagesListResult
    {
        internal static MarketplaceGalleryImagesListResult DeserializeMarketplaceGalleryImagesListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MarketplaceGalleryImageData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MarketplaceGalleryImageData> array = new List<MarketplaceGalleryImageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarketplaceGalleryImageData.DeserializeMarketplaceGalleryImageData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MarketplaceGalleryImagesListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
