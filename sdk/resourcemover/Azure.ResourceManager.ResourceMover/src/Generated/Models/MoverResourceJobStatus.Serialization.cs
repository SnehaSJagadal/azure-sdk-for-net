// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceJobStatus : IUtf8JsonSerializable, IJsonModel<MoverResourceJobStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceJobStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MoverResourceJobStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceJobStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceJobStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(JobName))
            {
                writer.WritePropertyName("jobName"u8);
                writer.WriteStringValue(JobName.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(JobProgress))
            {
                writer.WritePropertyName("jobProgress"u8);
                writer.WriteStringValue(JobProgress);
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
        }

        MoverResourceJobStatus IJsonModel<MoverResourceJobStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceJobStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MoverResourceJobStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceJobStatus(document.RootElement, options);
        }

        internal static MoverResourceJobStatus DeserializeMoverResourceJobStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MoverResourceJobName? jobName = default;
            string jobProgress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobName = new MoverResourceJobName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("jobProgress"u8))
                {
                    jobProgress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MoverResourceJobStatus(jobName, jobProgress, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverResourceJobStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceJobStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MoverResourceJobStatus)} does not support writing '{options.Format}' format.");
            }
        }

        MoverResourceJobStatus IPersistableModel<MoverResourceJobStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MoverResourceJobStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMoverResourceJobStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MoverResourceJobStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MoverResourceJobStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
