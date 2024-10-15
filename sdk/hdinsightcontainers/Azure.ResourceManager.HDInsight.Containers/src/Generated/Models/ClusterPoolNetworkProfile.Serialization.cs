// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterPoolNetworkProfile : IUtf8JsonSerializable, IJsonModel<ClusterPoolNetworkProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolNetworkProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPoolNetworkProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolNetworkProfile)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("subnetId"u8);
            writer.WriteStringValue(SubnetId);
            if (Optional.IsDefined(OutboundType))
            {
                writer.WritePropertyName("outboundType"u8);
                writer.WriteStringValue(OutboundType.Value.ToString());
            }
            if (Optional.IsDefined(IsPrivateApiServerEnabled))
            {
                writer.WritePropertyName("enablePrivateApiServer"u8);
                writer.WriteBooleanValue(IsPrivateApiServerEnabled.Value);
            }
            if (Optional.IsCollectionDefined(ApiServerAuthorizedIPRanges))
            {
                writer.WritePropertyName("apiServerAuthorizedIpRanges"u8);
                writer.WriteStartArray();
                foreach (var item in ApiServerAuthorizedIPRanges)
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
        }

        ClusterPoolNetworkProfile IJsonModel<ClusterPoolNetworkProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolNetworkProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolNetworkProfile(document.RootElement, options);
        }

        internal static ClusterPoolNetworkProfile DeserializeClusterPoolNetworkProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier subnetId = default;
            OutboundType? outboundType = default;
            bool? enablePrivateApiServer = default;
            IList<string> apiServerAuthorizedIPRanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subnetId"u8))
                {
                    subnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outboundType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outboundType = new OutboundType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enablePrivateApiServer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePrivateApiServer = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("apiServerAuthorizedIpRanges"u8))
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
                    apiServerAuthorizedIPRanges = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClusterPoolNetworkProfile(subnetId, outboundType, enablePrivateApiServer, apiServerAuthorizedIPRanges ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SubnetId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  subnetId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SubnetId))
                {
                    builder.Append("  subnetId: ");
                    builder.AppendLine($"'{SubnetId.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OutboundType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  outboundType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OutboundType))
                {
                    builder.Append("  outboundType: ");
                    builder.AppendLine($"'{OutboundType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsPrivateApiServerEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enablePrivateApiServer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsPrivateApiServerEnabled))
                {
                    builder.Append("  enablePrivateApiServer: ");
                    var boolValue = IsPrivateApiServerEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiServerAuthorizedIPRanges), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  apiServerAuthorizedIpRanges: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ApiServerAuthorizedIPRanges))
                {
                    if (ApiServerAuthorizedIPRanges.Any())
                    {
                        builder.Append("  apiServerAuthorizedIpRanges: ");
                        builder.AppendLine("[");
                        foreach (var item in ApiServerAuthorizedIPRanges)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClusterPoolNetworkProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolNetworkProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPoolNetworkProfile IPersistableModel<ClusterPoolNetworkProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolNetworkProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolNetworkProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolNetworkProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolNetworkProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
