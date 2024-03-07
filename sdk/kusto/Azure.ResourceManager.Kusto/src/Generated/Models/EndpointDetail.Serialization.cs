// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class EndpointDetail : IUtf8JsonSerializable, IJsonModel<EndpointDetail>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EndpointDetail>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EndpointDetail>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointDetail)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Port))
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
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

        EndpointDetail IJsonModel<EndpointDetail>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDetail>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EndpointDetail)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEndpointDetail(document.RootElement, options);
        }

        internal static EndpointDetail DeserializeEndpointDetail(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? port = default;
            string ipAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EndpointDetail(port, ipAddress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EndpointDetail>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EndpointDetail)} does not support '{options.Format}' format.");
            }
        }

        EndpointDetail IPersistableModel<EndpointDetail>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EndpointDetail>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEndpointDetail(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EndpointDetail)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EndpointDetail>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
