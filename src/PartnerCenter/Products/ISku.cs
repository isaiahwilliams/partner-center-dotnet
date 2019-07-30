// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using GenericOperations;
    using Models.Products;
    using System;

    /// <summary>
    /// Holds operations that can be performed on a single SKU.
    /// </summary>
    public interface ISku : IPartnerComponent<Tuple<string, string, string>>, IEntityGetOperations<Sku>
    {
        /// <summary>
        /// Gets the operations for the current SKU's availabilities.
        /// </summary>
        IAvailabilityCollection Availabilities { get; }
    }
}