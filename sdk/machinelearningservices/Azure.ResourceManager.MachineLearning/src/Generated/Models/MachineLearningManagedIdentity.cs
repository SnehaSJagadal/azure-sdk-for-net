// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Managed identity configuration. </summary>
    public partial class MachineLearningManagedIdentity : MachineLearningIdentityConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningManagedIdentity"/>. </summary>
        public MachineLearningManagedIdentity()
        {
            IdentityType = IdentityConfigurationType.Managed;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningManagedIdentity"/>. </summary>
        /// <param name="identityType"> [Required] Specifies the type of identity framework. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="clientId"> Specifies a user-assigned identity by client ID. For system-assigned, do not set this field. </param>
        /// <param name="objectId"> Specifies a user-assigned identity by object ID. For system-assigned, do not set this field. </param>
        /// <param name="resourceId"> Specifies a user-assigned identity by ARM resource ID. For system-assigned, do not set this field. </param>
        internal MachineLearningManagedIdentity(IdentityConfigurationType identityType, IDictionary<string, BinaryData> serializedAdditionalRawData, Guid? clientId, Guid? objectId, ResourceIdentifier resourceId) : base(identityType, serializedAdditionalRawData)
        {
            ClientId = clientId;
            ObjectId = objectId;
            ResourceId = resourceId;
            IdentityType = identityType;
        }

        /// <summary> Specifies a user-assigned identity by client ID. For system-assigned, do not set this field. </summary>
        [WirePath("clientId")]
        public Guid? ClientId { get; set; }
        /// <summary> Specifies a user-assigned identity by object ID. For system-assigned, do not set this field. </summary>
        [WirePath("objectId")]
        public Guid? ObjectId { get; set; }
        /// <summary> Specifies a user-assigned identity by ARM resource ID. For system-assigned, do not set this field. </summary>
        [WirePath("resourceId")]
        public ResourceIdentifier ResourceId { get; set; }
    }
}
