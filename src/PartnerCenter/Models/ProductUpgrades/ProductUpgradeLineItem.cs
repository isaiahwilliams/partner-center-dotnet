// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    using System;

    /// <summary>
    /// Represents the product upgrade line item.
    /// </summary>
    public class ProductUpgradeLineItem
    {
        /// <summary>
        /// Gets or sets the product upgrade error details.
        /// </summary>
        public ProductUpgradeErrorDetails ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the product being upgraded.
        /// </summary>
        public ProductUpgradeDetail SourceProduct { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the product being upgraded to.
        /// </summary>
        public ProductUpgradeDetail TargetProduct { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade date.
        /// </summary>
        public DateTime UpgradedDate { get; set; }
    }
}