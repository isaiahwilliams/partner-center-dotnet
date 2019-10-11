// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ProductUpgrades
{
    /// <summary>
    /// Represents an upgraded product's details.
    /// </summary>
    public class UpgradedProductDetails
    {
        /// <summary>
        /// Gets or sets the id of the product to upgrade.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the product to upgrade.
        /// </summary>
        public string Name { get; set; }
    }
}