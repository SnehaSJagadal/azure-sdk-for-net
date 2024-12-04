// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> Defines the asset properties. </summary>
    public partial class AssetProperties
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

        /// <summary> Initializes a new instance of <see cref="AssetProperties"/>. </summary>
        /// <param name="assetEndpointProfileRef"> A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides data points for this asset. Must provide asset endpoint profile name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="assetEndpointProfileRef"/> is null. </exception>
        public AssetProperties(string assetEndpointProfileRef)
        {
            Argument.AssertNotNull(assetEndpointProfileRef, nameof(assetEndpointProfileRef));

            AssetEndpointProfileRef = assetEndpointProfileRef;
            Attributes = new ChangeTrackingDictionary<string, BinaryData>();
            DiscoveredAssetRefs = new ChangeTrackingList<string>();
            Datasets = new ChangeTrackingList<DeviceRegistryDataset>();
            Events = new ChangeTrackingList<DeviceRegistryEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="AssetProperties"/>. </summary>
        /// <param name="uuid"> Globally unique, immutable, non-reusable id. </param>
        /// <param name="enabled"> Enabled/Disabled status of the asset. </param>
        /// <param name="externalAssetId"> Asset id provided by the customer. </param>
        /// <param name="displayName"> Human-readable display name. </param>
        /// <param name="description"> Human-readable description of the asset. </param>
        /// <param name="assetEndpointProfileRef"> A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides data points for this asset. Must provide asset endpoint profile name. </param>
        /// <param name="version"> An integer that is incremented each time the resource is modified. </param>
        /// <param name="manufacturer"> Asset manufacturer name. </param>
        /// <param name="manufacturerUri"> Asset manufacturer URI. </param>
        /// <param name="model"> Asset model name. </param>
        /// <param name="productCode"> Asset product code. </param>
        /// <param name="hardwareRevision"> Revision number of the hardware. </param>
        /// <param name="softwareRevision"> Revision number of the software. </param>
        /// <param name="documentationUri"> Reference to the documentation. </param>
        /// <param name="serialNumber"> Asset serial number. </param>
        /// <param name="attributes"> A set of key-value pairs that contain custom attributes set by the customer. </param>
        /// <param name="discoveredAssetRefs"> Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered asset names must be provided. </param>
        /// <param name="defaultDatasetsConfiguration"> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultEventsConfiguration"> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultTopic"> Object that describes the default topic information for the asset. </param>
        /// <param name="datasets"> Array of datasets that are part of the asset. Each dataset describes the data points that make up the set. </param>
        /// <param name="events"> Array of events that are part of the asset. Each event can have per-event configuration. </param>
        /// <param name="status"> Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssetProperties(string uuid, bool? enabled, string externalAssetId, string displayName, string description, string assetEndpointProfileRef, long? version, string manufacturer, Uri manufacturerUri, string model, string productCode, string hardwareRevision, string softwareRevision, Uri documentationUri, string serialNumber, IDictionary<string, BinaryData> attributes, IList<string> discoveredAssetRefs, string defaultDatasetsConfiguration, string defaultEventsConfiguration, DeviceRegistryMqttTopic defaultTopic, IList<DeviceRegistryDataset> datasets, IList<DeviceRegistryEvent> events, DeviceRegistryAssetStatus status, DeviceRegistryProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Uuid = uuid;
            Enabled = enabled;
            ExternalAssetId = externalAssetId;
            DisplayName = displayName;
            Description = description;
            AssetEndpointProfileRef = assetEndpointProfileRef;
            Version = version;
            Manufacturer = manufacturer;
            ManufacturerUri = manufacturerUri;
            Model = model;
            ProductCode = productCode;
            HardwareRevision = hardwareRevision;
            SoftwareRevision = softwareRevision;
            DocumentationUri = documentationUri;
            SerialNumber = serialNumber;
            Attributes = attributes;
            DiscoveredAssetRefs = discoveredAssetRefs;
            DefaultDatasetsConfiguration = defaultDatasetsConfiguration;
            DefaultEventsConfiguration = defaultEventsConfiguration;
            DefaultTopic = defaultTopic;
            Datasets = datasets;
            Events = events;
            Status = status;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AssetProperties"/> for deserialization. </summary>
        internal AssetProperties()
        {
        }

        /// <summary> Globally unique, immutable, non-reusable id. </summary>
        public string Uuid { get; }
        /// <summary> Enabled/Disabled status of the asset. </summary>
        public bool? Enabled { get; set; }
        /// <summary> Asset id provided by the customer. </summary>
        public string ExternalAssetId { get; set; }
        /// <summary> Human-readable display name. </summary>
        public string DisplayName { get; set; }
        /// <summary> Human-readable description of the asset. </summary>
        public string Description { get; set; }
        /// <summary> A reference to the asset endpoint profile (connection information) used by brokers to connect to an endpoint that provides data points for this asset. Must provide asset endpoint profile name. </summary>
        public string AssetEndpointProfileRef { get; set; }
        /// <summary> An integer that is incremented each time the resource is modified. </summary>
        public long? Version { get; }
        /// <summary> Asset manufacturer name. </summary>
        public string Manufacturer { get; set; }
        /// <summary> Asset manufacturer URI. </summary>
        public Uri ManufacturerUri { get; set; }
        /// <summary> Asset model name. </summary>
        public string Model { get; set; }
        /// <summary> Asset product code. </summary>
        public string ProductCode { get; set; }
        /// <summary> Revision number of the hardware. </summary>
        public string HardwareRevision { get; set; }
        /// <summary> Revision number of the software. </summary>
        public string SoftwareRevision { get; set; }
        /// <summary> Reference to the documentation. </summary>
        public Uri DocumentationUri { get; set; }
        /// <summary> Asset serial number. </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// A set of key-value pairs that contain custom attributes set by the customer.
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
        public IDictionary<string, BinaryData> Attributes { get; }
        /// <summary> Reference to a list of discovered assets. Populated only if the asset has been created from discovery flow. Discovered asset names must be provided. </summary>
        public IList<string> DiscoveredAssetRefs { get; }
        /// <summary> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </summary>
        public string DefaultDatasetsConfiguration { get; set; }
        /// <summary> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </summary>
        public string DefaultEventsConfiguration { get; set; }
        /// <summary> Object that describes the default topic information for the asset. </summary>
        public DeviceRegistryMqttTopic DefaultTopic { get; set; }
        /// <summary> Array of datasets that are part of the asset. Each dataset describes the data points that make up the set. </summary>
        public IList<DeviceRegistryDataset> Datasets { get; }
        /// <summary> Array of events that are part of the asset. Each event can have per-event configuration. </summary>
        public IList<DeviceRegistryEvent> Events { get; }
        /// <summary> Read only object to reflect changes that have occurred on the Edge. Similar to Kubernetes status property for custom resources. </summary>
        public DeviceRegistryAssetStatus Status { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public DeviceRegistryProvisioningState? ProvisioningState { get; }
    }
}
