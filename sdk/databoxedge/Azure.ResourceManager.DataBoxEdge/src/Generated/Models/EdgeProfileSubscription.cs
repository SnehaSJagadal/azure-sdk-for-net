// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Subscription details for the Edge Profile. </summary>
    public partial class EdgeProfileSubscription
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

        /// <summary> Initializes a new instance of <see cref="EdgeProfileSubscription"/>. </summary>
        internal EdgeProfileSubscription()
        {
            RegisteredFeatures = new ChangeTrackingList<SubscriptionRegisteredFeatures>();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeProfileSubscription"/>. </summary>
        /// <param name="registrationId"> Edge Subscription Registration ID. </param>
        /// <param name="id"> ARM ID of the subscription. </param>
        /// <param name="state"></param>
        /// <param name="registrationDate"></param>
        /// <param name="subscriptionId"></param>
        /// <param name="tenantId"></param>
        /// <param name="locationPlacementId"></param>
        /// <param name="quotaId"></param>
        /// <param name="serializedDetails"></param>
        /// <param name="registeredFeatures"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeProfileSubscription(Guid? registrationId, ResourceIdentifier id, DataBoxEdgeSubscriptionState? state, string registrationDate, string subscriptionId, Guid? tenantId, string locationPlacementId, string quotaId, string serializedDetails, IReadOnlyList<SubscriptionRegisteredFeatures> registeredFeatures, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RegistrationId = registrationId;
            Id = id;
            State = state;
            RegistrationDate = registrationDate;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
            LocationPlacementId = locationPlacementId;
            QuotaId = quotaId;
            SerializedDetails = serializedDetails;
            RegisteredFeatures = registeredFeatures;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Edge Subscription Registration ID. </summary>
        public Guid? RegistrationId { get; }
        /// <summary> ARM ID of the subscription. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Gets the state. </summary>
        public DataBoxEdgeSubscriptionState? State { get; }
        /// <summary> Gets the registration date. </summary>
        public string RegistrationDate { get; }
        /// <summary> Gets the subscription id. </summary>
        public string SubscriptionId { get; }
        /// <summary> Gets the tenant id. </summary>
        public Guid? TenantId { get; }
        /// <summary> Gets the location placement id. </summary>
        public string LocationPlacementId { get; }
        /// <summary> Gets the quota id. </summary>
        public string QuotaId { get; }
        /// <summary> Gets the serialized details. </summary>
        public string SerializedDetails { get; }
        /// <summary> Gets the registered features. </summary>
        public IReadOnlyList<SubscriptionRegisteredFeatures> RegisteredFeatures { get; }
    }
}
