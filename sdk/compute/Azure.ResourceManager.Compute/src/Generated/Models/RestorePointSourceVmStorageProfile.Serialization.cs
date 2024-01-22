// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class RestorePointSourceVmStorageProfile : IUtf8JsonSerializable, IJsonModel<RestorePointSourceVmStorageProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RestorePointSourceVmStorageProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RestorePointSourceVmStorageProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorePointSourceVmStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorePointSourceVmStorageProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OSDisk))
            {
                writer.WritePropertyName("osDisk"u8);
                writer.WriteObjectValue(OSDisk);
            }
            if (Optional.IsCollectionDefined(DataDiskList))
            {
                writer.WritePropertyName("dataDisks"u8);
                writer.WriteStartArray();
                foreach (var item in DataDiskList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DiskControllerType))
            {
                writer.WritePropertyName("diskControllerType"u8);
                writer.WriteStringValue(DiskControllerType.Value.ToString());
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

        RestorePointSourceVmStorageProfile IJsonModel<RestorePointSourceVmStorageProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorePointSourceVmStorageProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RestorePointSourceVmStorageProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRestorePointSourceVmStorageProfile(document.RootElement, options);
        }

        internal static RestorePointSourceVmStorageProfile DeserializeRestorePointSourceVmStorageProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RestorePointSourceVmOSDisk> osDisk = default;
            Optional<IList<RestorePointSourceVmDataDisk>> dataDisks = default;
            Optional<DiskControllerType> diskControllerType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osDisk = RestorePointSourceVmOSDisk.DeserializeRestorePointSourceVmOSDisk(property.Value);
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestorePointSourceVmDataDisk> array = new List<RestorePointSourceVmDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RestorePointSourceVmDataDisk.DeserializeRestorePointSourceVmDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
                if (property.NameEquals("diskControllerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskControllerType = new DiskControllerType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RestorePointSourceVmStorageProfile(osDisk.Value, Optional.ToList(dataDisks), Optional.ToNullable(diskControllerType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RestorePointSourceVmStorageProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorePointSourceVmStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RestorePointSourceVmStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        RestorePointSourceVmStorageProfile IPersistableModel<RestorePointSourceVmStorageProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RestorePointSourceVmStorageProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRestorePointSourceVmStorageProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RestorePointSourceVmStorageProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RestorePointSourceVmStorageProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
