// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This property specifies the status of the validationProfile of the image version. </summary>
    public readonly partial struct ValidationStatus : IEquatable<ValidationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ValidationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ValidationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string FailedValue = "Failed";
        private const string SucceededValue = "Succeeded";

        /// <summary> Unknown. </summary>
        public static ValidationStatus Unknown { get; } = new ValidationStatus(UnknownValue);
        /// <summary> Failed. </summary>
        public static ValidationStatus Failed { get; } = new ValidationStatus(FailedValue);
        /// <summary> Succeeded. </summary>
        public static ValidationStatus Succeeded { get; } = new ValidationStatus(SucceededValue);
        /// <summary> Determines if two <see cref="ValidationStatus"/> values are the same. </summary>
        public static bool operator ==(ValidationStatus left, ValidationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ValidationStatus"/> values are not the same. </summary>
        public static bool operator !=(ValidationStatus left, ValidationStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ValidationStatus"/>. </summary>
        public static implicit operator ValidationStatus(string value) => new ValidationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ValidationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ValidationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
