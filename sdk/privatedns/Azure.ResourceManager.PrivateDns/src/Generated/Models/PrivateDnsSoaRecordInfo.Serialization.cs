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

namespace Azure.ResourceManager.PrivateDns.Models
{
    public partial class PrivateDnsSoaRecordInfo : IUtf8JsonSerializable, IJsonModel<PrivateDnsSoaRecordInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PrivateDnsSoaRecordInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PrivateDnsSoaRecordInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsSoaRecordInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host"u8);
                writer.WriteStringValue(Host);
            }
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteStringValue(Email);
            }
            if (Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteNumberValue(SerialNumber.Value);
            }
            if (Optional.IsDefined(RefreshTimeInSeconds))
            {
                writer.WritePropertyName("refreshTime"u8);
                writer.WriteNumberValue(RefreshTimeInSeconds.Value);
            }
            if (Optional.IsDefined(RetryTimeInSeconds))
            {
                writer.WritePropertyName("retryTime"u8);
                writer.WriteNumberValue(RetryTimeInSeconds.Value);
            }
            if (Optional.IsDefined(ExpireTimeInSeconds))
            {
                writer.WritePropertyName("expireTime"u8);
                writer.WriteNumberValue(ExpireTimeInSeconds.Value);
            }
            if (Optional.IsDefined(MinimumTtlInSeconds))
            {
                writer.WritePropertyName("minimumTtl"u8);
                writer.WriteNumberValue(MinimumTtlInSeconds.Value);
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

        PrivateDnsSoaRecordInfo IJsonModel<PrivateDnsSoaRecordInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PrivateDnsSoaRecordInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateDnsSoaRecordInfo(document.RootElement, options);
        }

        internal static PrivateDnsSoaRecordInfo DeserializePrivateDnsSoaRecordInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string host = default;
            string email = default;
            long? serialNumber = default;
            long? refreshTime = default;
            long? retryTime = default;
            long? expireTime = default;
            long? minimumTtl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("host"u8))
                {
                    host = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    email = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serialNumber = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("refreshTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    refreshTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("retryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retryTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("expireTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expireTime = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumTtl = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PrivateDnsSoaRecordInfo(
                host,
                email,
                serialNumber,
                refreshTime,
                retryTime,
                expireTime,
                minimumTtl,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Host), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  host: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Host))
                {
                    builder.Append("  host: ");
                    if (Host.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Host}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Host}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Email), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  email: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Email))
                {
                    builder.Append("  email: ");
                    if (Email.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Email}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Email}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SerialNumber), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serialNumber: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SerialNumber))
                {
                    builder.Append("  serialNumber: ");
                    builder.AppendLine($"'{SerialNumber.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RefreshTimeInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  refreshTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RefreshTimeInSeconds))
                {
                    builder.Append("  refreshTime: ");
                    builder.AppendLine($"'{RefreshTimeInSeconds.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RetryTimeInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  retryTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RetryTimeInSeconds))
                {
                    builder.Append("  retryTime: ");
                    builder.AppendLine($"'{RetryTimeInSeconds.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExpireTimeInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  expireTime: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ExpireTimeInSeconds))
                {
                    builder.Append("  expireTime: ");
                    builder.AppendLine($"'{ExpireTimeInSeconds.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinimumTtlInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minimumTtl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MinimumTtlInSeconds))
                {
                    builder.Append("  minimumTtl: ");
                    builder.AppendLine($"'{MinimumTtlInSeconds.Value.ToString()}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<PrivateDnsSoaRecordInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsSoaRecordInfo)} does not support writing '{options.Format}' format.");
            }
        }

        PrivateDnsSoaRecordInfo IPersistableModel<PrivateDnsSoaRecordInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PrivateDnsSoaRecordInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePrivateDnsSoaRecordInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PrivateDnsSoaRecordInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PrivateDnsSoaRecordInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
