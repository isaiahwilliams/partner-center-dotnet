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
    /// Implementation of customer availabilities operations by target segment by reservation scope.
    /// </summary>
    internal class CustomerAvailabilityCollectionByTargetSegmentByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string, string>>, IAvailabilityCollectionByTargetSegmentByReservationScopeOperations
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAvailabilityCollectionByTargetSegmentByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier for which to retrieve the availabilities.</param>
        /// <param name="productId">The product identifier for which to retrieve the availabilities.</param>
        /// <param name="skuId">The SKU identifier for which to retrieve its availabilities.</param>
        /// <param name="targetSegment">The target segment used for filtering the availabilities.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the availabilities.</param>
        public CustomerAvailabilityCollectionByTargetSegmentByReservationScopeOperations(IPartner rootPartnerOperations, string customerId, string productId, string skuId, string targetSegment, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string, string>(customerId, productId, skuId, targetSegment, reservationScope))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            productId.AssertNotEmpty(nameof(productId));
            skuId.AssertNotEmpty(nameof(skuId));
            targetSegment.AssertNotEmpty(nameof(targetSegment));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }

        /// <summary>
        /// Gets all the availabilities for the provided SKU on a specific reservation scope for the given target segment.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The availabilities for the provided SKU on a specific reservation scope for the given target segment.</returns>
        public async Task<ResourceCollection<Availability>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerAvailabilities.Parameters.ReservationScope,
                    Context.Item5
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerAvailabilities.Parameters.TargetSegment,
                    Context.Item4
                }
            };

            return await Partner.ServiceClient.GetAsync<ResourceCollection<Availability>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerAvailabilities.Path}",
                        Context.Item1,
                        Context.Item2,
                        Context.Item3),
                    UriKind.Relative),
                parameters,
                new ResourceCollectionConverter<Availability>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}