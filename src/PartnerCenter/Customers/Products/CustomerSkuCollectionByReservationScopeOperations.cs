// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Products
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models;
    using Models.JsonConverters;
    using Models.Products;
    using PartnerCenter.Products;

    /// <summary>
    /// Implementation of customer sku collection operations by reservation scope.
    /// </summary>
    internal class CustomerSkuCollectionByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string>>, ISkuCollectionByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSkuCollectionByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier for which to retrieve the SKUs.</param>
        /// <param name="productId">The product identifier for which to retrieve its SKUs.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the SKUs.</param>
        public CustomerSkuCollectionByReservationScopeOperations(IPartner rootPartnerOperations, string customerId, string productId, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string>(customerId, productId, reservationScope))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            productId.AssertNotEmpty(nameof(productId));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }

        /// <summary>
        /// Gets all the SKUs for the provided product and reservation scope.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All the SKUs for the provided product and reservation scope.</returns>
        public async Task<ResourceCollection<Sku>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerSkus.Parameters.ReservationScope,
                    Context.Item3
                }
            };

            return await Partner.ServiceClient.GetAsync<ResourceCollection<Sku>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerSkus.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                parameters,
                new ResourceCollectionConverter<Product>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}