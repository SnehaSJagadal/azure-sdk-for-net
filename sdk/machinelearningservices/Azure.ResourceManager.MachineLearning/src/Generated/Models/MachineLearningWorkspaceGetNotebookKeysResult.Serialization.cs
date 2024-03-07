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
    public partial class MachineLearningWorkspaceGetNotebookKeysResult : IUtf8JsonSerializable, IJsonModel<MachineLearningWorkspaceGetNotebookKeysResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWorkspaceGetNotebookKeysResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningWorkspaceGetNotebookKeysResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceGetNotebookKeysResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(PrimaryAccessKey))
            {
                writer.WritePropertyName("primaryAccessKey"u8);
                writer.WriteStringValue(PrimaryAccessKey);
            }
            if (options.Format != "W" && Optional.IsDefined(SecondaryAccessKey))
            {
                writer.WritePropertyName("secondaryAccessKey"u8);
                writer.WriteStringValue(SecondaryAccessKey);
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

        MachineLearningWorkspaceGetNotebookKeysResult IJsonModel<MachineLearningWorkspaceGetNotebookKeysResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWorkspaceGetNotebookKeysResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWorkspaceGetNotebookKeysResult(document.RootElement, options);
        }

        internal static MachineLearningWorkspaceGetNotebookKeysResult DeserializeMachineLearningWorkspaceGetNotebookKeysResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primaryAccessKey = default;
            string secondaryAccessKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryAccessKey"u8))
                {
                    primaryAccessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryAccessKey"u8))
                {
                    secondaryAccessKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningWorkspaceGetNotebookKeysResult(primaryAccessKey, secondaryAccessKey, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceGetNotebookKeysResult)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningWorkspaceGetNotebookKeysResult IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningWorkspaceGetNotebookKeysResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWorkspaceGetNotebookKeysResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWorkspaceGetNotebookKeysResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
