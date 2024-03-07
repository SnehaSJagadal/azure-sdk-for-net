// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class UnknownIntegrationRuntimeStatus : IUtf8JsonSerializable, IJsonModel<SynapseIntegrationRuntimeStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SynapseIntegrationRuntimeStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SynapseIntegrationRuntimeStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuntimeType.ToString());
            if (options.Format != "W" && Optional.IsDefined(DataFactoryName))
            {
                writer.WritePropertyName("dataFactoryName"u8);
                writer.WriteStringValue(DataFactoryName);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SynapseIntegrationRuntimeStatus IJsonModel<SynapseIntegrationRuntimeStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseIntegrationRuntimeStatus(document.RootElement, options);
        }

        internal static UnknownIntegrationRuntimeStatus DeserializeUnknownIntegrationRuntimeStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = "Unknown";
            string dataFactoryName = default;
            SynapseIntegrationRuntimeState? state = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SynapseIntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownIntegrationRuntimeStatus(type, dataFactoryName, state, additionalProperties);
        }

        BinaryData IPersistableModel<SynapseIntegrationRuntimeStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        SynapseIntegrationRuntimeStatus IPersistableModel<SynapseIntegrationRuntimeStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SynapseIntegrationRuntimeStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSynapseIntegrationRuntimeStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SynapseIntegrationRuntimeStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SynapseIntegrationRuntimeStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
