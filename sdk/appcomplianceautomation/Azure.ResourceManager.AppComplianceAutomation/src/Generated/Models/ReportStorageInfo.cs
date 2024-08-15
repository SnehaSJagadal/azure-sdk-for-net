// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> The information of 'bring your own storage' account binding to the report. </summary>
    public partial class ReportStorageInfo
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

        /// <summary> Initializes a new instance of <see cref="ReportStorageInfo"/>. </summary>
        public ReportStorageInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReportStorageInfo"/>. </summary>
        /// <param name="subscriptionId"> The subscription id which 'bring your own storage' account belongs to. </param>
        /// <param name="resourceGroup"> The resourceGroup which 'bring your own storage' account belongs to. </param>
        /// <param name="accountName"> 'bring your own storage' account name. </param>
        /// <param name="location"> The region of 'bring your own storage' account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReportStorageInfo(string subscriptionId, string resourceGroup, string accountName, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubscriptionId = subscriptionId;
            ResourceGroup = resourceGroup;
            AccountName = accountName;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The subscription id which 'bring your own storage' account belongs to. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> The resourceGroup which 'bring your own storage' account belongs to. </summary>
        public string ResourceGroup { get; set; }
        /// <summary> 'bring your own storage' account name. </summary>
        public string AccountName { get; set; }
        /// <summary> The region of 'bring your own storage' account. </summary>
        public AzureLocation? Location { get; set; }
    }
}
