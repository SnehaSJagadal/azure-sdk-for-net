// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class CustomImageList
    {
        internal static CustomImageList DeserializeCustomImageList(JsonElement element)
        {
            Optional<IReadOnlyList<CustomImageData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CustomImageData> array = new List<CustomImageData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomImageData.DeserializeCustomImageData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new CustomImageList(Optional.ToList(value), nextLink.Value);
        }
    }
}
