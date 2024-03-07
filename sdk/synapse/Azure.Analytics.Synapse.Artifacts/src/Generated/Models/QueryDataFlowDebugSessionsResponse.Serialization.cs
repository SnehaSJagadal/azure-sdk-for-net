// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(QueryDataFlowDebugSessionsResponseConverter))]
    internal partial class QueryDataFlowDebugSessionsResponse
    {
        internal static QueryDataFlowDebugSessionsResponse DeserializeQueryDataFlowDebugSessionsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataFlowDebugSessionInfo> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowDebugSessionInfo> array = new List<DataFlowDebugSessionInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowDebugSessionInfo.DeserializeDataFlowDebugSessionInfo(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new QueryDataFlowDebugSessionsResponse(value ?? new ChangeTrackingList<DataFlowDebugSessionInfo>(), nextLink);
        }

        internal partial class QueryDataFlowDebugSessionsResponseConverter : JsonConverter<QueryDataFlowDebugSessionsResponse>
        {
            public override void Write(Utf8JsonWriter writer, QueryDataFlowDebugSessionsResponse model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override QueryDataFlowDebugSessionsResponse Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeQueryDataFlowDebugSessionsResponse(document.RootElement);
            }
        }
    }
}
