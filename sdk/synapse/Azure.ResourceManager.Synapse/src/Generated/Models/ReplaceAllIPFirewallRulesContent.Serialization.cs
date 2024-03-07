// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class ReplaceAllIPFirewallRulesContent : IUtf8JsonSerializable, IJsonModel<ReplaceAllIPFirewallRulesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplaceAllIPFirewallRulesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplaceAllIPFirewallRulesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplaceAllIPFirewallRulesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplaceAllIPFirewallRulesContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPFirewallRules))
            {
                writer.WritePropertyName("ipFirewallRules"u8);
                writer.WriteStartObject();
                foreach (var item in IPFirewallRules)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
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

        ReplaceAllIPFirewallRulesContent IJsonModel<ReplaceAllIPFirewallRulesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplaceAllIPFirewallRulesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReplaceAllIPFirewallRulesContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplaceAllIPFirewallRulesContent(document.RootElement, options);
        }

        internal static ReplaceAllIPFirewallRulesContent DeserializeReplaceAllIPFirewallRulesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, SynapseIPFirewallRuleProperties> ipFirewallRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipFirewallRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SynapseIPFirewallRuleProperties> dictionary = new Dictionary<string, SynapseIPFirewallRuleProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, SynapseIPFirewallRuleProperties.DeserializeSynapseIPFirewallRuleProperties(property0.Value, options));
                    }
                    ipFirewallRules = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReplaceAllIPFirewallRulesContent(ipFirewallRules ?? new ChangeTrackingDictionary<string, SynapseIPFirewallRuleProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReplaceAllIPFirewallRulesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplaceAllIPFirewallRulesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReplaceAllIPFirewallRulesContent)} does not support '{options.Format}' format.");
            }
        }

        ReplaceAllIPFirewallRulesContent IPersistableModel<ReplaceAllIPFirewallRulesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReplaceAllIPFirewallRulesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReplaceAllIPFirewallRulesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReplaceAllIPFirewallRulesContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReplaceAllIPFirewallRulesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
