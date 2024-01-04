// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> The overall success or failure status of the operation. It remains "InProgress" until the operation completes. At that point it will become "Unknown", "Failed", "Succeeded", or "CompletedWithWarnings.". </summary>
    public readonly partial struct MachineOperationStatus : IEquatable<MachineOperationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineOperationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineOperationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string InProgressValue = "InProgress";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";
        private const string CompletedWithWarningsValue = "CompletedWithWarnings";

        /// <summary> Unknown. </summary>
        public static MachineOperationStatus Unknown { get; } = new MachineOperationStatus(UnknownValue);
        /// <summary> InProgress. </summary>
        public static MachineOperationStatus InProgress { get; } = new MachineOperationStatus(InProgressValue);
        /// <summary> Failed. </summary>
        public static MachineOperationStatus Failed { get; } = new MachineOperationStatus(FailedValue);
        /// <summary> Succeeded. </summary>
        public static MachineOperationStatus Succeeded { get; } = new MachineOperationStatus(SucceededValue);
        /// <summary> CompletedWithWarnings. </summary>
        public static MachineOperationStatus CompletedWithWarnings { get; } = new MachineOperationStatus(CompletedWithWarningsValue);
        /// <summary> Determines if two <see cref="MachineOperationStatus"/> values are the same. </summary>
        public static bool operator ==(MachineOperationStatus left, MachineOperationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineOperationStatus"/> values are not the same. </summary>
        public static bool operator !=(MachineOperationStatus left, MachineOperationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineOperationStatus"/>. </summary>
        public static implicit operator MachineOperationStatus(string value) => new MachineOperationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineOperationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineOperationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
