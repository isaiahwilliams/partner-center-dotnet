// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    /// <summary>
    /// Represents error details for a product upgrade.
    /// </summary>
    public class ProductUpgradeErrorDetails
    {
        /// <summary>
        /// Gets or sets the error code of the product upgrade.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the description of the product upgrade.
        /// </summary>
        public string Description { get; set; }
    }
}