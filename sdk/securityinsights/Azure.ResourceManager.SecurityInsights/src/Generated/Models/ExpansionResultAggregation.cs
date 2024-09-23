// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Information of a specific aggregation in the expansion result. </summary>
    public partial class ExpansionResultAggregation
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ExpansionResultAggregation"/>. </summary>
        /// <param name="count"> Total number of aggregations of the given kind (and aggregationType if given) in the expansion result. </param>
        /// <param name="entityKind"> The kind of the aggregated entity. </param>
        internal ExpansionResultAggregation(int count, SecurityInsightsEntityKind entityKind)
        {
            Count = count;
            EntityKind = entityKind;
        }

        /// <summary> Initializes a new instance of <see cref="ExpansionResultAggregation"/>. </summary>
        /// <param name="aggregationType"> The common type of the aggregation. (for e.g. entity field name). </param>
        /// <param name="count"> Total number of aggregations of the given kind (and aggregationType if given) in the expansion result. </param>
        /// <param name="displayName"> The display name of the aggregation by type. </param>
        /// <param name="entityKind"> The kind of the aggregated entity. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExpansionResultAggregation(string aggregationType, int count, string displayName, SecurityInsightsEntityKind entityKind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AggregationType = aggregationType;
            Count = count;
            DisplayName = displayName;
            EntityKind = entityKind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ExpansionResultAggregation"/> for deserialization. </summary>
        internal ExpansionResultAggregation()
        {
        }

        /// <summary> The common type of the aggregation. (for e.g. entity field name). </summary>
        [WirePath("aggregationType")]
        public string AggregationType { get; }
        /// <summary> Total number of aggregations of the given kind (and aggregationType if given) in the expansion result. </summary>
        [WirePath("count")]
        public int Count { get; }
        /// <summary> The display name of the aggregation by type. </summary>
        [WirePath("displayName")]
        public string DisplayName { get; }
        /// <summary> The kind of the aggregated entity. </summary>
        [WirePath("entityKind")]
        public SecurityInsightsEntityKind EntityKind { get; }
    }
}
