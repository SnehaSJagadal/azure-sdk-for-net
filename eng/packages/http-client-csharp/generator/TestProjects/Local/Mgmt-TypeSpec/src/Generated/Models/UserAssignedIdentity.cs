// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtTypeSpec.Models
{
    /// <summary> User assigned identity properties. </summary>
    public partial class UserAssignedIdentity
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal UserAssignedIdentity()
        {
        }

        internal UserAssignedIdentity(Guid? principalId, Guid? clientId, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            PrincipalId = principalId;
            ClientId = clientId;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The principal ID of the assigned identity. </summary>
        public Guid? PrincipalId { get; }

        /// <summary> The client ID of the assigned identity. </summary>
        public Guid? ClientId { get; }
    }
}
