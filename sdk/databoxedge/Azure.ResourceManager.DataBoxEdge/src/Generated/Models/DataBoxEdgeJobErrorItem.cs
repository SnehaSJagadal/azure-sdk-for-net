// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The job error items. </summary>
    public partial class DataBoxEdgeJobErrorItem
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

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeJobErrorItem"/>. </summary>
        internal DataBoxEdgeJobErrorItem()
        {
            Recommendations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeJobErrorItem"/>. </summary>
        /// <param name="recommendations"> The recommended actions. </param>
        /// <param name="code"> The code intended for programmatic access. </param>
        /// <param name="message"> The message that describes the error in detail. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeJobErrorItem(IReadOnlyList<string> recommendations, string code, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Recommendations = recommendations;
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The recommended actions. </summary>
        public IReadOnlyList<string> Recommendations { get; }
        /// <summary> The code intended for programmatic access. </summary>
        public string Code { get; }
        /// <summary> The message that describes the error in detail. </summary>
        public string Message { get; }
    }
}
