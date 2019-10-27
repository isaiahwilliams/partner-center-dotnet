// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Products
{
    using PartnerCenter.Products;

    /// <summary>
    /// Represents the operations that can be performed on a single product.
    /// </summary>
    public interface ICustomerProduct : IProduct
    {
        /// <summary>
        /// Gets the operations that can be applied on a customer's product identifier's filtered by a specific reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The individual product operations sorted by reservation scope.</returns>
        ICustomerProductByReservationScope ByCustomerReservationScope(string reservationScope);
    }
}