// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Extensions.Products
{
    using Models.Products;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Holds extension operations for products by country.
    /// </summary>
    public interface IProductExtensionsByCountry : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets inventory validation results for the provided country.
        /// </summary>
        /// <param name="checkRequest">The request for the inventory check.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The inventory check results.</returns>
        Task<IEnumerable<InventoryItem>> CheckInventoryAsync(InventoryCheckRequest checkRequest, CancellationToken cancellationToken = default);
    }
}