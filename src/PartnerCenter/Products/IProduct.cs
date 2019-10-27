// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using GenericOperations;
    using Customers.Products;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on a single product.
    /// </summary>
    public interface IProduct : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<Product>
    {
        /// <summary>
        /// Gets the operations that can be applied on product identifier's filtered by a specific reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The individual product operations sorted by reservation scope.</returns>
        IProductByReservationScope ByReservationScope(string reservationScope);

        /// <summary>
        /// Get the SKUs for the product.
        /// </summary>
        ISkuCollection Skus { get; }
    }
}