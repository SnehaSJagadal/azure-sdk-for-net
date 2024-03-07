// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    [JsonConverter(typeof(DatasetSchemaDataElementConverter))]
    public partial class DatasetSchemaDataElement : IUtf8JsonSerializable, IJsonModel<DatasetSchemaDataElement>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatasetSchemaDataElement>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatasetSchemaDataElement>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetSchemaDataElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetSchemaDataElement)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SchemaColumnName))
            {
                writer.WritePropertyName("name"u8);
                JsonSerializer.Serialize(writer, SchemaColumnName);
            }
            if (Optional.IsDefined(SchemaColumnType))
            {
                writer.WritePropertyName("type"u8);
                JsonSerializer.Serialize(writer, SchemaColumnType);
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

        DatasetSchemaDataElement IJsonModel<DatasetSchemaDataElement>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetSchemaDataElement>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatasetSchemaDataElement)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatasetSchemaDataElement(document.RootElement, options);
        }

        internal static DatasetSchemaDataElement DeserializeDatasetSchemaDataElement(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> name = default;
            DataFactoryElement<string> type = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DatasetSchemaDataElement(name, type, additionalProperties);
        }

        BinaryData IPersistableModel<DatasetSchemaDataElement>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetSchemaDataElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatasetSchemaDataElement)} does not support '{options.Format}' format.");
            }
        }

        DatasetSchemaDataElement IPersistableModel<DatasetSchemaDataElement>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatasetSchemaDataElement>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatasetSchemaDataElement(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatasetSchemaDataElement)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatasetSchemaDataElement>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class DatasetSchemaDataElementConverter : JsonConverter<DatasetSchemaDataElement>
        {
            public override void Write(Utf8JsonWriter writer, DatasetSchemaDataElement model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DatasetSchemaDataElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDatasetSchemaDataElement(document.RootElement);
            }
        }
    }
}
