// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class ThroughputSettingsResourceInfo : IUtf8JsonSerializable, IJsonModel<ThroughputSettingsResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThroughputSettingsResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThroughputSettingsResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThroughputSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThroughputSettingsResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Throughput))
            {
                writer.WritePropertyName("throughput"u8);
                writer.WriteNumberValue(Throughput.Value);
            }
            if (Optional.IsDefined(AutoscaleSettings))
            {
                writer.WritePropertyName("autoscaleSettings"u8);
                writer.WriteObjectValue(AutoscaleSettings);
            }
            if (options.Format != "W" && Optional.IsDefined(MinimumThroughput))
            {
                writer.WritePropertyName("minimumThroughput"u8);
                writer.WriteStringValue(MinimumThroughput);
            }
            if (options.Format != "W" && Optional.IsDefined(OfferReplacePending))
            {
                writer.WritePropertyName("offerReplacePending"u8);
                writer.WriteStringValue(OfferReplacePending);
            }
            if (options.Format != "W" && Optional.IsDefined(InstantMaximumThroughput))
            {
                writer.WritePropertyName("instantMaximumThroughput"u8);
                writer.WriteStringValue(InstantMaximumThroughput);
            }
            if (options.Format != "W" && Optional.IsDefined(SoftAllowedMaximumThroughput))
            {
                writer.WritePropertyName("softAllowedMaximumThroughput"u8);
                writer.WriteStringValue(SoftAllowedMaximumThroughput);
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

        ThroughputSettingsResourceInfo IJsonModel<ThroughputSettingsResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThroughputSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThroughputSettingsResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThroughputSettingsResourceInfo(document.RootElement, options);
        }

        internal static ThroughputSettingsResourceInfo DeserializeThroughputSettingsResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> throughput = default;
            Optional<AutoscaleSettingsResourceInfo> autoscaleSettings = default;
            Optional<string> minimumThroughput = default;
            Optional<string> offerReplacePending = default;
            Optional<string> instantMaximumThroughput = default;
            Optional<string> softAllowedMaximumThroughput = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("throughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoscaleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoscaleSettings = AutoscaleSettingsResourceInfo.DeserializeAutoscaleSettingsResourceInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("minimumThroughput"u8))
                {
                    minimumThroughput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerReplacePending"u8))
                {
                    offerReplacePending = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instantMaximumThroughput"u8))
                {
                    instantMaximumThroughput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("softAllowedMaximumThroughput"u8))
                {
                    softAllowedMaximumThroughput = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThroughputSettingsResourceInfo(Optional.ToNullable(throughput), autoscaleSettings.Value, minimumThroughput.Value, offerReplacePending.Value, instantMaximumThroughput.Value, softAllowedMaximumThroughput.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThroughputSettingsResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThroughputSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThroughputSettingsResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        ThroughputSettingsResourceInfo IPersistableModel<ThroughputSettingsResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThroughputSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThroughputSettingsResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThroughputSettingsResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThroughputSettingsResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
