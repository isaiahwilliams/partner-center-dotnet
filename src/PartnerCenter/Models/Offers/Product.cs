// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Offers
{
    /// <summary>
    /// Defines a product tied to an offer.
    /// </summary>
    public sealed class Product
    {
        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the product unit.
        /// </summary>
        public string Unit { get; set; }
    }
}