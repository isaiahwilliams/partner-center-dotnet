// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ServiceRequests
{
    /// <summary>
    /// Represents a service request support topic.
    /// </summary>
    public sealed class SupportTopic : ResourceBase
    {
        /// <summary>
        /// Gets or sets the description of the support topic.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the support topic.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the support topic.
        /// </summary>
        public string Name { get; set; }
    }
}