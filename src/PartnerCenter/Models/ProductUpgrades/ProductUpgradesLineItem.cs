// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    using System;

    /// <summary>
    /// Represents the product upgrade line item.
    /// </summary>
    public class ProductUpgradesLineItem
    {
        /// <summary>
        /// Gets or sets the product upgrade error details.
        /// </summary>
        public ProductUpgradesErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the product being upgraded.
        /// </summary>
        public UpgradedProductDetails SourceProduct { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the product being upgraded to.
        /// </summary>
        public UpgradedProductDetails TargetProduct { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade date.
        /// </summary>
        public DateTime UpgradedDate { get; set; }
    }
}