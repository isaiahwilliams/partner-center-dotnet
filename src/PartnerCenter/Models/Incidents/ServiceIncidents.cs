// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Incidents
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents an office service health incident message.
    /// </summary>
    public sealed class ServiceIncidents
    {
        /// <summary>
        /// Gets or sets the incident list.
        /// </summary>
        public IEnumerable<ServiceIncidentDetail> Incidents { get; set; }

        /// <summary>
        /// Gets or sets the cumulative status of the service.
        /// </summary>
        public ServiceIncidentStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the message center messages.
        /// </summary>
        public IEnumerable<ServiceIncidentDetail> MessageCenterMessages { get; set; }

        /// <summary>
        /// Gets or sets the workload display name.
        /// </summary>
        public string Workload { get; set; }

    }
}