// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ProductUpgrades
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models.ProductUpgrades;

    /// <summary>
    /// Implements the available product upgrades operations.
    /// </summary>
    internal class ProductUpgradesOperations : BasePartnerComponent<string>, IProductUpgrades
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpgradesOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="upgradeId">The identifier for the product upgrade.</param>
        public ProductUpgradesOperations(IPartner rootPartnerOperations, string upgradeId)
            : base(rootPartnerOperations, upgradeId)
        {
            upgradeId.AssertNotEmpty(nameof(upgradeId));
        }

        /// <summary>
        /// Checks the product upgrade status.
        /// </summary>
        /// <param name="productUpgradesRequest">The product upgrade status request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The status of the product upgrade.</returns>    
        public async Task<ProductUpgradesStatus> CheckStatusAsync(ProductUpgradesRequest productUpgradesRequest, CancellationToken cancellationToken = default)
        {
            productUpgradesRequest.AssertNotNull(nameof(productUpgradesRequest));

            return await Partner.ServiceClient.PostAsync<ProductUpgradesRequest, ProductUpgradesStatus>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetProductUpgradeStatus.Path}",
                        Context),
                    UriKind.Relative),
                productUpgradesRequest,
                cancellationToken).ConfigureAwait(false);
        }
    }
}
