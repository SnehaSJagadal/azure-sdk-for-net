// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBox;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class AvailableSkusContent : IUtf8JsonSerializable, IJsonModel<AvailableSkusContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailableSkusContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailableSkusContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableSkusContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableSkusContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("transferType"u8);
            writer.WriteStringValue(TransferType.ToSerialString());
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(SkuNames))
            {
                writer.WritePropertyName("skuNames"u8);
                writer.WriteStartArray();
                foreach (var item in SkuNames)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
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

        AvailableSkusContent IJsonModel<AvailableSkusContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableSkusContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailableSkusContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailableSkusContent(document.RootElement, options);
        }

        internal static AvailableSkusContent DeserializeAvailableSkusContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxJobTransferType transferType = default;
            string country = default;
            AzureLocation location = default;
            IList<DataBoxSkuName> skuNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transferType"u8))
                {
                    transferType = property.Value.GetString().ToDataBoxJobTransferType();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("skuNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxSkuName> array = new List<DataBoxSkuName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDataBoxSkuName());
                    }
                    skuNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailableSkusContent(transferType, country, location, skuNames ?? new ChangeTrackingList<DataBoxSkuName>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailableSkusContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableSkusContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailableSkusContent)} does not support '{options.Format}' format.");
            }
        }

        AvailableSkusContent IPersistableModel<AvailableSkusContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailableSkusContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailableSkusContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailableSkusContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailableSkusContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
