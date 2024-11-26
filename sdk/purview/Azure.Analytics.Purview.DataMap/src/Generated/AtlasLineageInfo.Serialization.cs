// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.DataMap
{
    public partial class AtlasLineageInfo : IUtf8JsonSerializable, IJsonModel<AtlasLineageInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AtlasLineageInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AtlasLineageInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasLineageInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasLineageInfo)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(BaseEntityGuid))
            {
                writer.WritePropertyName("baseEntityGuid"u8);
                writer.WriteStringValue(BaseEntityGuid);
            }
            if (Optional.IsCollectionDefined(GuidEntityMap))
            {
                writer.WritePropertyName("guidEntityMap"u8);
                writer.WriteStartObject();
                foreach (var item in GuidEntityMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(WidthCounts))
            {
                writer.WritePropertyName("widthCounts"u8);
                writer.WriteStartObject();
                foreach (var item in WidthCounts)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartObject();
                    foreach (var item0 in item.Value)
                    {
                        writer.WritePropertyName(item0.Key);
                        if (item0.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item0.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item0.Value))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(LineageDepth))
            {
                writer.WritePropertyName("lineageDepth"u8);
                writer.WriteNumberValue(LineageDepth.Value);
            }
            if (Optional.IsDefined(LineageWidth))
            {
                writer.WritePropertyName("lineageWidth"u8);
                writer.WriteNumberValue(LineageWidth.Value);
            }
            if (Optional.IsDefined(ChildrenCount))
            {
                writer.WritePropertyName("childrenCount"u8);
                writer.WriteNumberValue(ChildrenCount.Value);
            }
            if (Optional.IsDefined(LineageDirection))
            {
                writer.WritePropertyName("lineageDirection"u8);
                writer.WriteStringValue(LineageDirection.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ParentRelations))
            {
                writer.WritePropertyName("parentRelations"u8);
                writer.WriteStartArray();
                foreach (var item in ParentRelations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Relations))
            {
                writer.WritePropertyName("relations"u8);
                writer.WriteStartArray();
                foreach (var item in Relations)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        AtlasLineageInfo IJsonModel<AtlasLineageInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasLineageInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AtlasLineageInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAtlasLineageInfo(document.RootElement, options);
        }

        internal static AtlasLineageInfo DeserializeAtlasLineageInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string baseEntityGuid = default;
            IReadOnlyDictionary<string, AtlasEntityHeader> guidEntityMap = default;
            IReadOnlyDictionary<string, IDictionary<string, BinaryData>> widthCounts = default;
            int? lineageDepth = default;
            int? lineageWidth = default;
            int? childrenCount = default;
            LineageDirection? lineageDirection = default;
            IReadOnlyList<ParentRelation> parentRelations = default;
            IReadOnlyList<LineageRelation> relations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseEntityGuid"u8))
                {
                    baseEntityGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guidEntityMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, AtlasEntityHeader> dictionary = new Dictionary<string, AtlasEntityHeader>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, AtlasEntityHeader.DeserializeAtlasEntityHeader(property0.Value, options));
                    }
                    guidEntityMap = dictionary;
                    continue;
                }
                if (property.NameEquals("widthCounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IDictionary<string, BinaryData>> dictionary = new Dictionary<string, IDictionary<string, BinaryData>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            Dictionary<string, BinaryData> dictionary0 = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary0.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary0.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            dictionary.Add(property0.Name, dictionary0);
                        }
                    }
                    widthCounts = dictionary;
                    continue;
                }
                if (property.NameEquals("lineageDepth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lineageDepth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lineageWidth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lineageWidth = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("childrenCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    childrenCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lineageDirection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lineageDirection = new LineageDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("parentRelations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParentRelation> array = new List<ParentRelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParentRelation.DeserializeParentRelation(item, options));
                    }
                    parentRelations = array;
                    continue;
                }
                if (property.NameEquals("relations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LineageRelation> array = new List<LineageRelation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LineageRelation.DeserializeLineageRelation(item, options));
                    }
                    relations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AtlasLineageInfo(
                baseEntityGuid,
                guidEntityMap ?? new ChangeTrackingDictionary<string, AtlasEntityHeader>(),
                widthCounts ?? new ChangeTrackingDictionary<string, IDictionary<string, BinaryData>>(),
                lineageDepth,
                lineageWidth,
                childrenCount,
                lineageDirection,
                parentRelations ?? new ChangeTrackingList<ParentRelation>(),
                relations ?? new ChangeTrackingList<LineageRelation>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AtlasLineageInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasLineageInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AtlasLineageInfo)} does not support writing '{options.Format}' format.");
            }
        }

        AtlasLineageInfo IPersistableModel<AtlasLineageInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AtlasLineageInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAtlasLineageInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AtlasLineageInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AtlasLineageInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AtlasLineageInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAtlasLineageInfo(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
