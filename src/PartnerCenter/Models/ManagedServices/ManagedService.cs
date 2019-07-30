// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ManagedServices
{
    /// <summary>
    /// Represents a service which the partner manages on behalf of a customer of theirs. Holds links used to administrate the customer's service.
    /// </summary>
    public sealed class ManagedService : ResourceBaseWithLinks<ManagedServiceLinks>
    {
        /// <summary>
        /// Gets or sets the managed service group name.
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// Gets or sets the managed service identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the managed service name.
        /// </summary>
        public string Name { get; set; }
    }
}