// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    /// <summary>
    /// Bundles the links for an order line item.
    /// </summary>
    public sealed class OrderLineItemLinks
    {
        /// <summary>
        /// Gets or sets the activation links for the order line item.
        /// </summary>
        public Link ActivationLinks { get; set; }

        /// <summary>
        /// Gets or sets the availability link for the order line item.
        /// </summary>
        public Link Availability { get; set; }

        /// <summary>
        /// Gets or sets the product link for the order line item.
        /// </summary>
        public Link Product { get; set; }

        /// <summary>
        /// Gets or sets the provisioning status link for the order line item.
        /// </summary>
        public Link ProvisioningStatus { get; set; }

        /// <summary>
        /// Gets or sets the SKU link for the order line item.
        /// </summary>
        public Link Sku { get; set; }

        /// <summary>
        /// Gets or sets the subscription link for the order line item.
        /// </summary>
        public Link Subscription { get; set; }
    }
}