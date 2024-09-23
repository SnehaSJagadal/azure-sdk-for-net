// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetComputeProfile : IUtf8JsonSerializable, IJsonModel<ComputeFleetComputeProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetComputeProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetComputeProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetComputeProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetComputeProfile)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("baseVirtualMachineProfile"u8);
            writer.WriteObjectValue(BaseVirtualMachineProfile, options);
            if (Optional.IsDefined(ComputeApiVersion))
            {
                writer.WritePropertyName("computeApiVersion"u8);
                writer.WriteStringValue(ComputeApiVersion);
            }
            if (Optional.IsDefined(PlatformFaultDomainCount))
            {
                writer.WritePropertyName("platformFaultDomainCount"u8);
                writer.WriteNumberValue(PlatformFaultDomainCount.Value);
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

        ComputeFleetComputeProfile IJsonModel<ComputeFleetComputeProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetComputeProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetComputeProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetComputeProfile(document.RootElement, options);
        }

        internal static ComputeFleetComputeProfile DeserializeComputeFleetComputeProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ComputeFleetVmProfile baseVirtualMachineProfile = default;
            string computeApiVersion = default;
            int? platformFaultDomainCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseVirtualMachineProfile"u8))
                {
                    baseVirtualMachineProfile = ComputeFleetVmProfile.DeserializeComputeFleetVmProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("computeApiVersion"u8))
                {
                    computeApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("platformFaultDomainCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    platformFaultDomainCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetComputeProfile(baseVirtualMachineProfile, computeApiVersion, platformFaultDomainCount, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetComputeProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetComputeProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetComputeProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetComputeProfile IPersistableModel<ComputeFleetComputeProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetComputeProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeFleetComputeProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetComputeProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetComputeProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
