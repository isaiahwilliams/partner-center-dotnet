// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    /// <summary>
    /// Represents the pricing details for a line item.
    /// </summary>
    public sealed class Pricing
    {
        /// <summary>
        /// Gets or sets the discounted price.
        /// </summary>
        public double? DiscountedPrice { get; private set; }

        /// <summary>
        /// Gets or sets the extended price.
        /// </summary>
        public double? ExtendedPrice { get; private set; }

        /// <summary>
        /// Gets or sets the list price.
        /// </summary>
        public double? ListPrice { get; private set; }

        /// <summary>
        /// Gets or sets the prorated price.
        /// </summary>
        public double? ProratedPrice { get; private set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double? Price { get; private set; }
    }
}