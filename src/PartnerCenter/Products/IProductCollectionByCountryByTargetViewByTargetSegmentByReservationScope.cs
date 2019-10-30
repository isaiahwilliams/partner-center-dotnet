// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on products that belong to a given country, a product collection, a specific target segment, and reservation scope.
    /// </summary>
    public interface IProductCollectionByCountryByTargetViewByTargetSegmentByReservationScope :
        IPartnerComponent<Tuple<string, string, string, string>>, IEntireEntityCollectionRetrievalOperations<Product, ResourceCollection<Product>>
    {
    }
}