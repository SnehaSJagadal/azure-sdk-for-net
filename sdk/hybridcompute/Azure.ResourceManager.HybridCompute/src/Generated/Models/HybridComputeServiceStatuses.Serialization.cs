// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridCompute;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class HybridComputeServiceStatuses : IUtf8JsonSerializable, IJsonModel<HybridComputeServiceStatuses>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HybridComputeServiceStatuses>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HybridComputeServiceStatuses>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeServiceStatuses>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeServiceStatuses)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtensionService))
            {
                writer.WritePropertyName("extensionService"u8);
                writer.WriteObjectValue(ExtensionService);
            }
            if (Optional.IsDefined(GuestConfigurationService))
            {
                writer.WritePropertyName("guestConfigurationService"u8);
                writer.WriteObjectValue(GuestConfigurationService);
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

        HybridComputeServiceStatuses IJsonModel<HybridComputeServiceStatuses>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeServiceStatuses>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HybridComputeServiceStatuses)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHybridComputeServiceStatuses(document.RootElement, options);
        }

        internal static HybridComputeServiceStatuses DeserializeHybridComputeServiceStatuses(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HybridComputeServiceStatus extensionService = default;
            HybridComputeServiceStatus guestConfigurationService = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extensionService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extensionService = HybridComputeServiceStatus.DeserializeHybridComputeServiceStatus(property.Value, options);
                    continue;
                }
                if (property.NameEquals("guestConfigurationService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    guestConfigurationService = HybridComputeServiceStatus.DeserializeHybridComputeServiceStatus(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HybridComputeServiceStatuses(extensionService, guestConfigurationService, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HybridComputeServiceStatuses>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeServiceStatuses>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HybridComputeServiceStatuses)} does not support '{options.Format}' format.");
            }
        }

        HybridComputeServiceStatuses IPersistableModel<HybridComputeServiceStatuses>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HybridComputeServiceStatuses>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHybridComputeServiceStatuses(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HybridComputeServiceStatuses)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HybridComputeServiceStatuses>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
