// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    using Offers;

    /// <summary>
    /// Represents the conversion for a subscription from a trial offer to a paid offer.
    /// </summary>
    public sealed class Conversion : ResourceBase
    {
        /// <summary>
        /// Gets or sets the billing cycle. Defines how often the partner is billed for this subscription.
        /// </summary>
        public BillingCycleType BillingCycle { get; set; }

        /// <summary>
        /// Gets or sets the original offer identifier.
        /// </summary>
        public string OfferId { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the quantity to be purchased. Defaults to the source subscription quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the target offer identifier.
        /// </summary>
        public string TargetOfferId { get; set; }
    }
}