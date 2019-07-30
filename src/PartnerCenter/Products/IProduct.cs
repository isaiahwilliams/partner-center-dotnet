// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using GenericOperations;
    using Models.Products;
    using System;

    /// <summary>
    /// Holds operations that can be performed on a single product.
    /// </summary>
    public interface IProduct : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<Product>
    {
        /// <summary>
        /// Get the SKUs for the product.
        /// </summary>
        ISkuCollection Skus { get; }
    }
}