// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using GenericOperations;
    using Models.Products;

    /// <summary>
    /// Represents the operations that can be performed on a single product filtered by reservation scope.
    /// </summary>
    public interface IProductByReservationScope : IPartnerComponent<Tuple<string, string, string>>, IEntityGetOperations<Product>
    {
    }
}