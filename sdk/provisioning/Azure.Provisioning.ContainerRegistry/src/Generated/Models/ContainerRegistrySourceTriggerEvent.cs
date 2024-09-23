// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using System.Runtime.Serialization;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The ContainerRegistrySourceTriggerEvent.
/// </summary>
public enum ContainerRegistrySourceTriggerEvent
{
    /// <summary>
    /// commit.
    /// </summary>
    [DataMember(Name = "commit")]
    Commit,

    /// <summary>
    /// pullrequest.
    /// </summary>
    [DataMember(Name = "pullrequest")]
    PullRequest,
}
