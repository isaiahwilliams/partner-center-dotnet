// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Entitlements
{
    using System.Collections.Generic;

    /// <summary>
    /// Class that represents reserved instance artifact details.
    /// </summary>
    public class ReservedInstanceArtifactDetails : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or sets the reservation collection.
        /// </summary>
        public IEnumerable<Reservation> Reservations { get; set; }

        /// <summary>
        /// Gets or sets the artifact type.
        /// </summary>
        public string Type { get; set; }
    }
}