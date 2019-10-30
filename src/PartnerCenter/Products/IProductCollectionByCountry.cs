// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using GenericOperations;

    /// <summary>
    /// Represents the operations that can be performed on products from a given country.
    /// </summary>
    public interface IProductCollectionByCountry : IPartnerComponent<string>, IEntitySelector<string, IProduct>
    {
        /// <summary>
        /// Gets the operations that can be applied on products that belong to a given country and catalog view.
        /// </summary>
        /// <param name="targetView">The product target view.</param>
        /// <returns>The product collection operations by country and by target view.</returns>
        IProductCollectionByCountryByTargetView ByTargetView(string targetView);
    }
}