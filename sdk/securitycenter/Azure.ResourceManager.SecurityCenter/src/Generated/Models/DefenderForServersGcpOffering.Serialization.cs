// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersGcpOffering : IUtf8JsonSerializable, IJsonModel<DefenderForServersGcpOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefenderForServersGcpOffering>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefenderForServersGcpOffering>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOffering)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefenderForServers))
            {
                writer.WritePropertyName("defenderForServers"u8);
                writer.WriteObjectValue(DefenderForServers);
            }
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                writer.WriteObjectValue(ArcAutoProvisioning);
            }
            if (Optional.IsDefined(VulnerabilityAssessmentAutoProvisioning))
            {
                writer.WritePropertyName("vaAutoProvisioning"u8);
                writer.WriteObjectValue(VulnerabilityAssessmentAutoProvisioning);
            }
            if (Optional.IsDefined(MdeAutoProvisioning))
            {
                writer.WritePropertyName("mdeAutoProvisioning"u8);
                writer.WriteObjectValue(MdeAutoProvisioning);
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan"u8);
                writer.WriteObjectValue(SubPlan);
            }
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                writer.WriteObjectValue(VmScanners);
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        DefenderForServersGcpOffering IJsonModel<DefenderForServersGcpOffering>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DefenderForServersGcpOffering)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersGcpOffering(document.RootElement, options);
        }

        internal static DefenderForServersGcpOffering DeserializeDefenderForServersGcpOffering(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GcpDefenderForServersInfo defenderForServers = default;
            DefenderForServersGcpOfferingArcAutoProvisioning arcAutoProvisioning = default;
            DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning vaAutoProvisioning = default;
            DefenderForServersGcpOfferingMdeAutoProvisioning mdeAutoProvisioning = default;
            DefenderForServersGcpOfferingSubPlan subPlan = default;
            DefenderForServersGcpOfferingVmScanners vmScanners = default;
            OfferingType offeringType = default;
            string description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defenderForServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defenderForServers = GcpDefenderForServersInfo.DeserializeGcpDefenderForServersInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForServersGcpOfferingArcAutoProvisioning.DeserializeDefenderForServersGcpOfferingArcAutoProvisioning(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vaAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaAutoProvisioning = DefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning.DeserializeDefenderForServersGcpOfferingVulnerabilityAssessmentAutoProvisioning(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mdeAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdeAutoProvisioning = DefenderForServersGcpOfferingMdeAutoProvisioning.DeserializeDefenderForServersGcpOfferingMdeAutoProvisioning(property.Value, options);
                    continue;
                }
                if (property.NameEquals("subPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subPlan = DefenderForServersGcpOfferingSubPlan.DeserializeDefenderForServersGcpOfferingSubPlan(property.Value, options);
                    continue;
                }
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderForServersGcpOfferingVmScanners.DeserializeDefenderForServersGcpOfferingVmScanners(property.Value, options);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefenderForServersGcpOffering(
                offeringType,
                description,
                serializedAdditionalRawData,
                defenderForServers,
                arcAutoProvisioning,
                vaAutoProvisioning,
                mdeAutoProvisioning,
                subPlan,
                vmScanners);
        }

        BinaryData IPersistableModel<DefenderForServersGcpOffering>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersGcpOffering)} does not support '{options.Format}' format.");
            }
        }

        DefenderForServersGcpOffering IPersistableModel<DefenderForServersGcpOffering>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DefenderForServersGcpOffering>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDefenderForServersGcpOffering(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DefenderForServersGcpOffering)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DefenderForServersGcpOffering>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
