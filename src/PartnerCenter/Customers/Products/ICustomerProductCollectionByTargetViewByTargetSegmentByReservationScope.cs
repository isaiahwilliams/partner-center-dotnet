// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Products
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on products in a given product collection and that apply to a given customer, filtered by reservation scope.
    /// </summary>
    public interface ICustomerProductCollectionByTargetViewByTargetSegmentByReservationScope :
        IPartnerComponent<Tuple<string, string, string, string>>, IEntireEntityCollectionRetrievalOperations<Product, ResourceCollection<Product>>
    {
    }
}