// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Extensions.Products
{
    /// <summary>
    /// Holds extension operations for products.
    /// </summary>
    public interface IProductExtensions : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the extension operations that can be applied on products from a given country.
        /// </summary>
        /// <param name="country">The country name.</param>
        /// <returns>The product extensions operations by country.</returns>
        IProductExtensionsByCountry ByCountry(string country);
    }
}
