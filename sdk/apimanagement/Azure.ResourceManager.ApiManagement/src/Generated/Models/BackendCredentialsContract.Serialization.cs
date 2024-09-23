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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendCredentialsContract : IUtf8JsonSerializable, IJsonModel<BackendCredentialsContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendCredentialsContract>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BackendCredentialsContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendCredentialsContract)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(CertificateIds))
            {
                writer.WritePropertyName("certificateIds"u8);
                writer.WriteStartArray();
                foreach (var item in CertificateIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Certificate))
            {
                writer.WritePropertyName("certificate"u8);
                writer.WriteStartArray();
                foreach (var item in Certificate)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Query))
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStartObject();
                foreach (var item in Query)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Header))
            {
                writer.WritePropertyName("header"u8);
                writer.WriteStartObject();
                foreach (var item in Header)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Authorization))
            {
                writer.WritePropertyName("authorization"u8);
                writer.WriteObjectValue(Authorization, options);
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

        BackendCredentialsContract IJsonModel<BackendCredentialsContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackendCredentialsContract)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendCredentialsContract(document.RootElement, options);
        }

        internal static BackendCredentialsContract DeserializeBackendCredentialsContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> certificateIds = default;
            IList<string> certificate = default;
            IDictionary<string, IList<string>> query = default;
            IDictionary<string, IList<string>> header = default;
            BackendAuthorizationHeaderCredentials authorization = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("certificateIds"u8))
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
                    certificateIds = array;
                    continue;
                }
                if (property.NameEquals("certificate"u8))
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
                    certificate = array;
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    query = dictionary;
                    continue;
                }
                if (property.NameEquals("header"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    header = dictionary;
                    continue;
                }
                if (property.NameEquals("authorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorization = BackendAuthorizationHeaderCredentials.DeserializeBackendAuthorizationHeaderCredentials(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BackendCredentialsContract(
                certificateIds ?? new ChangeTrackingList<string>(),
                certificate ?? new ChangeTrackingList<string>(),
                query ?? new ChangeTrackingDictionary<string, IList<string>>(),
                header ?? new ChangeTrackingDictionary<string, IList<string>>(),
                authorization,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CertificateIds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certificateIds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(CertificateIds))
                {
                    if (CertificateIds.Any())
                    {
                        builder.Append("  certificateIds: ");
                        builder.AppendLine("[");
                        foreach (var item in CertificateIds)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Certificate), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  certificate: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Certificate))
                {
                    if (Certificate.Any())
                    {
                        builder.Append("  certificate: ");
                        builder.AppendLine("[");
                        foreach (var item in Certificate)
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Query), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  query: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Query))
                {
                    if (Query.Any())
                    {
                        builder.Append("  query: ");
                        builder.AppendLine("{");
                        foreach (var item in Query)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item.Value)
                            {
                                if (item0 == null)
                                {
                                    builder.Append("null");
                                    continue;
                                }
                                if (item0.Contains(Environment.NewLine))
                                {
                                    builder.AppendLine("      '''");
                                    builder.AppendLine($"{item0}'''");
                                }
                                else
                                {
                                    builder.AppendLine($"      '{item0}'");
                                }
                            }
                            builder.AppendLine("    ]");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Header), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  header: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Header))
                {
                    if (Header.Any())
                    {
                        builder.Append("  header: ");
                        builder.AppendLine("{");
                        foreach (var item in Header)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            builder.AppendLine("[");
                            foreach (var item0 in item.Value)
                            {
                                if (item0 == null)
                                {
                                    builder.Append("null");
                                    continue;
                                }
                                if (item0.Contains(Environment.NewLine))
                                {
                                    builder.AppendLine("      '''");
                                    builder.AppendLine($"{item0}'''");
                                }
                                else
                                {
                                    builder.AppendLine($"      '{item0}'");
                                }
                            }
                            builder.AppendLine("    ]");
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Authorization), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorization: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Authorization))
                {
                    builder.Append("  authorization: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Authorization, options, 2, false, "  authorization: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<BackendCredentialsContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BackendCredentialsContract)} does not support writing '{options.Format}' format.");
            }
        }

        BackendCredentialsContract IPersistableModel<BackendCredentialsContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackendCredentialsContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackendCredentialsContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackendCredentialsContract)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackendCredentialsContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
