// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Entitlements
{
    /// <summary>
    /// Class that represents an order linked to the entitlement.
    /// </summary>
    public class ReferenceOrder : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or sets the order alternate identifier.
        /// </summary>
        public string AlternateId { get; set; }

        /// <summary>
        /// Gets or sets order identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets order line item identifier.
        /// </summary>
        public string LineItemId { get; set; }
    }
}