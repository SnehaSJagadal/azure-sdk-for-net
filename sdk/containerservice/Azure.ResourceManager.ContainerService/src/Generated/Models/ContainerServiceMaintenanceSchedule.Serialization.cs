// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceSchedule : IUtf8JsonSerializable, IJsonModel<ContainerServiceMaintenanceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceMaintenanceSchedule>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceMaintenanceSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceSchedule)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Daily))
            {
                writer.WritePropertyName("daily"u8);
                writer.WriteObjectValue(Daily, options);
            }
            if (Optional.IsDefined(Weekly))
            {
                writer.WritePropertyName("weekly"u8);
                writer.WriteObjectValue(Weekly, options);
            }
            if (Optional.IsDefined(AbsoluteMonthly))
            {
                writer.WritePropertyName("absoluteMonthly"u8);
                writer.WriteObjectValue(AbsoluteMonthly, options);
            }
            if (Optional.IsDefined(RelativeMonthly))
            {
                writer.WritePropertyName("relativeMonthly"u8);
                writer.WriteObjectValue(RelativeMonthly, options);
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

        ContainerServiceMaintenanceSchedule IJsonModel<ContainerServiceMaintenanceSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceMaintenanceSchedule)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceSchedule(document.RootElement, options);
        }

        internal static ContainerServiceMaintenanceSchedule DeserializeContainerServiceMaintenanceSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DailySchedule daily = default;
            ContainerServiceMaintenanceWeeklySchedule weekly = default;
            ContainerServiceMaintenanceAbsoluteMonthlySchedule absoluteMonthly = default;
            ContainerServiceMaintenanceRelativeMonthlySchedule relativeMonthly = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daily"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daily = DailySchedule.DeserializeDailySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("weekly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weekly = ContainerServiceMaintenanceWeeklySchedule.DeserializeContainerServiceMaintenanceWeeklySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("absoluteMonthly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    absoluteMonthly = ContainerServiceMaintenanceAbsoluteMonthlySchedule.DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(property.Value, options);
                    continue;
                }
                if (property.NameEquals("relativeMonthly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relativeMonthly = ContainerServiceMaintenanceRelativeMonthlySchedule.DeserializeContainerServiceMaintenanceRelativeMonthlySchedule(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceMaintenanceSchedule(daily, weekly, absoluteMonthly, relativeMonthly, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("DailyIntervalDays", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  daily: ");
                builder.AppendLine("{");
                builder.Append("    intervalDays: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Daily))
                {
                    builder.Append("  daily: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Daily, options, 2, false, "  daily: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Weekly), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  weekly: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Weekly))
                {
                    builder.Append("  weekly: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Weekly, options, 2, false, "  weekly: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AbsoluteMonthly), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  absoluteMonthly: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AbsoluteMonthly))
                {
                    builder.Append("  absoluteMonthly: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AbsoluteMonthly, options, 2, false, "  absoluteMonthly: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RelativeMonthly), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  relativeMonthly: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RelativeMonthly))
                {
                    builder.Append("  relativeMonthly: ");
                    BicepSerializationHelpers.AppendChildObject(builder, RelativeMonthly, options, 2, false, "  relativeMonthly: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceMaintenanceSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceSchedule)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceMaintenanceSchedule IPersistableModel<ContainerServiceMaintenanceSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceMaintenanceSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceMaintenanceSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceMaintenanceSchedule)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceMaintenanceSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
