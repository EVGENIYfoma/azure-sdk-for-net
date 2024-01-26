// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobStepExecutionOptions : IUtf8JsonSerializable, IJsonModel<JobStepExecutionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobStepExecutionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobStepExecutionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepExecutionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStepExecutionOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TimeoutSeconds))
            {
                writer.WritePropertyName("timeoutSeconds"u8);
                writer.WriteNumberValue(TimeoutSeconds.Value);
            }
            if (Optional.IsDefined(RetryAttempts))
            {
                writer.WritePropertyName("retryAttempts"u8);
                writer.WriteNumberValue(RetryAttempts.Value);
            }
            if (Optional.IsDefined(InitialRetryIntervalSeconds))
            {
                writer.WritePropertyName("initialRetryIntervalSeconds"u8);
                writer.WriteNumberValue(InitialRetryIntervalSeconds.Value);
            }
            if (Optional.IsDefined(MaximumRetryIntervalSeconds))
            {
                writer.WritePropertyName("maximumRetryIntervalSeconds"u8);
                writer.WriteNumberValue(MaximumRetryIntervalSeconds.Value);
            }
            if (Optional.IsDefined(RetryIntervalBackoffMultiplier))
            {
                writer.WritePropertyName("retryIntervalBackoffMultiplier"u8);
                writer.WriteNumberValue(RetryIntervalBackoffMultiplier.Value);
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

        JobStepExecutionOptions IJsonModel<JobStepExecutionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepExecutionOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStepExecutionOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobStepExecutionOptions(document.RootElement, options);
        }

        internal static JobStepExecutionOptions DeserializeJobStepExecutionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> timeoutSeconds = default;
            Optional<int> retryAttempts = default;
            Optional<int> initialRetryIntervalSeconds = default;
            Optional<int> maximumRetryIntervalSeconds = default;
            Optional<float> retryIntervalBackoffMultiplier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("retryAttempts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryAttempts = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialRetryIntervalSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initialRetryIntervalSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumRetryIntervalSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumRetryIntervalSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("retryIntervalBackoffMultiplier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryIntervalBackoffMultiplier = property.Value.GetSingle();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JobStepExecutionOptions(Optional.ToNullable(timeoutSeconds), Optional.ToNullable(retryAttempts), Optional.ToNullable(initialRetryIntervalSeconds), Optional.ToNullable(maximumRetryIntervalSeconds), Optional.ToNullable(retryIntervalBackoffMultiplier), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JobStepExecutionOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepExecutionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JobStepExecutionOptions)} does not support '{options.Format}' format.");
            }
        }

        JobStepExecutionOptions IPersistableModel<JobStepExecutionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepExecutionOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobStepExecutionOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobStepExecutionOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobStepExecutionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
