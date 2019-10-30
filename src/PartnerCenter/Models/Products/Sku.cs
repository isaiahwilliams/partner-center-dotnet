// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a SKU for a product.
    /// </summary>
    public sealed class Sku : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the dynamic attributes.
        /// </summary>
        public IDictionary<string, object> DynamicAttributes { get; private set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the variables needed for inventory check.
        /// </summary>
        public IEnumerable<string> InventoryVariables { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is a trial SKU or not.
        /// </summary>
        public bool IsTrial { get; set; }

        /// <summary>
        /// Gets or sets the maximum order quantity.
        /// </summary>
        public int MaximumQuantity { get; set; }

        /// <summary>
        /// Gets or sets the minimum order quantity.
        /// </summary>
        public int MinimumQuantity { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the provisioning variables.
        /// </summary>
        public IEnumerable<string> ProvisioningVariables { get; set; }

        /// <summary>
        /// Gets or sets the purchase prerequisites.
        /// </summary>
        public IEnumerable<string> PurchasePrerequisites { get; set; }

        /// <summary>
        /// Gets or sets the billing cycles supported for the offer.
        /// </summary>
        public IEnumerable<BillingCycleType> SupportedBillingCycles { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }
    }
}