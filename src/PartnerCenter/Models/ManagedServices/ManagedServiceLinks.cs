// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ManagedServices
{
    using Newtonsoft.Json;

    /// <summary>
    /// Bundles a Managed service links.
    /// </summary>
    public sealed class ManagedServiceLinks
    {
        /// <summary>
        /// Gets or sets the admin service URI.
        /// </summary>
        [JsonProperty]
        public Link AdminService { get; set; }

        /// <summary>
        /// Gets or sets the service health URI.
        /// </summary>
        [JsonProperty]
        public Link ServiceHealth { get; set; }

        /// <summary>
        /// Gets or sets the service ticket URI.
        /// </summary>
        [JsonProperty]
        public Link ServiceTicket { get; set; }
    }
}