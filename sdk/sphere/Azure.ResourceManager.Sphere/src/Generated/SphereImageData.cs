// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing the SphereImage data model.
    /// An image resource belonging to a catalog resource.
    /// </summary>
    public partial class SphereImageData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SphereImageData"/>. </summary>
        public SphereImageData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereImageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="image"> Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads. </param>
        /// <param name="imageId"> Image ID. </param>
        /// <param name="imageName"> Image name. </param>
        /// <param name="regionalDataBoundary"> Regional data boundary for an image. </param>
        /// <param name="uri"> Location the image. </param>
        /// <param name="description"> The image description. </param>
        /// <param name="componentId"> The image component id. </param>
        /// <param name="imageType"> The image type. </param>
        /// <param name="provisioningState"> The status of the last operation. </param>
        internal SphereImageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string image, string imageId, string imageName, RegionalDataBoundary? regionalDataBoundary, Uri uri, string description, string componentId, SphereImageType? imageType, SphereProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            Image = image;
            ImageId = imageId;
            ImageName = imageName;
            RegionalDataBoundary = regionalDataBoundary;
            Uri = uri;
            Description = description;
            ComponentId = componentId;
            ImageType = imageType;
            ProvisioningState = provisioningState;
        }

        /// <summary> Image as a UTF-8 encoded base 64 string on image create. This field contains the image URI on image reads. </summary>
        public string Image { get; set; }
        /// <summary> Image ID. </summary>
        public string ImageId { get; set; }
        /// <summary> Image name. </summary>
        public string ImageName { get; }
        /// <summary> Regional data boundary for an image. </summary>
        public RegionalDataBoundary? RegionalDataBoundary { get; set; }
        /// <summary> Location the image. </summary>
        public Uri Uri { get; }
        /// <summary> The image description. </summary>
        public string Description { get; }
        /// <summary> The image component id. </summary>
        public string ComponentId { get; }
        /// <summary> The image type. </summary>
        public SphereImageType? ImageType { get; }
        /// <summary> The status of the last operation. </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}
