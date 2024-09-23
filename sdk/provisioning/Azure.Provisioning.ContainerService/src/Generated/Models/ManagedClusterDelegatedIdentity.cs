// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Delegated resource properties - internal use only.
/// </summary>
public partial class ManagedClusterDelegatedIdentity : ProvisioningConstruct
{
    /// <summary>
    /// The ARM resource id of the delegated resource - internal use only.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; set => _resourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// The tenant id of the delegated resource - internal use only.
    /// </summary>
    public BicepValue<Guid> TenantId { get => _tenantId; set => _tenantId.Assign(value); }
    private readonly BicepValue<Guid> _tenantId;

    /// <summary>
    /// The delegation id of the referral delegation (optional) - internal use
    /// only.
    /// </summary>
    public BicepValue<string> ReferralResource { get => _referralResource; set => _referralResource.Assign(value); }
    private readonly BicepValue<string> _referralResource;

    /// <summary>
    /// The source resource location - internal use only.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Creates a new ManagedClusterDelegatedIdentity.
    /// </summary>
    public ManagedClusterDelegatedIdentity()
    {
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["resourceId"]);
        _tenantId = BicepValue<Guid>.DefineProperty(this, "TenantId", ["tenantId"]);
        _referralResource = BicepValue<string>.DefineProperty(this, "ReferralResource", ["referralResource"]);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"]);
    }
}
