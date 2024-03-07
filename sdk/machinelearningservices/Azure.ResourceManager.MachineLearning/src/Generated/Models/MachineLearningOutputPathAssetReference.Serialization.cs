// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningOutputPathAssetReference : IUtf8JsonSerializable, IJsonModel<MachineLearningOutputPathAssetReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningOutputPathAssetReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningOutputPathAssetReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutputPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOutputPathAssetReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(JobId))
            {
                if (JobId != null)
                {
                    writer.WritePropertyName("jobId"u8);
                    writer.WriteStringValue(JobId);
                }
                else
                {
                    writer.WriteNull("jobId");
                }
            }
            if (Optional.IsDefined(Path))
            {
                if (Path != null)
                {
                    writer.WritePropertyName("path"u8);
                    writer.WriteStringValue(Path);
                }
                else
                {
                    writer.WriteNull("path");
                }
            }
            writer.WritePropertyName("referenceType"u8);
            writer.WriteStringValue(ReferenceType.ToString());
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

        MachineLearningOutputPathAssetReference IJsonModel<MachineLearningOutputPathAssetReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutputPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningOutputPathAssetReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningOutputPathAssetReference(document.RootElement, options);
        }

        internal static MachineLearningOutputPathAssetReference DeserializeMachineLearningOutputPathAssetReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier jobId = default;
            string path = default;
            ReferenceType referenceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("jobId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        jobId = null;
                        continue;
                    }
                    jobId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        path = null;
                        continue;
                    }
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("referenceType"u8))
                {
                    referenceType = new ReferenceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningOutputPathAssetReference(referenceType, serializedAdditionalRawData, jobId, path);
        }

        BinaryData IPersistableModel<MachineLearningOutputPathAssetReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutputPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOutputPathAssetReference)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningOutputPathAssetReference IPersistableModel<MachineLearningOutputPathAssetReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningOutputPathAssetReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningOutputPathAssetReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningOutputPathAssetReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningOutputPathAssetReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
