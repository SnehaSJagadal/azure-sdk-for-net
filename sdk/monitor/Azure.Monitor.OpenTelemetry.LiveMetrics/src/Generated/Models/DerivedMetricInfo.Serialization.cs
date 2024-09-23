// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class DerivedMetricInfo
    {
        internal static DerivedMetricInfo DeserializeDerivedMetricInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            string telemetryType = default;
            IReadOnlyList<FilterConjunctionGroupInfo> filterGroups = default;
            string projection = default;
            AggregationType aggregation = default;
            AggregationType backEndAggregation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("TelemetryType"u8))
                {
                    telemetryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("FilterGroups"u8))
                {
                    List<FilterConjunctionGroupInfo> array = new List<FilterConjunctionGroupInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilterConjunctionGroupInfo.DeserializeFilterConjunctionGroupInfo(item));
                    }
                    filterGroups = array;
                    continue;
                }
                if (property.NameEquals("Projection"u8))
                {
                    projection = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Aggregation"u8))
                {
                    aggregation = new AggregationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("BackEndAggregation"u8))
                {
                    backEndAggregation = new AggregationType(property.Value.GetString());
                    continue;
                }
            }
            return new DerivedMetricInfo(
                id,
                telemetryType,
                filterGroups,
                projection,
                aggregation,
                backEndAggregation);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DerivedMetricInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeDerivedMetricInfo(document.RootElement);
        }
    }
}
