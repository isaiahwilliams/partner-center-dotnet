// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Models.Products;

    /// <summary>
    /// Impelements the product by reservation scope operations.
    /// </summary>
    internal class ProductByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string>>, IProductByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="country">The country on which to base the product.</param>
        /// <param name="reservationScope">The reservation scope on which to base the product.</param>
        public ProductByReservationScopeOperations(IPartner rootPartnerOperations, string productId, string country, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string>(productId, country, reservationScope))
        {
        }


        /// <summary>
        /// Gets the product information.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The available product information.</returns>
        public async Task<Product> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetProduct.Parameters.Country,
                    Context.Item2
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetProduct.Parameters.ReservationScope,
                    Context.Item3
                }
            };

            return await Partner.ServiceClient.GetAsync<Product>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetProduct.Path}",
                        Context.Item1),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}