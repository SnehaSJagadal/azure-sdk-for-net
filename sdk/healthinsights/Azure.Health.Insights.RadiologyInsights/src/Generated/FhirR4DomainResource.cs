// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// A resource with narrative, extensions, and contained resources
    /// Based on [FHIR DomainResource](https://www.hl7.org/fhir/domainresource.html)
    /// Please note <see cref="FhirR4DomainResource"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FhirR4Observation"/>.
    /// </summary>
    public abstract partial class FhirR4DomainResource : FhirR4Resource
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4DomainResource"/>. </summary>
        /// <param name="resourceType"> The type of resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceType"/> is null. </exception>
        protected FhirR4DomainResource(string resourceType) : base(resourceType)
        {
            if (resourceType == null)
            {
                throw new ArgumentNullException(nameof(resourceType));
            }

            Contained = new ChangeTrackingList<FhirR4Resource>();
            Extension = new ChangeTrackingList<FhirR4Extension>();
            ModifierExtension = new ChangeTrackingList<FhirR4Extension>();
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4DomainResource"/>. </summary>
        /// <param name="resourceType"> The type of resource. </param>
        /// <param name="id"> Resource Id. </param>
        /// <param name="meta"> Metadata about the resource. </param>
        /// <param name="implicitRules"> A set of rules under which this content was created. </param>
        /// <param name="language"> Language of the resource content. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="text"> Text summary of the resource, for human interpretation. </param>
        /// <param name="contained"> Contained, inline Resources. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="modifierExtension"> Extensions that cannot be ignored. </param>
        internal FhirR4DomainResource(string resourceType, string id, FhirR4Meta meta, string implicitRules, string language, IDictionary<string, BinaryData> additionalProperties, FhirR4Narrative text, IList<FhirR4Resource> contained, IList<FhirR4Extension> extension, IList<FhirR4Extension> modifierExtension) : base(resourceType, id, meta, implicitRules, language, additionalProperties)
        {
            Text = text;
            Contained = contained;
            Extension = extension;
            ModifierExtension = modifierExtension;
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4DomainResource"/> for deserialization. </summary>
        internal FhirR4DomainResource()
        {
        }

        /// <summary> Text summary of the resource, for human interpretation. </summary>
        public FhirR4Narrative Text { get; set; }
        /// <summary> Contained, inline Resources. </summary>
        public IList<FhirR4Resource> Contained { get; }
        /// <summary> Additional Content defined by implementations. </summary>
        public IList<FhirR4Extension> Extension { get; }
        /// <summary> Extensions that cannot be ignored. </summary>
        public IList<FhirR4Extension> ModifierExtension { get; }
    }
}
