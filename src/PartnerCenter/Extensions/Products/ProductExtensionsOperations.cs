// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Extensions.Products
{
    /// <summary>
    /// Extensions operations implementation.
    /// </summary>
    internal class ProductExtensionsOperations : BasePartnerComponent<string>, IProductExtensions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductExtensionsOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public ProductExtensionsOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Gets the extension operations that can be applied on products from a given country.
        /// </summary>
        /// <param name="country">The country name.</param>
        /// <returns>The product extensions operations by country.</returns>
        public IProductExtensionsByCountry ByCountry(string country)
        {
            return new ProductExtensionsByCountryOperations(Partner, country);
        }
    }
}