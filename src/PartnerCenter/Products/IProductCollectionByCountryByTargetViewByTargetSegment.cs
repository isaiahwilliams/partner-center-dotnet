// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using GenericOperations;
    using Models;
    using Models.Products;
    using System;

    /// <summary>
    /// Holds operations that can be performed on products that belong to a given country, a catalog view and a specific target segment.
    /// </summary>
    public interface IProductCollectionByCountryByTargetViewByTargetSegment : IPartnerComponent<Tuple<string, string, string>>, IEntireEntityCollectionRetrievalOperations<Product, ResourceCollection<Product>>
    {
    }
}