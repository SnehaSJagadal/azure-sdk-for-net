// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Confluent;

namespace Azure.ResourceManager.Confluent.Models
{
    public partial class ConfluentOrganizationValidationResult : IUtf8JsonSerializable, IJsonModel<ConfluentOrganizationValidationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConfluentOrganizationValidationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConfluentOrganizationValidationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOrganizationValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentOrganizationValidationResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Info))
            {
                writer.WritePropertyName("info"u8);
                writer.WriteStartObject();
                foreach (var item in Info)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        ConfluentOrganizationValidationResult IJsonModel<ConfluentOrganizationValidationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOrganizationValidationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConfluentOrganizationValidationResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConfluentOrganizationValidationResult(document.RootElement, options);
        }

        internal static ConfluentOrganizationValidationResult DeserializeConfluentOrganizationValidationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, string> info = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("info"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    info = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConfluentOrganizationValidationResult(info ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConfluentOrganizationValidationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOrganizationValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConfluentOrganizationValidationResult)} does not support '{options.Format}' format.");
            }
        }

        ConfluentOrganizationValidationResult IPersistableModel<ConfluentOrganizationValidationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConfluentOrganizationValidationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConfluentOrganizationValidationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConfluentOrganizationValidationResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConfluentOrganizationValidationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
