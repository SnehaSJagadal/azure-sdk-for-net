// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// An object that defines the blob inventory rule.
/// </summary>
public partial class BlobInventoryPolicyDefinition : ProvisioningConstruct
{
    /// <summary>
    /// An object that defines the filter set.
    /// </summary>
    public BicepValue<BlobInventoryPolicyFilter> Filters { get => _filters; set => _filters.Assign(value); }
    private readonly BicepValue<BlobInventoryPolicyFilter> _filters;

    /// <summary>
    /// This is a required field, it specifies the format for the inventory
    /// files.
    /// </summary>
    public BicepValue<BlobInventoryPolicyFormat> Format { get => _format; set => _format.Assign(value); }
    private readonly BicepValue<BlobInventoryPolicyFormat> _format;

    /// <summary>
    /// This is a required field. This field is used to schedule an inventory
    /// formation.
    /// </summary>
    public BicepValue<BlobInventoryPolicySchedule> Schedule { get => _schedule; set => _schedule.Assign(value); }
    private readonly BicepValue<BlobInventoryPolicySchedule> _schedule;

    /// <summary>
    /// This is a required field. This field specifies the scope of the
    /// inventory created either at the blob or container level.
    /// </summary>
    public BicepValue<BlobInventoryPolicyObjectType> ObjectType { get => _objectType; set => _objectType.Assign(value); }
    private readonly BicepValue<BlobInventoryPolicyObjectType> _objectType;

    /// <summary>
    /// This is a required field. This field specifies the fields and
    /// properties of the object to be included in the inventory. The Schema
    /// field value &apos;Name&apos; is always required. The valid values for
    /// this field for the &apos;Blob&apos; definition.objectType include
    /// &apos;Name, Creation-Time, Last-Modified, Content-Length, Content-MD5,
    /// BlobType, AccessTier, AccessTierChangeTime, AccessTierInferred, Tags,
    /// Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, Snapshot,
    /// VersionId, IsCurrentVersion, Metadata, LastAccessTime, Tags, Etag,
    /// ContentType, ContentEncoding, ContentLanguage, ContentCRC64,
    /// CacheControl, ContentDisposition, LeaseStatus, LeaseState,
    /// LeaseDuration, ServerEncrypted, Deleted, DeletionId, DeletedTime,
    /// RemainingRetentionDays, ImmutabilityPolicyUntilDate,
    /// ImmutabilityPolicyMode, LegalHold, CopyId, CopyStatus, CopySource,
    /// CopyProgress, CopyCompletionTime, CopyStatusDescription,
    /// CustomerProvidedKeySha256, RehydratePriority, ArchiveStatus,
    /// XmsBlobSequenceNumber, EncryptionScope, IncrementalCopy,
    /// TagCount&apos;. For Blob object type schema field value
    /// &apos;DeletedTime&apos; is applicable only for Hns enabled accounts.
    /// The valid values for &apos;Container&apos; definition.objectType
    /// include &apos;Name, Last-Modified, Metadata, LeaseStatus, LeaseState,
    /// LeaseDuration, PublicAccess, HasImmutabilityPolicy, HasLegalHold,
    /// Etag, DefaultEncryptionScope, DenyEncryptionScopeOverride,
    /// ImmutableStorageWithVersioningEnabled, Deleted, Version, DeletedTime,
    /// RemainingRetentionDays&apos;. Schema field values &apos;Expiry-Time,
    /// hdi_isfolder, Owner, Group, Permissions, Acl, DeletionId&apos; are
    /// valid only for Hns enabled accounts.Schema field values &apos;Tags,
    /// TagCount&apos; are only valid for Non-Hns accounts.
    /// </summary>
    public BicepList<string> SchemaFields { get => _schemaFields; set => _schemaFields.Assign(value); }
    private readonly BicepList<string> _schemaFields;

    /// <summary>
    /// Creates a new BlobInventoryPolicyDefinition.
    /// </summary>
    public BlobInventoryPolicyDefinition()
    {
        _filters = BicepValue<BlobInventoryPolicyFilter>.DefineProperty(this, "Filters", ["filters"]);
        _format = BicepValue<BlobInventoryPolicyFormat>.DefineProperty(this, "Format", ["format"]);
        _schedule = BicepValue<BlobInventoryPolicySchedule>.DefineProperty(this, "Schedule", ["schedule"]);
        _objectType = BicepValue<BlobInventoryPolicyObjectType>.DefineProperty(this, "ObjectType", ["objectType"]);
        _schemaFields = BicepList<string>.DefineProperty(this, "SchemaFields", ["schemaFields"]);
    }
}
