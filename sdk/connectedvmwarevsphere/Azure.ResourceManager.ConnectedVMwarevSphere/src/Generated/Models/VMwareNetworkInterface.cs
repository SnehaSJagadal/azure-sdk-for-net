// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Network Interface model. </summary>
    public partial class VMwareNetworkInterface
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

        /// <summary> Initializes a new instance of <see cref="VMwareNetworkInterface"/>. </summary>
        public VMwareNetworkInterface()
        {
            IPAddresses = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VMwareNetworkInterface"/>. </summary>
        /// <param name="name"> Gets or sets the name of the network interface. </param>
        /// <param name="label"> Gets or sets the label of the virtual network in vCenter that the nic is connected to. </param>
        /// <param name="ipAddresses"> Gets or sets the nic ip addresses. </param>
        /// <param name="macAddress"> Gets or sets the NIC MAC address. </param>
        /// <param name="networkId"> Gets or sets the ARM Id of the network resource to connect the virtual machine. </param>
        /// <param name="nicType"> NIC type. </param>
        /// <param name="powerOnBoot"> Gets or sets the power on boot. </param>
        /// <param name="networkMoRefId">
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID of the virtual network
        /// that the nic is connected to.
        /// </param>
        /// <param name="networkMoName"> Gets or sets the name of the virtual network in vCenter that the nic is connected to. </param>
        /// <param name="deviceKey"> Gets or sets the device key value. </param>
        /// <param name="ipSettings"> Gets or sets the ipsettings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareNetworkInterface(string name, string label, IReadOnlyList<string> ipAddresses, string macAddress, string networkId, VMwareNicType? nicType, PowerOnBootOption? powerOnBoot, string networkMoRefId, string networkMoName, int? deviceKey, NicIPSettings ipSettings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Label = label;
            IPAddresses = ipAddresses;
            MacAddress = macAddress;
            NetworkId = networkId;
            NicType = nicType;
            PowerOnBoot = powerOnBoot;
            NetworkMoRefId = networkMoRefId;
            NetworkMoName = networkMoName;
            DeviceKey = deviceKey;
            IPSettings = ipSettings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the name of the network interface. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the label of the virtual network in vCenter that the nic is connected to. </summary>
        public string Label { get; }
        /// <summary> Gets or sets the nic ip addresses. </summary>
        public IReadOnlyList<string> IPAddresses { get; }
        /// <summary> Gets or sets the NIC MAC address. </summary>
        public string MacAddress { get; }
        /// <summary> Gets or sets the ARM Id of the network resource to connect the virtual machine. </summary>
        public string NetworkId { get; set; }
        /// <summary> NIC type. </summary>
        public VMwareNicType? NicType { get; set; }
        /// <summary> Gets or sets the power on boot. </summary>
        public PowerOnBootOption? PowerOnBoot { get; set; }
        /// <summary>
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID of the virtual network
        /// that the nic is connected to.
        /// </summary>
        public string NetworkMoRefId { get; }
        /// <summary> Gets or sets the name of the virtual network in vCenter that the nic is connected to. </summary>
        public string NetworkMoName { get; }
        /// <summary> Gets or sets the device key value. </summary>
        public int? DeviceKey { get; set; }
        /// <summary> Gets or sets the ipsettings. </summary>
        public NicIPSettings IPSettings { get; set; }
    }
}
