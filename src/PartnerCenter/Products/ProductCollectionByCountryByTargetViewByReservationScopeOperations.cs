// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models;
    using Models.JsonConverters;
    using Models.Products;

    /// <summary>
    /// Product operations by country, by target view and by reservation scope implementation class.
    /// </summary>
    internal class ProductCollectionByCountryByTargetViewByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string>>, IProductCollectionByCountryByTargetViewByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCollectionByCountryByTargetViewByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="targetView">The target view which contains the products.</param>
        /// <param name="country">The country on which to base the products.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the products.</param>
        public ProductCollectionByCountryByTargetViewByReservationScopeOperations(IPartner rootPartnerOperations, string targetView, string country, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string>(targetView, country, reservationScope))
        {
            targetView.AssertNotEmpty(nameof(targetView));
            country.AssertNotEmpty(nameof(country));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }

        /// <summary>
        /// Gets all the products in the given country, product collection and reservation scope.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All the products in the given country, product collection and reservation scope.</returns>
        public async Task<ResourceCollection<Product>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetProducts.Parameters.TargetView,
                    Context.Item1
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetProducts.Parameters.Country,
                    Context.Item2
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetProducts.Parameters.ReservationScope,
                    Context.Item3
                }
            };

            return await Partner.ServiceClient.GetAsync<ResourceCollection<Product>>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetProducts.Path}",
                    UriKind.Relative),
                parameters,
                new ResourceCollectionConverter<Product>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}