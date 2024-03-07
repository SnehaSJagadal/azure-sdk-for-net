// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Monitor;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class MonitorPrivateLinkScopeOperationStatus : IUtf8JsonSerializable, IJsonModel<MonitorPrivateLinkScopeOperationStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MonitorPrivateLinkScopeOperationStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MonitorPrivateLinkScopeOperationStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkScopeOperationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkScopeOperationStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(StartOn))
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(EndOn))
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Error))
            {
                if (Error != null)
                {
                    writer.WritePropertyName("error"u8);
                    JsonSerializer.Serialize(writer, Error);
                }
                else
                {
                    writer.WriteNull("error");
                }
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

        MonitorPrivateLinkScopeOperationStatus IJsonModel<MonitorPrivateLinkScopeOperationStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkScopeOperationStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MonitorPrivateLinkScopeOperationStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMonitorPrivateLinkScopeOperationStatus(document.RootElement, options);
        }

        internal static MonitorPrivateLinkScopeOperationStatus DeserializeMonitorPrivateLinkScopeOperationStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string name = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            string status = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        error = null;
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MonitorPrivateLinkScopeOperationStatus(
                id,
                name,
                startTime,
                endTime,
                status,
                error,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MonitorPrivateLinkScopeOperationStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkScopeOperationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MonitorPrivateLinkScopeOperationStatus)} does not support '{options.Format}' format.");
            }
        }

        MonitorPrivateLinkScopeOperationStatus IPersistableModel<MonitorPrivateLinkScopeOperationStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MonitorPrivateLinkScopeOperationStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMonitorPrivateLinkScopeOperationStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MonitorPrivateLinkScopeOperationStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MonitorPrivateLinkScopeOperationStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
