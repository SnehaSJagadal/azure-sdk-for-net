// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityAssessmentMetadataData : IUtf8JsonSerializable, IJsonModel<SecurityAssessmentMetadataData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAssessmentMetadataData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SecurityAssessmentMetadataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(PolicyDefinitionId))
            {
                writer.WritePropertyName("policyDefinitionId"u8);
                writer.WriteStringValue(PolicyDefinitionId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RemediationDescription))
            {
                writer.WritePropertyName("remediationDescription"u8);
                writer.WriteStringValue(RemediationDescription);
            }
            if (Optional.IsCollectionDefined(Categories))
            {
                writer.WritePropertyName("categories"u8);
                writer.WriteStartArray();
                foreach (var item in Categories)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Severity))
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (Optional.IsDefined(UserImpact))
            {
                writer.WritePropertyName("userImpact"u8);
                writer.WriteStringValue(UserImpact.Value.ToString());
            }
            if (Optional.IsDefined(ImplementationEffort))
            {
                writer.WritePropertyName("implementationEffort"u8);
                writer.WriteStringValue(ImplementationEffort.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Threats))
            {
                writer.WritePropertyName("threats"u8);
                writer.WriteStartArray();
                foreach (var item in Threats)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsPreview))
            {
                writer.WritePropertyName("preview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (Optional.IsDefined(AssessmentType))
            {
                writer.WritePropertyName("assessmentType"u8);
                writer.WriteStringValue(AssessmentType.Value.ToString());
            }
            if (Optional.IsDefined(PartnerData))
            {
                writer.WritePropertyName("partnerData"u8);
                writer.WriteObjectValue(PartnerData, options);
            }
            if (Optional.IsDefined(PublishDates))
            {
                writer.WritePropertyName("publishDates"u8);
                writer.WriteObjectValue(PublishDates, options);
            }
            if (Optional.IsDefined(PlannedDeprecationDate))
            {
                writer.WritePropertyName("plannedDeprecationDate"u8);
                writer.WriteStringValue(PlannedDeprecationDate);
            }
            if (Optional.IsCollectionDefined(Tactics))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Techniques))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        SecurityAssessmentMetadataData IJsonModel<SecurityAssessmentMetadataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentMetadataData(document.RootElement, options);
        }

        internal static SecurityAssessmentMetadataData DeserializeSecurityAssessmentMetadataData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string displayName = default;
            ResourceIdentifier policyDefinitionId = default;
            string description = default;
            string remediationDescription = default;
            IList<SecurityAssessmentResourceCategory> categories = default;
            SecurityAssessmentSeverity? severity = default;
            SecurityAssessmentUserImpact? userImpact = default;
            ImplementationEffort? implementationEffort = default;
            IList<SecurityThreat> threats = default;
            bool? preview = default;
            SecurityAssessmentType? assessmentType = default;
            SecurityAssessmentMetadataPartner partnerData = default;
            SecurityAssessmentPublishDates publishDates = default;
            string plannedDeprecationDate = default;
            IList<SecurityAssessmentTactic> tactics = default;
            IList<SecurityAssessmentTechnique> techniques = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionId"u8))
                        {
                            DeserializePolicyDefinitionId(property0, ref policyDefinitionId);
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationDescription"u8))
                        {
                            remediationDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("categories"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAssessmentResourceCategory> array = new List<SecurityAssessmentResourceCategory>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityAssessmentResourceCategory(item.GetString()));
                            }
                            categories = array;
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityAssessmentSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("userImpact"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userImpact = new SecurityAssessmentUserImpact(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("implementationEffort"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            implementationEffort = new ImplementationEffort(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("threats"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityThreat> array = new List<SecurityThreat>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityThreat(item.GetString()));
                            }
                            threats = array;
                            continue;
                        }
                        if (property0.NameEquals("preview"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preview = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("assessmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assessmentType = new SecurityAssessmentType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("partnerData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerData = SecurityAssessmentMetadataPartner.DeserializeSecurityAssessmentMetadataPartner(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("publishDates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishDates = SecurityAssessmentPublishDates.DeserializeSecurityAssessmentPublishDates(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("plannedDeprecationDate"u8))
                        {
                            plannedDeprecationDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAssessmentTactic> array = new List<SecurityAssessmentTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityAssessmentTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityAssessmentTechnique> array = new List<SecurityAssessmentTechnique>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityAssessmentTechnique(item.GetString()));
                            }
                            techniques = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SecurityAssessmentMetadataData(
                id,
                name,
                type,
                systemData,
                displayName,
                policyDefinitionId,
                description,
                remediationDescription,
                categories ?? new ChangeTrackingList<SecurityAssessmentResourceCategory>(),
                severity,
                userImpact,
                implementationEffort,
                threats ?? new ChangeTrackingList<SecurityThreat>(),
                preview,
                assessmentType,
                partnerData,
                publishDates,
                plannedDeprecationDate,
                tactics ?? new ChangeTrackingList<SecurityAssessmentTactic>(),
                techniques ?? new ChangeTrackingList<SecurityAssessmentTechnique>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityAssessmentMetadataData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support writing '{options.Format}' format.");
            }
        }

        SecurityAssessmentMetadataData IPersistableModel<SecurityAssessmentMetadataData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAssessmentMetadataData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAssessmentMetadataData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAssessmentMetadataData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAssessmentMetadataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
