// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class DeploymentInfoResponse : IUtf8JsonSerializable, IJsonModel<DeploymentInfoResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentInfoResponse>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentInfoResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentInfoResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentInfoResponse)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && Optional.IsDefined(MemoryCapacity))
            {
                writer.WritePropertyName("memoryCapacity"u8);
                writer.WriteStringValue(MemoryCapacity);
            }
            if (options.Format != "W" && Optional.IsDefined(DiskCapacity))
            {
                writer.WritePropertyName("diskCapacity"u8);
                writer.WriteStringValue(DiskCapacity);
            }
            if (options.Format != "W" && Optional.IsDefined(ElasticsearchEndPoint))
            {
                writer.WritePropertyName("elasticsearchEndPoint"u8);
                writer.WriteStringValue(ElasticsearchEndPoint);
            }
            if (options.Format != "W" && Optional.IsDefined(DeploymentUri))
            {
                writer.WritePropertyName("deploymentUrl"u8);
                writer.WriteStringValue(DeploymentUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(MarketplaceSaasInfo))
            {
                writer.WritePropertyName("marketplaceSaasInfo"u8);
                writer.WriteObjectValue(MarketplaceSaasInfo, options);
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

        DeploymentInfoResponse IJsonModel<DeploymentInfoResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentInfoResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentInfoResponse)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentInfoResponse(document.RootElement, options);
        }

        internal static DeploymentInfoResponse DeserializeDeploymentInfoResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ElasticDeploymentStatus? status = default;
            string version = default;
            string memoryCapacity = default;
            string diskCapacity = default;
            string elasticsearchEndPoint = default;
            Uri deploymentUrl = default;
            MarketplaceSaaSInfo marketplaceSaasInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ElasticDeploymentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memoryCapacity"u8))
                {
                    memoryCapacity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskCapacity"u8))
                {
                    diskCapacity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticsearchEndPoint"u8))
                {
                    elasticsearchEndPoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("marketplaceSaasInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSaasInfo = MarketplaceSaaSInfo.DeserializeMarketplaceSaaSInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentInfoResponse(
                status,
                version,
                memoryCapacity,
                diskCapacity,
                elasticsearchEndPoint,
                deploymentUrl,
                marketplaceSaasInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeploymentInfoResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentInfoResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentInfoResponse)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentInfoResponse IPersistableModel<DeploymentInfoResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentInfoResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeploymentInfoResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentInfoResponse)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentInfoResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
