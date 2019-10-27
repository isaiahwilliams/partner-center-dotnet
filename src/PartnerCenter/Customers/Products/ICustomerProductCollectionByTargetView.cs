// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Products
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on products in a given catalog view that apply to a given customer.
    /// </summary>
    public interface ICustomerProductCollectionByTargetView : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<Product, ResourceCollection<Product>>
    {
        /// <summary>
        /// Gets the operations that can be applied on products in a given catalog view and that apply to a given customer, filtered by target segment.
        /// </summary>
        /// <param name="targetSegment">The product segment filter.</param>
        /// <returns>The product collection operations by customer, by target view and by target segment.</returns>
        ICustomerProductCollectionByTargetViewByTargetSegment ByTargetSegment(string targetSegment);

        /// <summary>
        /// Gets the operations that can be applied on products in a given catalog view and that apply to a given customer, filtered by reservation scope.
        /// </summary>
        /// <param name="reservationScope">The product segment filter.</param>
        /// <returns>The product collection operations by customer, by target view and by reservation scope.</returns>
        ICustomerProductCollectionByTargetViewByReservationScope ByReservationScope(string reservationScope);
    }
}