// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using GenericOperations;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on a single SKU.
    /// </summary>
    public interface ISku : IPartnerComponent<Tuple<string, string, string>>, IEntityGetOperations<Sku>
    {
        /// <summary>
        /// Gets the operations for the current SKU's availabilities.
        /// </summary>
        IAvailabilityCollection Availabilities { get; }

        /// <summary>
        /// Gets the operations that can be applied on SKU identifiers filtered by a specific reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The individual SKU operations sorted by reservation scope.</returns>
        ISkuByReservationScope ByReservationScope(string reservationScope);
    }
}