// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFlowTransformation : IUtf8JsonSerializable, IJsonModel<DataFlowTransformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFlowTransformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFlowTransformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowTransformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlowTransformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteObjectValue(Dataset);
            }
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                JsonSerializer.Serialize(writer, LinkedService);
            }
            if (Optional.IsDefined(Flowlet))
            {
                writer.WritePropertyName("flowlet"u8);
                writer.WriteObjectValue(Flowlet);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        DataFlowTransformation IJsonModel<DataFlowTransformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowTransformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlowTransformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowTransformation(document.RootElement, options);
        }

        internal static DataFlowTransformation DeserializeDataFlowTransformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            Optional<DatasetReference> dataset = default;
            Optional<DataFactoryLinkedServiceReference> linkedService = default;
            Optional<DataFlowReference> flowlet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataset = DatasetReference.DeserializeDatasetReference(property.Value);
                    continue;
                }
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("flowlet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flowlet = DataFlowReference.DeserializeDataFlowReference(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFlowTransformation(name, description.Value, dataset.Value, linkedService, flowlet.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFlowTransformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowTransformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFlowTransformation)} does not support '{options.Format}' format.");
            }
        }

        DataFlowTransformation IPersistableModel<DataFlowTransformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowTransformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFlowTransformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFlowTransformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFlowTransformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
