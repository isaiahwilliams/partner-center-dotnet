// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Incidents
{
    using System;

    /// <summary>
    /// Represents the message history for service incident.
    /// </summary>
    public sealed class ServiceIncidentHistory
    {
        /// <summary>
        /// Gets or sets the published time.
        /// </summary>
        public DateTime PublishedTime { get; set; }

        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        public string MessageText { get; set; }
    }
}