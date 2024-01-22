// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    /// <summary>
    /// A class representing the MarketplaceGalleryImage data model.
    /// The marketplace gallery image resource definition.
    /// </summary>
    public partial class MarketplaceGalleryImageData : TrackedResourceData
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

        /// <summary> Initializes a new instance of <see cref="MarketplaceGalleryImageData"/>. </summary>
        /// <param name="location"> The location. </param>
        public MarketplaceGalleryImageData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceGalleryImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extendedLocation of the resource. </param>
        /// <param name="containerId"> Storage ContainerID of the storage container to be used for marketplace gallery image. </param>
        /// <param name="osType"> Operating system type that the gallery image uses [Windows, Linux]. </param>
        /// <param name="cloudInitDataSource"> Datasource for the gallery image when provisioning with cloud-init [NoCloud, Azure]. </param>
        /// <param name="hyperVGeneration"> The hypervisor generation of the Virtual Machine [V1, V2]. </param>
        /// <param name="identifier"> This is the gallery image definition identifier. </param>
        /// <param name="version"> Specifies information about the gallery image version that you want to create or update. </param>
        /// <param name="provisioningState"> Provisioning state of the marketplace gallery image. </param>
        /// <param name="status"> The observed state of marketplace gallery images. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MarketplaceGalleryImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ArcVmExtendedLocation extendedLocation, ResourceIdentifier containerId, OperatingSystemType? osType, CloudInitDataSource? cloudInitDataSource, HyperVGeneration? hyperVGeneration, GalleryImageIdentifier identifier, GalleryImageVersion version, ProvisioningStateEnum? provisioningState, MarketplaceGalleryImageStatus status, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            ContainerId = containerId;
            OSType = osType;
            CloudInitDataSource = cloudInitDataSource;
            HyperVGeneration = hyperVGeneration;
            Identifier = identifier;
            Version = version;
            ProvisioningState = provisioningState;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MarketplaceGalleryImageData"/> for deserialization. </summary>
        internal MarketplaceGalleryImageData()
        {
        }

        /// <summary> The extendedLocation of the resource. </summary>
        public ArcVmExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Storage ContainerID of the storage container to be used for marketplace gallery image. </summary>
        public ResourceIdentifier ContainerId { get; set; }
        /// <summary> Operating system type that the gallery image uses [Windows, Linux]. </summary>
        public OperatingSystemType? OSType { get; set; }
        /// <summary> Datasource for the gallery image when provisioning with cloud-init [NoCloud, Azure]. </summary>
        public CloudInitDataSource? CloudInitDataSource { get; set; }
        /// <summary> The hypervisor generation of the Virtual Machine [V1, V2]. </summary>
        public HyperVGeneration? HyperVGeneration { get; set; }
        /// <summary> This is the gallery image definition identifier. </summary>
        public GalleryImageIdentifier Identifier { get; set; }
        /// <summary> Specifies information about the gallery image version that you want to create or update. </summary>
        public GalleryImageVersion Version { get; set; }
        /// <summary> Provisioning state of the marketplace gallery image. </summary>
        public ProvisioningStateEnum? ProvisioningState { get; }
        /// <summary> The observed state of marketplace gallery images. </summary>
        public MarketplaceGalleryImageStatus Status { get; }
    }
}
