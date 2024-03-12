// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The custom setup of installing 3rd party components. </summary>
    public partial class ComponentSetup : CustomSetupBase
    {
        /// <summary> Initializes a new instance of <see cref="ComponentSetup"/>. </summary>
        /// <param name="componentName"> The name of the 3rd party component. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="componentName"/> is null. </exception>
        public ComponentSetup(string componentName)
        {
            Argument.AssertNotNull(componentName, nameof(componentName));

            ComponentName = componentName;
            CustomSetupBaseType = "ComponentSetup";
        }

        /// <summary> Initializes a new instance of <see cref="ComponentSetup"/>. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="componentName"> The name of the 3rd party component. </param>
        /// <param name="licenseKey"> The license key to activate the component. </param>
        internal ComponentSetup(string customSetupBaseType, IDictionary<string, BinaryData> serializedAdditionalRawData, string componentName, DataFactorySecret licenseKey) : base(customSetupBaseType, serializedAdditionalRawData)
        {
            ComponentName = componentName;
            LicenseKey = licenseKey;
            CustomSetupBaseType = customSetupBaseType ?? "ComponentSetup";
        }

        /// <summary> Initializes a new instance of <see cref="ComponentSetup"/> for deserialization. </summary>
        internal ComponentSetup()
        {
        }

        /// <summary> The name of the 3rd party component. </summary>
        public string ComponentName { get; set; }
        /// <summary> The license key to activate the component. </summary>
        public DataFactorySecret LicenseKey { get; set; }
    }
}
