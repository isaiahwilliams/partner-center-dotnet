// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Models;
    using Models.Products;
    using Models.JsonConverters;
    using Extensions;

    /// <summary>
    /// Implements the product operations by country, by collection id and by reservation scope.
    /// </summary>
    internal class ProductCollectionByCountryByTargetViewByTargetSegmentByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string>>, IProductCollectionByCountryByTargetViewByTargetSegmentByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCollectionByCountryByTargetViewByTargetSegmentByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="targetView">The target view which contains the products.</param>
        /// <param name="country">The country on which to base the products.</param>
        /// <param name="targetSegment">The target segment used for filtering the products.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the products.</param>
        public ProductCollectionByCountryByTargetViewByTargetSegmentByReservationScopeOperations(IPartner rootPartnerOperations, string targetView, string country, string targetSegment, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string>(targetView, country, targetSegment, reservationScope))
        {
            targetView.AssertNotEmpty(nameof(targetView));
            country.AssertNotEmpty(nameof(country));
            targetSegment.AssertNotEmpty(nameof(targetSegment));
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
                    PartnerService.Instance.Configuration.Apis.GetProducts.Parameters.TargetSegment,
                    Context.Item3
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetProducts.Parameters.ReservationScope,
                    Context.Item4
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