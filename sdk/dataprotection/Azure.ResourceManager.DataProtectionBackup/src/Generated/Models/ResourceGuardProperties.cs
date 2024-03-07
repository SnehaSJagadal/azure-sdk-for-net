// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The ResourceGuardProperties. </summary>
    public partial class ResourceGuardProperties
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

        /// <summary> Initializes a new instance of <see cref="ResourceGuardProperties"/>. </summary>
        public ResourceGuardProperties()
        {
            ResourceGuardOperations = new ChangeTrackingList<ResourceGuardOperationDetails>();
            VaultCriticalOperationExclusionList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGuardProperties"/>. </summary>
        /// <param name="provisioningState"> Provisioning state of the BackupVault resource. </param>
        /// <param name="isAutoApprovalsAllowed"> This flag indicates whether auto approval is allowed or not. </param>
        /// <param name="resourceGuardOperations"> {readonly} List of operation details those are protected by the ResourceGuard resource. </param>
        /// <param name="vaultCriticalOperationExclusionList"> List of critical operations which are not protected by this resourceGuard. </param>
        /// <param name="description"> Description about the pre-req steps to perform all the critical operations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceGuardProperties(DataProtectionBackupProvisioningState? provisioningState, bool? isAutoApprovalsAllowed, IReadOnlyList<ResourceGuardOperationDetails> resourceGuardOperations, IList<string> vaultCriticalOperationExclusionList, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            IsAutoApprovalsAllowed = isAutoApprovalsAllowed;
            ResourceGuardOperations = resourceGuardOperations;
            VaultCriticalOperationExclusionList = vaultCriticalOperationExclusionList;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provisioning state of the BackupVault resource. </summary>
        public DataProtectionBackupProvisioningState? ProvisioningState { get; }
        /// <summary> This flag indicates whether auto approval is allowed or not. </summary>
        public bool? IsAutoApprovalsAllowed { get; }
        /// <summary> {readonly} List of operation details those are protected by the ResourceGuard resource. </summary>
        public IReadOnlyList<ResourceGuardOperationDetails> ResourceGuardOperations { get; }
        /// <summary> List of critical operations which are not protected by this resourceGuard. </summary>
        public IList<string> VaultCriticalOperationExclusionList { get; }
        /// <summary> Description about the pre-req steps to perform all the critical operations. </summary>
        public string Description { get; }
    }
}
