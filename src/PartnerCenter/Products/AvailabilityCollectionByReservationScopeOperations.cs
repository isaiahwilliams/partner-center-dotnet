// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using System.Collections.Generic;
    using GenericOperations;
    using System;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Globalization;
    using Models.JsonConverters;
    using Models.Products;

    /// <summary>
    /// Implements the operations to get availabilities by reservation scope.
    /// </summary>
    internal class AvailabilityCollectionByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string>>, IAvailabilityCollectionByReservationScopeOperations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityCollectionByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="productId">The corresponding product identifier.</param>
        /// <param name="skuId">The corresponding SKU identifier.</param>
        /// <param name="country">The country on which to base the product.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the availabilities.</param>
        public AvailabilityCollectionByReservationScopeOperations(IPartner rootPartnerOperations, string productId, string skuId, string country, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string>(productId, skuId, country, reservationScope))
        {
        }

        /// <summary>
        /// Gets all the availabilities for the provided SKU on a specific reservation scope.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The availability for the provided SKU on a specific target segment.</returns>
        public async Task<ResourceCollection<Availability>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetAvailabilities.Parameters.Country,
                    Context.Item3
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetAvailabilities.Parameters.ReservationScope,
                    Context.Item4
                }
            };

            return await Partner.ServiceClient.GetAsync<ResourceCollection<Availability>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetAvailabilities.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                parameters,
                new ResourceCollectionConverter<Availability>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}