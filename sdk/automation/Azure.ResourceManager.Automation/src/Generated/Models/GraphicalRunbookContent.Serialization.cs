// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class GraphicalRunbookContent : IUtf8JsonSerializable, IJsonModel<GraphicalRunbookContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GraphicalRunbookContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GraphicalRunbookContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GraphicalRunbookContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RawContent))
            {
                if (RawContent != null)
                {
                    writer.WritePropertyName("rawContent"u8);
                    writer.WriteObjectValue(RawContent);
                }
                else
                {
                    writer.WriteNull("rawContent");
                }
            }
            if (Optional.IsDefined(GraphRunbookJson))
            {
                if (GraphRunbookJson != null)
                {
                    writer.WritePropertyName("graphRunbookJson"u8);
                    writer.WriteStringValue(GraphRunbookJson);
                }
                else
                {
                    writer.WriteNull("graphRunbookJson");
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

        GraphicalRunbookContent IJsonModel<GraphicalRunbookContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GraphicalRunbookContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGraphicalRunbookContent(document.RootElement, options);
        }

        internal static GraphicalRunbookContent DeserializeGraphicalRunbookContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RawGraphicalRunbookContent rawContent = default;
            string graphRunbookJson = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rawContent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        rawContent = null;
                        continue;
                    }
                    rawContent = RawGraphicalRunbookContent.DeserializeRawGraphicalRunbookContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("graphRunbookJson"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        graphRunbookJson = null;
                        continue;
                    }
                    graphRunbookJson = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GraphicalRunbookContent(rawContent, graphRunbookJson, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GraphicalRunbookContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GraphicalRunbookContent)} does not support '{options.Format}' format.");
            }
        }

        GraphicalRunbookContent IPersistableModel<GraphicalRunbookContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GraphicalRunbookContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGraphicalRunbookContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GraphicalRunbookContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GraphicalRunbookContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
