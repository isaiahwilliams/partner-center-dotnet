// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Microsoft.Store.PartnerCenter.Products
{
    using System;
    using System.Collections.Generic;
    using Extensions;
    using System.Threading.Tasks;
    using System.Threading;
    using Models;
    using Models.JsonConverters;
    using Models.Products;
    using System.Globalization;

    /// <summary>
    /// Implements the operations for availabilities by target segement and reservation scope.
    /// </summary>
    internal class AvailabilityCollectionByTargetSegmentByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string, string>>, IAvailabilityCollectionByTargetSegmentByReservationScopeOperations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailabilityCollectionByTargetSegmentByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="productId">The corresponding product identifier.</param>
        /// <param name="skuId">The corresponding SKU identifier.</param>
        /// <param name="country">The country on which to base the product.</param>
        /// /// <param name="targetSegment">The target segment used for filtering the availabilities.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the availabilities.</param>
        public AvailabilityCollectionByTargetSegmentByReservationScopeOperations(IPartner rootPartnerOperations, string productId, string skuId, string country, string targetSegment, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string, string>(productId, skuId, country, targetSegment, reservationScope))
        {
            productId.AssertNotEmpty(nameof(productId));
            skuId.AssertNotEmpty(nameof(skuId));
            country.AssertNotEmpty(nameof(country));
            targetSegment.AssertNotEmpty(nameof(targetSegment));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }

        /// <summary>
        /// Gets all the availabilities for the provided sku on a specific reservation scope given a target segment.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All the availabilities for the provided sku on a specific reservation scope given a target segment..</returns>
        public async Task<ResourceCollection<Availability>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetAvailabilities.Parameters.Country,
                    Context.Item3
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetAvailabilities.Parameters.TargetSegment,
                    Context.Item4
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetAvailabilities.Parameters.ReservationScope,
                    Context.Item5
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
