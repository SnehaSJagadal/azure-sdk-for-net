// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The entry of path and mount mode you want to mount into task container.
    /// </summary>
    public partial class ContainerHostBatchBindMountEntry
    {
        /// <summary>
        /// Initializes a new instance of the ContainerHostBatchBindMountEntry
        /// class.
        /// </summary>
        public ContainerHostBatchBindMountEntry()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerHostBatchBindMountEntry
        /// class.
        /// </summary>
        /// <param name="source">The path which be mounted to container
        /// customer can select.</param>
        /// <param name="isReadOnly">Mount this source path as read-only mode
        /// or not. Default value is false (read/write mode).</param>
        public ContainerHostBatchBindMountEntry(string source = default(string), bool? isReadOnly = default(bool?))
        {
            Source = source;
            IsReadOnly = isReadOnly;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path which be mounted to container customer can
        /// select.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'Shared', 'Startup', 'VfsMounts', 'Task',
        /// 'JobPrep', 'Applications'
        /// </remarks>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets mount this source path as read-only mode or not.
        /// Default value is false (read/write mode).
        /// </summary>
        /// <remarks>
        /// For Linux, if you mount this path as a read/write mode, this does
        /// not mean that all users in container have the read/write access for
        /// the path, it depends on the access in host VM. If this path is
        /// mounted read-only, all users within the container will not be able
        /// to modify the path.
        /// </remarks>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

    }
}
