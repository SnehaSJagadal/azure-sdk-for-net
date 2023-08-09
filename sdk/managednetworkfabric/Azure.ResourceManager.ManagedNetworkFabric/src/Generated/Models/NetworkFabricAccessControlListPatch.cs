// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The Access Control Lists patch resource definition. </summary>
    public partial class NetworkFabricAccessControlListPatch : NetworkRackPatch
    {
        /// <summary> Initializes a new instance of NetworkFabricAccessControlListPatch. </summary>
        public NetworkFabricAccessControlListPatch()
        {
            MatchConfigurations = new ChangeTrackingList<AccessControlListMatchConfiguration>();
            DynamicMatchConfigurations = new ChangeTrackingList<CommonDynamicMatchConfiguration>();
        }

        /// <summary> Input method to configure Access Control List. </summary>
        public NetworkFabricConfigurationType? ConfigurationType { get; set; }
        /// <summary> Access Control List file URL. </summary>
        public Uri AclsUri { get; set; }
        /// <summary> List of match configurations. </summary>
        public IList<AccessControlListMatchConfiguration> MatchConfigurations { get; }
        /// <summary> List of dynamic match configurations. </summary>
        public IList<CommonDynamicMatchConfiguration> DynamicMatchConfigurations { get; }
        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
    }
}
