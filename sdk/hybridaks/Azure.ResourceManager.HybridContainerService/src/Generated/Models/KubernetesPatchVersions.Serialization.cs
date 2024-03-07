// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridContainerService;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class KubernetesPatchVersions : IUtf8JsonSerializable, IJsonModel<KubernetesPatchVersions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesPatchVersions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KubernetesPatchVersions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPatchVersions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesPatchVersions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Readiness))
            {
                writer.WritePropertyName("readiness"u8);
                writer.WriteStartArray();
                foreach (var item in Readiness)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Upgrades))
            {
                writer.WritePropertyName("upgrades"u8);
                writer.WriteStartArray();
                foreach (var item in Upgrades)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        KubernetesPatchVersions IJsonModel<KubernetesPatchVersions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPatchVersions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesPatchVersions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesPatchVersions(document.RootElement, options);
        }

        internal static KubernetesPatchVersions DeserializeKubernetesPatchVersions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<KubernetesVersionReadiness> readiness = default;
            IReadOnlyList<string> upgrades = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("readiness"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesVersionReadiness> array = new List<KubernetesVersionReadiness>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KubernetesVersionReadiness.DeserializeKubernetesVersionReadiness(item, options));
                    }
                    readiness = array;
                    continue;
                }
                if (property.NameEquals("upgrades"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    upgrades = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KubernetesPatchVersions(readiness ?? new ChangeTrackingList<KubernetesVersionReadiness>(), upgrades ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KubernetesPatchVersions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPatchVersions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesPatchVersions)} does not support '{options.Format}' format.");
            }
        }

        KubernetesPatchVersions IPersistableModel<KubernetesPatchVersions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesPatchVersions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesPatchVersions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesPatchVersions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesPatchVersions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
