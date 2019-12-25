// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ProductUpgrades
{
    using System;
    using System.Globalization;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models.ProductUpgrades;

    /// <summary>
    /// Implements the operations for product upgrades.
    /// </summary>
    internal class ProductUpgradesCollectionOperations : BasePartnerComponent<string>, IProductUpgradesCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductUpgradesCollectionOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public ProductUpgradesCollectionOperations(IPartner rootPartnerOperations)
            : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Gets a single product upgrades operations.
        /// </summary>
        /// <param name="id">Identifier for the product upgrade.</param>
        /// <returns>The available product upgrade operations.</returns>
        public IProductUpgrades this[string id] => ById(id);

        /// <summary>
        /// Gets a single product upgrades operations.
        /// </summary>
        /// <param name="id">Identifier for the product upgrade.</param>
        /// <returns>The available product upgrade operations.</returns>
        public IProductUpgrades ById(string id)
        {
            return new ProductUpgradesOperations(Partner, id);
        }

        /// <summary>
        /// Checks the product upgrade eligibility.
        /// </summary>
        /// <param name="productUpgradesRequest">The product upgrade request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The eligibility object for the customer.</returns>
        public async Task<ProductUpgradeEligibility> CheckEligibilityAsync(ProductUpgradeRequest productUpgradesRequest, CancellationToken cancellationToken = default)
        {
            productUpgradesRequest.AssertNotNull(nameof(productUpgradesRequest));

            return await Partner.ServiceClient.PostAsync<ProductUpgradeRequest, ProductUpgradeEligibility>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetProductUpgradeEligibility.Path}",
                        Context),
                    UriKind.Relative),
                productUpgradesRequest,
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Create the product upgrade request.
        /// </summary>
        /// <param name="newEntity">The product upgrade request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The identifier for the product upgrade.</returns>
        public async Task<string> CreateAsync(ProductUpgradeRequest newEntity, CancellationToken cancellationToken = default)
        {
            newEntity.AssertNotNull(nameof(newEntity));

            HttpResponseMessage response = await Partner.ServiceClient.PostAsync<ProductUpgradeRequest, HttpResponseMessage>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.UpgradeProduct.Path}",
                    UriKind.Relative),
                newEntity,
                cancellationToken).ConfigureAwait(false);

            return response.Headers.Location != null ? response.Headers.Location.ToString() : string.Empty;
        }
    }
}