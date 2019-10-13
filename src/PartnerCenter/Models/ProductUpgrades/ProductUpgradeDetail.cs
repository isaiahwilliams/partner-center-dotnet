// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    /// <summary>
    /// Represents an the details for a product upgrade.
    /// </summary>
    public class ProductUpgradeDetail
    {
        /// <summary>
        /// Gets or sets the identifier of the product upgrade.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the product upgrade.
        /// </summary>
        public string Name { get; set; }
    }
}