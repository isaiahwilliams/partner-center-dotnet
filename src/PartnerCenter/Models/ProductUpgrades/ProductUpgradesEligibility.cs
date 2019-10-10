// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    /// <summary>
    /// Represents a product upgrade eligibility.
    /// </summary>
    public class ProductUpgradesEligibility
    {
        /// <summary>
        /// Gets or sets the customer id.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the upgrade is eligible.
        /// </summary>
        public bool IsEligible { get; set; }

        /// <summary>
        /// Gets or sets the product family.
        /// </summary>
        public string ProductFamily { get; set; }

        /// <summary>
        /// Gets or sets the upgrade reason if the customer is not eligible for upgrade.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets the product upgrade id.
        /// </summary>
        public string UpgradeId { get; set; }
    }
}