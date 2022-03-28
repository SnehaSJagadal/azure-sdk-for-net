// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The service properties for soft delete.
    /// </summary>
    public partial class DeleteRetentionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the DeleteRetentionPolicy class.
        /// </summary>
        public DeleteRetentionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteRetentionPolicy class.
        /// </summary>
        /// <param name="enabled">Indicates whether DeleteRetentionPolicy is
        /// enabled.</param>
        /// <param name="days">Indicates the number of days that the deleted
        /// item should be retained. The minimum specified value can be 1 and
        /// the maximum value can be 365.</param>
        /// <param name="allowPermanentDelete">This property when set to true
        /// allows deletion of the soft deleted blob versions and snapshots.
        /// This property cannot be used blob restore policy. This property
        /// only applies to blob service and does not apply to containers or
        /// file share.</param>
        public DeleteRetentionPolicy(bool? enabled = default(bool?), int? days = default(int?), bool? allowPermanentDelete = default(bool?))
        {
            Enabled = enabled;
            Days = days;
            AllowPermanentDelete = allowPermanentDelete;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicates whether DeleteRetentionPolicy is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets indicates the number of days that the deleted item
        /// should be retained. The minimum specified value can be 1 and the
        /// maximum value can be 365.
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public int? Days { get; set; }

        /// <summary>
        /// Gets or sets this property when set to true allows deletion of the
        /// soft deleted blob versions and snapshots. This property cannot be
        /// used blob restore policy. This property only applies to blob
        /// service and does not apply to containers or file share.
        /// </summary>
        [JsonProperty(PropertyName = "allowPermanentDelete")]
        public bool? AllowPermanentDelete { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Days != null)
            {
                if (Days > 365)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Days", 365);
                }
                if (Days < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Days", 1);
                }
            }
        }
    }
}
