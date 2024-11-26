// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class IotHubDeviceTelemetryEventData : IUtf8JsonSerializable, IJsonModel<IotHubDeviceTelemetryEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubDeviceTelemetryEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubDeviceTelemetryEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceTelemetryEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubDeviceTelemetryEventData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        IotHubDeviceTelemetryEventData IJsonModel<IotHubDeviceTelemetryEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceTelemetryEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubDeviceTelemetryEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubDeviceTelemetryEventData(document.RootElement, options);
        }

        internal static IotHubDeviceTelemetryEventData DeserializeIotHubDeviceTelemetryEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, BinaryData> body = default;
            IReadOnlyDictionary<string, string> properties = default;
            IReadOnlyDictionary<string, string> systemProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("body"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    body = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("systemProperties"u8))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    systemProperties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubDeviceTelemetryEventData(body, properties, systemProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubDeviceTelemetryEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceTelemetryEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubDeviceTelemetryEventData)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubDeviceTelemetryEventData IPersistableModel<IotHubDeviceTelemetryEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubDeviceTelemetryEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubDeviceTelemetryEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubDeviceTelemetryEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubDeviceTelemetryEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new IotHubDeviceTelemetryEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeIotHubDeviceTelemetryEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
