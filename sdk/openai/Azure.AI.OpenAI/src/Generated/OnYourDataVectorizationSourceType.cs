// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Represents the available sources Azure OpenAI On Your Data can use to configure vectorization of data for use with
    /// vector search.
    /// </summary>
    internal readonly partial struct OnYourDataVectorizationSourceType : IEquatable<OnYourDataVectorizationSourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OnYourDataVectorizationSourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OnYourDataVectorizationSourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EndpointValue = "endpoint";
        private const string DeploymentNameValue = "deployment_name";
        private const string ModelIdValue = "model_id";

        /// <summary> Represents vectorization performed by public service calls to an Azure OpenAI embedding model. </summary>
        public static OnYourDataVectorizationSourceType Endpoint { get; } = new OnYourDataVectorizationSourceType(EndpointValue);
        /// <summary>
        /// Represents an Ada model deployment name to use. This model deployment must be in the same Azure OpenAI resource, but
        /// On Your Data will use this model deployment via an internal call rather than a public one, which enables vector
        /// search even in private networks.
        /// </summary>
        public static OnYourDataVectorizationSourceType DeploymentName { get; } = new OnYourDataVectorizationSourceType(DeploymentNameValue);
        /// <summary>
        /// Represents a specific embedding model ID as defined in the search service.
        /// Currently only supported by Elasticsearch®.
        /// </summary>
        public static OnYourDataVectorizationSourceType ModelId { get; } = new OnYourDataVectorizationSourceType(ModelIdValue);
        /// <summary> Determines if two <see cref="OnYourDataVectorizationSourceType"/> values are the same. </summary>
        public static bool operator ==(OnYourDataVectorizationSourceType left, OnYourDataVectorizationSourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OnYourDataVectorizationSourceType"/> values are not the same. </summary>
        public static bool operator !=(OnYourDataVectorizationSourceType left, OnYourDataVectorizationSourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="OnYourDataVectorizationSourceType"/>. </summary>
        public static implicit operator OnYourDataVectorizationSourceType(string value) => new OnYourDataVectorizationSourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OnYourDataVectorizationSourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OnYourDataVectorizationSourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
