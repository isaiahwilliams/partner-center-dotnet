// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.;

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using Models;
    using GenericOperations;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on skus from a specific target segment and reservation scope.
    /// </summary>
    public interface ISkuCollectionByTargetSegmentByReservationScope : IPartnerComponent<Tuple<string, string, string, string>>, IEntireEntityCollectionRetrievalOperations<Sku, ResourceCollection<Sku>>
    {
    }
}