// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a product upgrade status.
    /// </summary>
    public class ProductUpgradesStatus
    {

        /// <summary>
        /// Gets or sets the product upgrade error details.
        /// </summary>
        public ProductUpgradesErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the  id of the upgrade initiated.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade line items.
        /// </summary>
        public IEnumerable<ProductUpgradesLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets the product family.
        /// </summary>
        public string ProductFamily { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade status.
        /// </summary>
        public string Status { get; set; }
    }
}