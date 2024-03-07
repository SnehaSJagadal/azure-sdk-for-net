// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.StorageCache;

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class StorageCacheUsageModel : IUtf8JsonSerializable, IJsonModel<StorageCacheUsageModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageCacheUsageModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageCacheUsageModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsageModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheUsageModel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Display))
            {
                writer.WritePropertyName("display"u8);
                writer.WriteObjectValue(Display);
            }
            if (Optional.IsDefined(ModelName))
            {
                writer.WritePropertyName("modelName"u8);
                writer.WriteStringValue(ModelName);
            }
            if (Optional.IsDefined(TargetType))
            {
                writer.WritePropertyName("targetType"u8);
                writer.WriteStringValue(TargetType);
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

        StorageCacheUsageModel IJsonModel<StorageCacheUsageModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsageModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageCacheUsageModel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageCacheUsageModel(document.RootElement, options);
        }

        internal static StorageCacheUsageModel DeserializeStorageCacheUsageModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageCacheUsageModelDisplay display = default;
            string modelName = default;
            string targetType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("display"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    display = StorageCacheUsageModelDisplay.DeserializeStorageCacheUsageModelDisplay(property.Value, options);
                    continue;
                }
                if (property.NameEquals("modelName"u8))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetType"u8))
                {
                    targetType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageCacheUsageModel(display, modelName, targetType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageCacheUsageModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsageModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageCacheUsageModel)} does not support '{options.Format}' format.");
            }
        }

        StorageCacheUsageModel IPersistableModel<StorageCacheUsageModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageCacheUsageModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageCacheUsageModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageCacheUsageModel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageCacheUsageModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
