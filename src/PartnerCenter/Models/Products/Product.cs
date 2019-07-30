// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    /// <summary>
    /// Class that represents a product.
    /// </summary>
    public sealed class Product : ResourceBaseWithLinks<ProductLinks>
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a flag indicating whether this is a Microsoft product or not.
        /// </summary>
        public bool IsMicrosoftProduct { get; set; }

        /// <summary>
        /// Gets or sets the product type.
        /// </summary>
        public ItemType ProductType { get; set; }

        /// <summary>
        /// Gets or sets the name of the publisher.
        /// </summary>
        public string PublisherName { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }
    }
}