// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Storage;

/// <summary>
/// StorageQueue.
/// </summary>
public partial class StorageQueue : Resource
{
    /// <summary>
    /// A queue name must be unique within a storage account and must be
    /// between 3 and 63 characters.The name must comprise of lowercase
    /// alphanumeric and dash(-) characters only, it should begin and end with
    /// an alphanumeric character and it cannot have two consecutive dash(-)
    /// characters.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// A name-value pair that represents queue metadata.
    /// </summary>
    public BicepDictionary<string> Metadata { get => _metadata; set => _metadata.Assign(value); }
    private readonly BicepDictionary<string> _metadata;

    /// <summary>
    /// Integer indicating an approximate number of messages in the queue. This
    /// number is not lower than the actual number of messages in the queue,
    /// but could be higher.
    /// </summary>
    public BicepValue<int> ApproximateMessageCount { get => _approximateMessageCount; }
    private readonly BicepValue<int> _approximateMessageCount;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent QueueService.
    /// </summary>
    public QueueService? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<QueueService> _parent;

    /// <summary>
    /// Creates a new StorageQueue.
    /// </summary>
    /// <param name="resourceName">Name of the StorageQueue.</param>
    /// <param name="resourceVersion">Version of the StorageQueue.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public StorageQueue(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.Storage/storageAccounts/queueServices/queues", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _metadata = BicepDictionary<string>.DefineProperty(this, "Metadata", ["properties", "metadata"]);
        _approximateMessageCount = BicepValue<int>.DefineProperty(this, "ApproximateMessageCount", ["properties", "approximateMessageCount"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<QueueService>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing StorageQueue.
    /// </summary>
    /// <param name="resourceName">Name of the StorageQueue.</param>
    /// <param name="resourceVersion">Version of the StorageQueue.</param>
    /// <returns>The existing StorageQueue resource.</returns>
    public static StorageQueue FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this StorageQueue resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);
}
