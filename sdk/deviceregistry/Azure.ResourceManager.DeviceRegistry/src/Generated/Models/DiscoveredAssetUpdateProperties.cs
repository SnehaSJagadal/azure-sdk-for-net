// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    /// <summary> The updatable properties of the DiscoveredAsset. </summary>
    public partial class DiscoveredAssetUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="DiscoveredAssetUpdateProperties"/>. </summary>
        public DiscoveredAssetUpdateProperties()
        {
            Datasets = new ChangeTrackingList<DiscoveredDataset>();
            Events = new ChangeTrackingList<DiscoveredEvent>();
        }

        /// <summary> Initializes a new instance of <see cref="DiscoveredAssetUpdateProperties"/>. </summary>
        /// <param name="discoveryId"> Identifier used to detect changes in the asset. </param>
        /// <param name="version"> An integer that is incremented each time the resource is modified. </param>
        /// <param name="manufacturer"> Asset manufacturer name. </param>
        /// <param name="manufacturerUri"> Asset manufacturer URI. </param>
        /// <param name="model"> Asset model name. </param>
        /// <param name="productCode"> Asset product code. </param>
        /// <param name="hardwareRevision"> Revision number of the hardware. </param>
        /// <param name="softwareRevision"> Revision number of the software. </param>
        /// <param name="documentationUri"> Reference to the documentation. </param>
        /// <param name="serialNumber"> Asset serial number. </param>
        /// <param name="defaultDatasetsConfiguration"> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultEventsConfiguration"> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </param>
        /// <param name="defaultTopic"> Object that describes the default topic information for the asset. </param>
        /// <param name="datasets"> Array of datasets that are part of the asset. Each dataset spec describes the data points that make up the set. </param>
        /// <param name="events"> Array of events that are part of the asset. Each event can have per-event configuration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiscoveredAssetUpdateProperties(string discoveryId, long? version, string manufacturer, Uri manufacturerUri, string model, string productCode, string hardwareRevision, string softwareRevision, Uri documentationUri, string serialNumber, string defaultDatasetsConfiguration, string defaultEventsConfiguration, DeviceRegistryMqttTopic defaultTopic, IList<DiscoveredDataset> datasets, IList<DiscoveredEvent> events, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DiscoveryId = discoveryId;
            Version = version;
            Manufacturer = manufacturer;
            ManufacturerUri = manufacturerUri;
            Model = model;
            ProductCode = productCode;
            HardwareRevision = hardwareRevision;
            SoftwareRevision = softwareRevision;
            DocumentationUri = documentationUri;
            SerialNumber = serialNumber;
            DefaultDatasetsConfiguration = defaultDatasetsConfiguration;
            DefaultEventsConfiguration = defaultEventsConfiguration;
            DefaultTopic = defaultTopic;
            Datasets = datasets;
            Events = events;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Identifier used to detect changes in the asset. </summary>
        public string DiscoveryId { get; set; }
        /// <summary> An integer that is incremented each time the resource is modified. </summary>
        public long? Version { get; set; }
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
        /// <summary> Stringified JSON that contains connector-specific default configuration for all datasets. Each dataset can have its own configuration that overrides the default settings here. </summary>
        public string DefaultDatasetsConfiguration { get; set; }
        /// <summary> Stringified JSON that contains connector-specific default configuration for all events. Each event can have its own configuration that overrides the default settings here. </summary>
        public string DefaultEventsConfiguration { get; set; }
        /// <summary> Object that describes the default topic information for the asset. </summary>
        public DeviceRegistryMqttTopic DefaultTopic { get; set; }
        /// <summary> Array of datasets that are part of the asset. Each dataset spec describes the data points that make up the set. </summary>
        public IList<DiscoveredDataset> Datasets { get; }
        /// <summary> Array of events that are part of the asset. Each event can have per-event configuration. </summary>
        public IList<DiscoveredEvent> Events { get; }
    }
}
