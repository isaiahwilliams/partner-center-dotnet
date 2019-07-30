// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    /// <summary>
    /// Class that represents an inventory item.
    /// </summary>
    public class InventoryItem
    {
        /// <summary>
        /// Gets or sets a value indicating whether this item currently has any inventory restrictions.
        /// </summary>
        public bool IsRestricted { get; set; }

        /// <summary>
        /// Gets or sets the item product identifier.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the item SKU identifier.
        /// </summary>
        public string SkuId { get; set; }

        /// <summary>
        /// Gets or sets the restrictions for this item if any.
        /// </summary>
        [JsonProperty]
        public IEnumerable<InventoryRestriction> Restrictions { get; set; }
    }
}