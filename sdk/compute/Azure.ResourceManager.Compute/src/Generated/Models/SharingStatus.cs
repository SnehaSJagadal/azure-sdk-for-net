// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Sharing status of current gallery. </summary>
    public partial class SharingStatus
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

        /// <summary> Initializes a new instance of <see cref="SharingStatus"/>. </summary>
        internal SharingStatus()
        {
            Summary = new ChangeTrackingList<RegionalSharingStatus>();
        }

        /// <summary> Initializes a new instance of <see cref="SharingStatus"/>. </summary>
        /// <param name="aggregatedState"> Aggregated sharing state of current gallery. </param>
        /// <param name="summary"> Summary of all regional sharing status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharingStatus(SharingState? aggregatedState, IReadOnlyList<RegionalSharingStatus> summary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AggregatedState = aggregatedState;
            Summary = summary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Aggregated sharing state of current gallery. </summary>
        public SharingState? AggregatedState { get; }
        /// <summary> Summary of all regional sharing status. </summary>
        public IReadOnlyList<RegionalSharingStatus> Summary { get; }
    }
}
