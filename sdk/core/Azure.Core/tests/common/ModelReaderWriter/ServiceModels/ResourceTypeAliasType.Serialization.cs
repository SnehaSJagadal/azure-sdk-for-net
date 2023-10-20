// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Core.Tests.ResourceManager.Resources.Models
{
    internal static partial class ResourceTypeAliasTypeExtensions
    {
        public static string ToSerialString(this ResourceTypeAliasType value) => value switch
        {
            ResourceTypeAliasType.NotSpecified => "NotSpecified",
            ResourceTypeAliasType.PlainText => "PlainText",
            ResourceTypeAliasType.Mask => "Mask",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceTypeAliasType value.")
        };

        public static ResourceTypeAliasType ToResourceTypeAliasType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSpecified")) return ResourceTypeAliasType.NotSpecified;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "PlainText")) return ResourceTypeAliasType.PlainText;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Mask")) return ResourceTypeAliasType.Mask;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ResourceTypeAliasType value.");
        }
    }
}
