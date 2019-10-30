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
    using Models.Products;

    /// <summary>
    /// Implements a single customer's product by reservation scope operations.
    /// </summary>
    internal class CustomerSkuByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string>>, ICustomerSkuByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerSkuByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="skuId">The SKU identifier.</param>
        /// <param name="reservationScope">The reservation scope on which to base the product.</param>
        public CustomerSkuByReservationScopeOperations(IPartner rootPartnerOperations, string customerId, string productId, string skuId, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string>(customerId, productId, skuId, reservationScope))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            productId.AssertNotEmpty(nameof(productId));
            skuId.AssertNotEmpty(nameof(skuId));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }


        /// <summary>
        /// Gets the SKU information filted by the reservation scope.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The SKU information filted by the reservation scope.</returns>
        public async Task<Sku> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerSku.Parameters.ReservationScope,
                    Context.Item4
                }
            };

            return await Partner.ServiceClient.GetAsync<Sku>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerSku.Path}",
                        Context.Item1,
                        Context.Item2,
                        Context.Item3),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}