// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Describes the request body for triggering a playbook on an entity. </summary>
    public partial class EntityManualTriggerRequestContent
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

        /// <summary> Initializes a new instance of <see cref="EntityManualTriggerRequestContent"/>. </summary>
        /// <param name="logicAppsResourceId"> The resource id of the playbook resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="logicAppsResourceId"/> is null. </exception>
        public EntityManualTriggerRequestContent(ResourceIdentifier logicAppsResourceId)
        {
            Argument.AssertNotNull(logicAppsResourceId, nameof(logicAppsResourceId));

            LogicAppsResourceId = logicAppsResourceId;
        }

        /// <summary> Initializes a new instance of <see cref="EntityManualTriggerRequestContent"/>. </summary>
        /// <param name="incidentArmId"> Incident ARM id. </param>
        /// <param name="tenantId"> The tenant id of the playbook resource. </param>
        /// <param name="logicAppsResourceId"> The resource id of the playbook resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityManualTriggerRequestContent(ResourceIdentifier incidentArmId, Guid? tenantId, ResourceIdentifier logicAppsResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IncidentArmId = incidentArmId;
            TenantId = tenantId;
            LogicAppsResourceId = logicAppsResourceId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="EntityManualTriggerRequestContent"/> for deserialization. </summary>
        internal EntityManualTriggerRequestContent()
        {
        }

        /// <summary> Incident ARM id. </summary>
        [WirePath("incidentArmId")]
        public ResourceIdentifier IncidentArmId { get; set; }
        /// <summary> The tenant id of the playbook resource. </summary>
        [WirePath("tenantId")]
        public Guid? TenantId { get; set; }
        /// <summary> The resource id of the playbook resource. </summary>
        [WirePath("logicAppsResourceId")]
        public ResourceIdentifier LogicAppsResourceId { get; }
    }
}
