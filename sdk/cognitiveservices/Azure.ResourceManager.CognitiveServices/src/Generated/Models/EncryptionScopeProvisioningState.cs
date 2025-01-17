// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Gets the status of the resource at the time the operation was called. </summary>
    public readonly partial struct EncryptionScopeProvisioningState : IEquatable<EncryptionScopeProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EncryptionScopeProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EncryptionScopeProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AcceptedValue = "Accepted";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string MovingValue = "Moving";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";

        /// <summary> Accepted. </summary>
        public static EncryptionScopeProvisioningState Accepted { get; } = new EncryptionScopeProvisioningState(AcceptedValue);
        /// <summary> Creating. </summary>
        public static EncryptionScopeProvisioningState Creating { get; } = new EncryptionScopeProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static EncryptionScopeProvisioningState Deleting { get; } = new EncryptionScopeProvisioningState(DeletingValue);
        /// <summary> Moving. </summary>
        public static EncryptionScopeProvisioningState Moving { get; } = new EncryptionScopeProvisioningState(MovingValue);
        /// <summary> Failed. </summary>
        public static EncryptionScopeProvisioningState Failed { get; } = new EncryptionScopeProvisioningState(FailedValue);
        /// <summary> Succeeded. </summary>
        public static EncryptionScopeProvisioningState Succeeded { get; } = new EncryptionScopeProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static EncryptionScopeProvisioningState Canceled { get; } = new EncryptionScopeProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="EncryptionScopeProvisioningState"/> values are the same. </summary>
        public static bool operator ==(EncryptionScopeProvisioningState left, EncryptionScopeProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EncryptionScopeProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(EncryptionScopeProvisioningState left, EncryptionScopeProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EncryptionScopeProvisioningState"/>. </summary>
        public static implicit operator EncryptionScopeProvisioningState(string value) => new EncryptionScopeProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EncryptionScopeProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EncryptionScopeProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
