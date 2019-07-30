// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.RelationshipRequests
{
    using System;

    /// <summary>
    /// Represents a customer relationship request with a partner.
    /// </summary>
    public sealed class CustomerRelationshipRequest : ResourceBase
    {
        /// <summary>
        /// Gets or sets the URL to be used by the customer to establish a relationship with a partner.
        /// </summary>
        public Uri Url { get; set; }
    }
}
