﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary>
    /// The play paused event.
    /// </summary>
    [CodeGenModel("PlayPaused", Usage = new string[] { "output" }, Formats = new string[] { "json" })]
    public partial class PlayPaused : CallAutomationEventBase
    {
        /// <summary>
        /// Reason code.
        /// </summary>
        public MediaEventReasonCode ReasonCode { get; internal set; }

        /// <summary>
        /// Deserialize <see cref="PlayPaused"/> event.
        /// </summary>
        /// <param name="content">The json content.</param>
        /// <returns>The new <see cref="PlayPaused"/> object.</returns>
        public static PlayPaused Deserialize(string content)
        {
            using var document = JsonDocument.Parse(content);
            JsonElement element = document.RootElement;

            return DeserializePlayPaused(element);
        }
    }
}
