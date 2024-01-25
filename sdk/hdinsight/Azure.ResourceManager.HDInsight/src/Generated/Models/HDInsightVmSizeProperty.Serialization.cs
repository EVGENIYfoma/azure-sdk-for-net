// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightVmSizeProperty : IUtf8JsonSerializable, IJsonModel<HDInsightVmSizeProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightVmSizeProperty>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightVmSizeProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightVmSizeProperty)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Cores))
            {
                writer.WritePropertyName("cores"u8);
                writer.WriteNumberValue(Cores.Value);
            }
            if (Optional.IsDefined(DataDiskStorageTier))
            {
                writer.WritePropertyName("dataDiskStorageTier"u8);
                writer.WriteStringValue(DataDiskStorageTier);
            }
            if (Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            if (Optional.IsDefined(MaxDataDiskCount))
            {
                writer.WritePropertyName("maxDataDiskCount"u8);
                writer.WriteNumberValue(MaxDataDiskCount.Value);
            }
            if (Optional.IsDefined(MemoryInMB))
            {
                writer.WritePropertyName("memoryInMb"u8);
                writer.WriteNumberValue(MemoryInMB.Value);
            }
            if (Optional.IsDefined(IsSupportedByVirtualMachines))
            {
                writer.WritePropertyName("supportedByVirtualMachines"u8);
                writer.WriteBooleanValue(IsSupportedByVirtualMachines.Value);
            }
            if (Optional.IsDefined(IsSupportedByWebWorkerRoles))
            {
                writer.WritePropertyName("supportedByWebWorkerRoles"u8);
                writer.WriteBooleanValue(IsSupportedByWebWorkerRoles.Value);
            }
            if (Optional.IsDefined(VirtualMachineResourceDiskSizeInMB))
            {
                writer.WritePropertyName("virtualMachineResourceDiskSizeInMb"u8);
                writer.WriteNumberValue(VirtualMachineResourceDiskSizeInMB.Value);
            }
            if (Optional.IsDefined(WebWorkerResourceDiskSizeInMB))
            {
                writer.WritePropertyName("webWorkerResourceDiskSizeInMb"u8);
                writer.WriteNumberValue(WebWorkerResourceDiskSizeInMB.Value);
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

        HDInsightVmSizeProperty IJsonModel<HDInsightVmSizeProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeProperty>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightVmSizeProperty)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightVmSizeProperty(document.RootElement, options);
        }

        internal static HDInsightVmSizeProperty DeserializeHDInsightVmSizeProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> cores = default;
            Optional<string> dataDiskStorageTier = default;
            Optional<string> label = default;
            Optional<long> maxDataDiskCount = default;
            Optional<long> memoryInMB = default;
            Optional<bool> supportedByVirtualMachines = default;
            Optional<bool> supportedByWebWorkerRoles = default;
            Optional<long> virtualMachineResourceDiskSizeInMB = default;
            Optional<long> webWorkerResourceDiskSizeInMB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dataDiskStorageTier"u8))
                {
                    dataDiskStorageTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDataDiskCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDataDiskCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("memoryInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedByVirtualMachines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedByVirtualMachines = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedByWebWorkerRoles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedByWebWorkerRoles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualMachineResourceDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineResourceDiskSizeInMB = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("webWorkerResourceDiskSizeInMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    webWorkerResourceDiskSizeInMB = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightVmSizeProperty(name.Value, Optional.ToNullable(cores), dataDiskStorageTier.Value, label.Value, Optional.ToNullable(maxDataDiskCount), Optional.ToNullable(memoryInMB), Optional.ToNullable(supportedByVirtualMachines), Optional.ToNullable(supportedByWebWorkerRoles), Optional.ToNullable(virtualMachineResourceDiskSizeInMB), Optional.ToNullable(webWorkerResourceDiskSizeInMB), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightVmSizeProperty>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightVmSizeProperty)} does not support '{options.Format}' format.");
            }
        }

        HDInsightVmSizeProperty IPersistableModel<HDInsightVmSizeProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightVmSizeProperty>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightVmSizeProperty(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightVmSizeProperty)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightVmSizeProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
