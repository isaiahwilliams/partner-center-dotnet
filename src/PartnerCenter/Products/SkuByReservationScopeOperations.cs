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
    /// Implements the product by reservation scope operations.
    /// </summary>
    internal class SkuByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string>>, ISkuByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkuByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="skuId">The SKU identifier.</param>
        /// <param name="country">The country on which to base the product.</param>
        /// <param name="reservationScope">The reservation scope on which to base the product.</param>
        public SkuByReservationScopeOperations(IPartner rootPartnerOperations, string productId, string skuId, string country, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string>(productId, skuId, country, reservationScope))
        {
        }

        /// <summary>
        /// Gets the information for the SKU.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The information for the SKU.</returns>
        public async Task<Sku> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetSku.Parameters.Country,
                    Context.Item3
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetSku.Parameters.ReservationScope,
                    Context.Item4
                }
            };

            return await Partner.ServiceClient.GetAsync<Sku>(
                new Uri(
                    string.Format(CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetSku.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}