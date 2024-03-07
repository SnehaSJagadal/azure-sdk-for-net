// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlMetricValue : IUtf8JsonSerializable, IJsonModel<SqlMetricValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlMetricValue>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlMetricValue>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlMetricValue)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteNumberValue(Count.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Average))
            {
                writer.WritePropertyName("average"u8);
                writer.WriteNumberValue(Average.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Maximum))
            {
                writer.WritePropertyName("maximum"u8);
                writer.WriteNumberValue(Maximum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Minimum))
            {
                writer.WritePropertyName("minimum"u8);
                writer.WriteNumberValue(Minimum.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Timestamp))
            {
                writer.WritePropertyName("timestamp"u8);
                writer.WriteStringValue(Timestamp.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(Total))
            {
                writer.WritePropertyName("total"u8);
                writer.WriteNumberValue(Total.Value);
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

        SqlMetricValue IJsonModel<SqlMetricValue>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricValue>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlMetricValue)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlMetricValue(document.RootElement, options);
        }

        internal static SqlMetricValue DeserializeSqlMetricValue(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? count = default;
            double? average = default;
            double? maximum = default;
            double? minimum = default;
            DateTimeOffset? timestamp = default;
            double? total = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("average"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    average = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    total = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlMetricValue(
                count,
                average,
                maximum,
                minimum,
                timestamp,
                total,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlMetricValue>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlMetricValue)} does not support '{options.Format}' format.");
            }
        }

        SqlMetricValue IPersistableModel<SqlMetricValue>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlMetricValue>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlMetricValue(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlMetricValue)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlMetricValue>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
