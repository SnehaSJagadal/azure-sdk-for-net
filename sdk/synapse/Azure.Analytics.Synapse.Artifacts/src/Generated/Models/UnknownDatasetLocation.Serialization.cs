// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    internal partial class UnknownDatasetLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(FolderPath))
            {
                writer.WritePropertyName("folderPath"u8);
                writer.WriteObjectValue(FolderPath);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteObjectValue(FileName);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static UnknownDatasetLocation DeserializeUnknownDatasetLocation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            object folderPath = default;
            object fileName = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("folderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    folderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileName = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new UnknownDatasetLocation(type, folderPath, fileName, additionalProperties);
        }
    }
}
