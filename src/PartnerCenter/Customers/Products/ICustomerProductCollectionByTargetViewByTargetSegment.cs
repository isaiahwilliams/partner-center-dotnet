// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Products
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on products in a given catalog view and that apply to a given customer, filtered by target segment.
    /// </summary>
    public interface ICustomerProductCollectionByTargetViewByTargetSegment : IPartnerComponent<Tuple<string, string, string>>, IEntireEntityCollectionRetrievalOperations<Product, ResourceCollection<Product>>
    {
        /// <summary>
        /// Gets the operations that can be applied on customer products filtered by a specific reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The customer products collection operations by reservation scope.</returns>
        ICustomerProductCollectionByTargetViewByTargetSegmentByReservationScope ByReservationScope(string reservationScope);
    }
}