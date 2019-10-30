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
    internal class CustomerProductByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string>>, ICustomerProductByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProductByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="reservationScope">The reservation scope on which to base the product.</param>
        public CustomerProductByReservationScopeOperations(IPartner rootPartnerOperations, string customerId, string productId, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string>(customerId, productId, reservationScope))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            productId.AssertNotEmpty(nameof(productId));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }

        /// <summary>
        /// Gets the product information.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The production information.</returns>
        public async Task<Product> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerProduct.Parameters.ReservationScope,
                    Context.Item3
                }
            };

            return await Partner.ServiceClient.GetAsync<Product>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerProduct.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}