// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on SKUs.
    /// </summary>
    public interface ISkuCollection : IPartnerComponent<Tuple<string, string>>, IEntitySelector<string, ISku>, IEntireEntityCollectionRetrievalOperations<Sku, ResourceCollection<Sku>>
    {
        /// <summary>
        /// Gets the operations that can be applied on SKU identifiers filtered by a specific reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The individual SKU operations sorted by reservation scope.</returns>
        ISkuCollectionByReservationScope ByReservationScope(string reservationScope);

        /// <summary>
        /// Gets the operations that can be applied on SKUs that belong to a segment.
        /// </summary>
        /// <param name="targetSegment">The SKU segment filter.</param>
        /// <returns>The sku collection operations by target segment.</returns>
        ISkuCollectionByTargetSegment ByTargetSegment(string targetSegment);
    }
}