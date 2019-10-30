// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Products
{
    using PartnerCenter.Products;

    /// <summary>
    /// Represents the operations that can be performed on a single SKU.
    /// </summary>
    public interface ICustomerSku : ISku
    {
        /// <summary>
        /// Gets the operations that can be applied on a customer's SKU identifiers filtered by a specific reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The individual SKU operations sorted by reservation scope.</returns>
        ICustomerSkuByReservationScope ByCustomerReservationScope(string reservationScope);
    }
}