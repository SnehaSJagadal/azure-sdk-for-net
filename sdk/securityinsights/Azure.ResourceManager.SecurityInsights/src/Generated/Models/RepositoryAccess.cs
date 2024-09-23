// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Credentials to access repository. </summary>
    public partial class RepositoryAccess
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

        /// <summary> Initializes a new instance of <see cref="RepositoryAccess"/>. </summary>
        /// <param name="kind"> The kind of repository access credentials. </param>
        public RepositoryAccess(RepositoryAccessKind kind)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="RepositoryAccess"/>. </summary>
        /// <param name="kind"> The kind of repository access credentials. </param>
        /// <param name="code"> OAuth Code. Required when `kind` is `OAuth`. </param>
        /// <param name="state"> OAuth State. Required when `kind` is `OAuth`. </param>
        /// <param name="clientId"> OAuth ClientId. Required when `kind` is `OAuth`. </param>
        /// <param name="token"> Personal Access Token. Required when `kind` is `PAT`. </param>
        /// <param name="installationId"> Application installation ID. Required when `kind` is `App`. Supported by `GitHub` only. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RepositoryAccess(RepositoryAccessKind kind, string code, string state, string clientId, string token, string installationId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            Code = code;
            State = state;
            ClientId = clientId;
            Token = token;
            InstallationId = installationId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RepositoryAccess"/> for deserialization. </summary>
        internal RepositoryAccess()
        {
        }

        /// <summary> The kind of repository access credentials. </summary>
        [WirePath("kind")]
        public RepositoryAccessKind Kind { get; set; }
        /// <summary> OAuth Code. Required when `kind` is `OAuth`. </summary>
        [WirePath("code")]
        public string Code { get; set; }
        /// <summary> OAuth State. Required when `kind` is `OAuth`. </summary>
        [WirePath("state")]
        public string State { get; set; }
        /// <summary> OAuth ClientId. Required when `kind` is `OAuth`. </summary>
        [WirePath("clientId")]
        public string ClientId { get; set; }
        /// <summary> Personal Access Token. Required when `kind` is `PAT`. </summary>
        [WirePath("token")]
        public string Token { get; set; }
        /// <summary> Application installation ID. Required when `kind` is `App`. Supported by `GitHub` only. </summary>
        [WirePath("installationId")]
        public string InstallationId { get; set; }
    }
}
