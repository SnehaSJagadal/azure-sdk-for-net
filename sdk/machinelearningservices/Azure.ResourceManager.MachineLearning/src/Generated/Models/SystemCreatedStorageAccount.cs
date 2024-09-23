// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The SystemCreatedStorageAccount. </summary>
    public partial class SystemCreatedStorageAccount
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

        /// <summary> Initializes a new instance of <see cref="SystemCreatedStorageAccount"/>. </summary>
        public SystemCreatedStorageAccount()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SystemCreatedStorageAccount"/>. </summary>
        /// <param name="allowBlobPublicAccess"> Public blob access allowed. </param>
        /// <param name="armResourceIdentifier"> This is populated once the storage account is created. </param>
        /// <param name="storageAccountHnsEnabled"> HNS enabled for storage account. </param>
        /// <param name="storageAccountName"> Name of the storage account. </param>
        /// <param name="storageAccountType">
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SystemCreatedStorageAccount(bool? allowBlobPublicAccess, ArmResourceId armResourceIdentifier, bool? storageAccountHnsEnabled, string storageAccountName, string storageAccountType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowBlobPublicAccess = allowBlobPublicAccess;
            ArmResourceIdentifier = armResourceIdentifier;
            StorageAccountHnsEnabled = storageAccountHnsEnabled;
            StorageAccountName = storageAccountName;
            StorageAccountType = storageAccountType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Public blob access allowed. </summary>
        [WirePath("allowBlobPublicAccess")]
        public bool? AllowBlobPublicAccess { get; set; }
        /// <summary> This is populated once the storage account is created. </summary>
        internal ArmResourceId ArmResourceIdentifier { get; set; }
        /// <summary>
        /// Arm ResourceId is in the format "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.Storage/storageAccounts/{StorageAccountName}"
        /// or "/subscriptions/{SubscriptionId}/resourceGroups/{ResourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{AcrName}"
        /// </summary>
        [WirePath("armResourceId.resourceId")]
        public ResourceIdentifier ArmResourceId
        {
            get => ArmResourceIdentifier is null ? default : ArmResourceIdentifier.ResourceId;
            set
            {
                if (ArmResourceIdentifier is null)
                    ArmResourceIdentifier = new ArmResourceId();
                ArmResourceIdentifier.ResourceId = value;
            }
        }

        /// <summary> HNS enabled for storage account. </summary>
        [WirePath("storageAccountHnsEnabled")]
        public bool? StorageAccountHnsEnabled { get; set; }
        /// <summary> Name of the storage account. </summary>
        [WirePath("storageAccountName")]
        public string StorageAccountName { get; set; }
        /// <summary>
        /// Allowed values:
        /// "Standard_LRS",
        /// "Standard_GRS",
        /// "Standard_RAGRS",
        /// "Standard_ZRS",
        /// "Standard_GZRS",
        /// "Standard_RAGZRS",
        /// "Premium_LRS",
        /// "Premium_ZRS"
        /// </summary>
        [WirePath("storageAccountType")]
        public string StorageAccountType { get; set; }
    }
}
