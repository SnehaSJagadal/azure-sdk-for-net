// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NeonPostgres.Models
{
    public partial class NeonCompanyDetails : IUtf8JsonSerializable, IJsonModel<NeonCompanyDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NeonCompanyDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NeonCompanyDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonCompanyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NeonCompanyDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CompanyName))
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            if (Optional.IsDefined(OfficeAddress))
            {
                writer.WritePropertyName("officeAddress"u8);
                writer.WriteStringValue(OfficeAddress);
            }
            if (Optional.IsDefined(BusinessPhone))
            {
                writer.WritePropertyName("businessPhone"u8);
                writer.WriteStringValue(BusinessPhone);
            }
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Optional.IsDefined(NumberOfEmployees))
            {
                writer.WritePropertyName("numberOfEmployees"u8);
                writer.WriteNumberValue(NumberOfEmployees.Value);
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

        NeonCompanyDetails IJsonModel<NeonCompanyDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonCompanyDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NeonCompanyDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNeonCompanyDetails(document.RootElement, options);
        }

        internal static NeonCompanyDetails DeserializeNeonCompanyDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string companyName = default;
            string country = default;
            string officeAddress = default;
            string businessPhone = default;
            string domain = default;
            long? numberOfEmployees = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("officeAddress"u8))
                {
                    officeAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("businessPhone"u8))
                {
                    businessPhone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("numberOfEmployees"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberOfEmployees = property.Value.GetInt64();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NeonCompanyDetails(
                companyName,
                country,
                officeAddress,
                businessPhone,
                domain,
                numberOfEmployees,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NeonCompanyDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonCompanyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NeonCompanyDetails)} does not support writing '{options.Format}' format.");
            }
        }

        NeonCompanyDetails IPersistableModel<NeonCompanyDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NeonCompanyDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNeonCompanyDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NeonCompanyDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NeonCompanyDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
