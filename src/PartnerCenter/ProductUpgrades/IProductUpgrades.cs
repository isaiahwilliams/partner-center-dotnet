// Copyright(c) Isaiah Williams.All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ProductUpgrades
{
    using System.Threading;
    using System.Threading.Tasks;
    using Models.ProductUpgrades;

    /// <summary>
    /// Represents the operations that apply to product upgrades.
    /// </summary>
    public interface IProductUpgrades : IPartnerComponent<string>
    {
        /// <summary>
        /// Checks the product upgrade status.
        /// </summary>
        /// <param name="productUpgradesRequest">The product upgrade status request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The eligibility object for the customer.</returns>        
        Task<ProductUpgradeStatus> CheckStatusAsync(ProductUpgradeRequest productUpgradesRequest, CancellationToken cancellationToken = default);
    }
}
