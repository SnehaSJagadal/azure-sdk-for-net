// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary>
    /// Definition of which data will be collected from a separate VM extension that integrates with the Azure Monitor Agent.
    /// Collected from either Windows and Linux machines, depending on which extension is defined.
    /// </summary>
    internal partial class ExtensionDataSource
    {
        /// <summary> Initializes a new instance of ExtensionDataSource. </summary>
        /// <param name="extensionName"> The name of the VM extension. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extensionName"/> is null. </exception>
        internal ExtensionDataSource(string extensionName)
        {
            if (extensionName == null)
            {
                throw new ArgumentNullException(nameof(extensionName));
            }

            Streams = new ChangeTrackingList<KnownExtensionDataSourceStreams>();
            ExtensionName = extensionName;
            InputDataSources = new ChangeTrackingList<string>();
        }

        /// <summary>
        /// List of streams that this data source will be sent to.
        /// A stream indicates what schema will be used for this data and usually what table in Log Analytics the data will be sent to.
        /// </summary>
        public IReadOnlyList<KnownExtensionDataSourceStreams> Streams { get; }
        /// <summary> The name of the VM extension. </summary>
        public string ExtensionName { get; }
        /// <summary> The extension settings. The format is specific for particular extension. </summary>
        public object ExtensionSettings { get; }
        /// <summary> The list of data sources this extension needs data from. </summary>
        public IReadOnlyList<string> InputDataSources { get; }
        /// <summary>
        /// A friendly name for the data source. 
        /// This name should be unique across all data sources (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; }
    }
}
