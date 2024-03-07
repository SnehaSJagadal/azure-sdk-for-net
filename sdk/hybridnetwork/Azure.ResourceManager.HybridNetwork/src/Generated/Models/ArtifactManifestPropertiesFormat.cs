// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Artifact manifest properties. </summary>
    public partial class ArtifactManifestPropertiesFormat
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

        /// <summary> Initializes a new instance of <see cref="ArtifactManifestPropertiesFormat"/>. </summary>
        public ArtifactManifestPropertiesFormat()
        {
            Artifacts = new ChangeTrackingList<ManifestArtifactFormat>();
        }

        /// <summary> Initializes a new instance of <see cref="ArtifactManifestPropertiesFormat"/>. </summary>
        /// <param name="provisioningState"> The provisioning state of the ArtifactManifest resource. </param>
        /// <param name="artifactManifestState"> The artifact manifest state. </param>
        /// <param name="artifacts"> The artifacts list. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArtifactManifestPropertiesFormat(ProvisioningState? provisioningState, ArtifactManifestState? artifactManifestState, IList<ManifestArtifactFormat> artifacts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            ArtifactManifestState = artifactManifestState;
            Artifacts = artifacts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The provisioning state of the ArtifactManifest resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The artifact manifest state. </summary>
        public ArtifactManifestState? ArtifactManifestState { get; }
        /// <summary> The artifacts list. </summary>
        public IList<ManifestArtifactFormat> Artifacts { get; }
    }
}
