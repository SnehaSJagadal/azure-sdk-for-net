// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonObject
    {
        internal static GeoJsonObject DeserializeGeoJsonObject(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Boundary": return BoundaryInternal.DeserializeBoundaryInternal(element);
                    case "Feature": return GeoJsonFeature.DeserializeGeoJsonFeature(element);
                    case "FeatureCollection": return GeoJsonFeatureCollection.DeserializeGeoJsonFeatureCollection(element);
                    case "GeoJsonGeometry": return GeoJsonGeometry.DeserializeGeoJsonGeometry(element);
                    case "GeometryCollection": return GeoJsonGeometryCollection.DeserializeGeoJsonGeometryCollection(element);
                    case "LineString": return GeoJsonLineString.DeserializeGeoJsonLineString(element);
                    case "MultiLineString": return GeoJsonMultiLineString.DeserializeGeoJsonMultiLineString(element);
                    case "MultiPoint": return GeoJsonMultiPoint.DeserializeGeoJsonMultiPoint(element);
                    case "MultiPolygon": return GeoJsonMultiPolygon.DeserializeGeoJsonMultiPolygon(element);
                    case "Point": return GeoJsonPoint.DeserializeGeoJsonPoint(element);
                    case "Polygon": return GeoJsonPolygon.DeserializeGeoJsonPolygon(element);
                }
            }
            return UnknownGeoJsonObject.DeserializeUnknownGeoJsonObject(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static GeoJsonObject FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeGeoJsonObject(document.RootElement);
        }
    }
}
