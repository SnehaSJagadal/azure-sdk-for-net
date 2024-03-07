// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaBasePolicyDetails : IUtf8JsonSerializable, IJsonModel<HyperVReplicaBasePolicyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HyperVReplicaBasePolicyDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HyperVReplicaBasePolicyDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaBasePolicyDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPoints))
            {
                writer.WritePropertyName("recoveryPoints"u8);
                writer.WriteNumberValue(RecoveryPoints.Value);
            }
            if (Optional.IsDefined(ApplicationConsistentSnapshotFrequencyInHours))
            {
                writer.WritePropertyName("applicationConsistentSnapshotFrequencyInHours"u8);
                writer.WriteNumberValue(ApplicationConsistentSnapshotFrequencyInHours.Value);
            }
            if (Optional.IsDefined(Compression))
            {
                writer.WritePropertyName("compression"u8);
                writer.WriteStringValue(Compression);
            }
            if (Optional.IsDefined(InitialReplicationMethod))
            {
                writer.WritePropertyName("initialReplicationMethod"u8);
                writer.WriteStringValue(InitialReplicationMethod);
            }
            if (Optional.IsDefined(OnlineReplicationStartTime))
            {
                writer.WritePropertyName("onlineReplicationStartTime"u8);
                writer.WriteStringValue(OnlineReplicationStartTime);
            }
            if (Optional.IsDefined(OfflineReplicationImportPath))
            {
                writer.WritePropertyName("offlineReplicationImportPath"u8);
                writer.WriteStringValue(OfflineReplicationImportPath);
            }
            if (Optional.IsDefined(OfflineReplicationExportPath))
            {
                writer.WritePropertyName("offlineReplicationExportPath"u8);
                writer.WriteStringValue(OfflineReplicationExportPath);
            }
            if (Optional.IsDefined(ReplicationPort))
            {
                writer.WritePropertyName("replicationPort"u8);
                writer.WriteNumberValue(ReplicationPort.Value);
            }
            if (Optional.IsDefined(AllowedAuthenticationType))
            {
                writer.WritePropertyName("allowedAuthenticationType"u8);
                writer.WriteNumberValue(AllowedAuthenticationType.Value);
            }
            if (Optional.IsDefined(ReplicaDeletionOption))
            {
                writer.WritePropertyName("replicaDeletionOption"u8);
                writer.WriteStringValue(ReplicaDeletionOption);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        HyperVReplicaBasePolicyDetails IJsonModel<HyperVReplicaBasePolicyDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HyperVReplicaBasePolicyDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplicaBasePolicyDetails(document.RootElement, options);
        }

        internal static HyperVReplicaBasePolicyDetails DeserializeHyperVReplicaBasePolicyDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? recoveryPoints = default;
            int? applicationConsistentSnapshotFrequencyInHours = default;
            string compression = default;
            string initialReplicationMethod = default;
            string onlineReplicationStartTime = default;
            string offlineReplicationImportPath = default;
            string offlineReplicationExportPath = default;
            int? replicationPort = default;
            int? allowedAuthenticationType = default;
            string replicaDeletionOption = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPoints = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("applicationConsistentSnapshotFrequencyInHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationConsistentSnapshotFrequencyInHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compression"u8))
                {
                    compression = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialReplicationMethod"u8))
                {
                    initialReplicationMethod = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onlineReplicationStartTime"u8))
                {
                    onlineReplicationStartTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationImportPath"u8))
                {
                    offlineReplicationImportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offlineReplicationExportPath"u8))
                {
                    offlineReplicationExportPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedAuthenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowedAuthenticationType = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicaDeletionOption"u8))
                {
                    replicaDeletionOption = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HyperVReplicaBasePolicyDetails(
                instanceType,
                serializedAdditionalRawData,
                recoveryPoints,
                applicationConsistentSnapshotFrequencyInHours,
                compression,
                initialReplicationMethod,
                onlineReplicationStartTime,
                offlineReplicationImportPath,
                offlineReplicationExportPath,
                replicationPort,
                allowedAuthenticationType,
                replicaDeletionOption);
        }

        BinaryData IPersistableModel<HyperVReplicaBasePolicyDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaBasePolicyDetails)} does not support '{options.Format}' format.");
            }
        }

        HyperVReplicaBasePolicyDetails IPersistableModel<HyperVReplicaBasePolicyDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HyperVReplicaBasePolicyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHyperVReplicaBasePolicyDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HyperVReplicaBasePolicyDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HyperVReplicaBasePolicyDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
