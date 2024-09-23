// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(StorageBlobTierChangedEventDataConverter))]
    public partial class StorageBlobTierChangedEventData
    {
        internal static StorageBlobTierChangedEventData DeserializeStorageBlobTierChangedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string api = default;
            string clientRequestId = default;
            string requestId = default;
            string contentType = default;
            long? contentLength = default;
            string blobType = default;
            StorageBlobAccessTier accessTier = default;
            StorageBlobAccessTier previousTier = default;
            string url = default;
            string sequencer = default;
            string identity = default;
            object storageDiagnostics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("api"u8))
                {
                    api = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentLength = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("blobType"u8))
                {
                    blobType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessTier"u8))
                {
                    accessTier = new StorageBlobAccessTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("previousTier"u8))
                {
                    previousTier = new StorageBlobAccessTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sequencer"u8))
                {
                    sequencer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageDiagnostics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageDiagnostics = property.Value.GetObject();
                    continue;
                }
            }
            return new StorageBlobTierChangedEventData(
                api,
                clientRequestId,
                requestId,
                contentType,
                contentLength,
                blobType,
                accessTier,
                previousTier,
                url,
                sequencer,
                identity,
                storageDiagnostics);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static StorageBlobTierChangedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeStorageBlobTierChangedEventData(document.RootElement);
        }

        internal partial class StorageBlobTierChangedEventDataConverter : JsonConverter<StorageBlobTierChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageBlobTierChangedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }

            public override StorageBlobTierChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageBlobTierChangedEventData(document.RootElement);
            }
        }
    }
}
