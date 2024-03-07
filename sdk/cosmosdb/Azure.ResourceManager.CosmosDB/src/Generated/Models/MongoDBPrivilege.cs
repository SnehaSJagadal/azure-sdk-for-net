// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The set of data plane operations permitted through this Role Definition. </summary>
    public partial class MongoDBPrivilege
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

        /// <summary> Initializes a new instance of <see cref="MongoDBPrivilege"/>. </summary>
        public MongoDBPrivilege()
        {
            Actions = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBPrivilege"/>. </summary>
        /// <param name="resource"> An Azure Cosmos DB Mongo DB Resource. </param>
        /// <param name="actions"> An array of actions that are allowed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBPrivilege(MongoDBPrivilegeResourceInfo resource, IList<string> actions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Resource = resource;
            Actions = actions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> An Azure Cosmos DB Mongo DB Resource. </summary>
        public MongoDBPrivilegeResourceInfo Resource { get; set; }
        /// <summary> An array of actions that are allowed. </summary>
        public IList<string> Actions { get; }
    }
}
