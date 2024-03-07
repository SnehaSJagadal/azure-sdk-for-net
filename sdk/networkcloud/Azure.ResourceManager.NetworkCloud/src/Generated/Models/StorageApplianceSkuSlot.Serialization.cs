// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class StorageApplianceSkuSlot : IUtf8JsonSerializable, IJsonModel<StorageApplianceSkuSlot>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageApplianceSkuSlot>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageApplianceSkuSlot>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceSkuSlot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageApplianceSkuSlot)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(RackSlot))
            {
                writer.WritePropertyName("rackSlot"u8);
                writer.WriteNumberValue(RackSlot.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(CapacityGB))
            {
                writer.WritePropertyName("capacityGB"u8);
                writer.WriteNumberValue(CapacityGB.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            writer.WriteEndObject();
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

        StorageApplianceSkuSlot IJsonModel<StorageApplianceSkuSlot>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceSkuSlot>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageApplianceSkuSlot)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageApplianceSkuSlot(document.RootElement, options);
        }

        internal static StorageApplianceSkuSlot DeserializeStorageApplianceSkuSlot(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long? rackSlot = default;
            long? capacityGB = default;
            string model = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rackSlot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rackSlot = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("capacityGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacityGB = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("model"u8))
                        {
                            model = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageApplianceSkuSlot(rackSlot, capacityGB, model, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageApplianceSkuSlot>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceSkuSlot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageApplianceSkuSlot)} does not support '{options.Format}' format.");
            }
        }

        StorageApplianceSkuSlot IPersistableModel<StorageApplianceSkuSlot>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageApplianceSkuSlot>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageApplianceSkuSlot(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageApplianceSkuSlot)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageApplianceSkuSlot>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
