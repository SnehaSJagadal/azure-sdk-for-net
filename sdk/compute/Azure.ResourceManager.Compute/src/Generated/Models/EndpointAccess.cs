// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This property allows you to specify if the requests will be allowed to access the host endpoints. Possible values are: 'Allow', 'Deny'. </summary>
    public readonly partial struct EndpointAccess : IEquatable<EndpointAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static EndpointAccess Allow { get; } = new EndpointAccess(AllowValue);
        /// <summary> Deny. </summary>
        public static EndpointAccess Deny { get; } = new EndpointAccess(DenyValue);
        /// <summary> Determines if two <see cref="EndpointAccess"/> values are the same. </summary>
        public static bool operator ==(EndpointAccess left, EndpointAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointAccess"/> values are not the same. </summary>
        public static bool operator !=(EndpointAccess left, EndpointAccess right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="EndpointAccess"/>. </summary>
        public static implicit operator EndpointAccess(string value) => new EndpointAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
