// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    /// <summary>
    /// Navigation links for product.
    /// </summary>
    public class ProductLinks : StandardResourceLinks
    {
        /// <summary>
        /// Gets or sets the SKUs link.
        /// </summary>
        public Link Skus { get; set; }
    }
}