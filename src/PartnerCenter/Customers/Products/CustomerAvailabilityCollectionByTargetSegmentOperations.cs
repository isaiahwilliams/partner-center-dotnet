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
    /// Implementation of customer availabilities operations by target segment.
    /// </summary>
    internal class CustomerAvailabilityCollectionByTargetSegmentOperations : BasePartnerComponent<Tuple<string, string, string, string>>, IAvailabilityCollectionByTargetSegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAvailabilityCollectionByTargetSegmentOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="productId">The product identifier.</param>
        /// <param name="skuId">The SKU identifier.</param>
        /// <param name="targetSegment">The target segment used for filtering the availabilities.</param>
        public CustomerAvailabilityCollectionByTargetSegmentOperations(IPartner rootPartnerOperations, string customerId, string productId, string skuId, string targetSegment)
          : base(rootPartnerOperations, new Tuple<string, string, string, string>(customerId, productId, skuId, targetSegment))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            productId.AssertNotEmpty(nameof(productId));
            skuId.AssertNotEmpty(nameof(skuId));
            targetSegment.AssertNotEmpty(nameof(targetSegment));
        }

        /// <summary>
        /// Gets the operations that can be applied on products that belong to a given target segment, and reservation scope.
        /// </summary>
        /// <param name="reservationScope">The reservation scope filter.</param>
        /// <returns>The availability collection operations by target segment by reservation scope.</returns>
        public IAvailabilityCollectionByTargetSegmentByReservationScopeOperations ByReservationScope(string reservationScope)
        {
            return new CustomerAvailabilityCollectionByTargetSegmentByReservationScopeOperations(
                Partner,
                Context.Item1,
                Context.Item2,
                Context.Item3,
                Context.Item4,
                reservationScope);
        }

        /// <summary>
        /// Gets all the availabilities for the provided SKU on a specific target segment.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The availability for the provided SKU on a specific target segment.</returns>
        public async Task<ResourceCollection<Availability>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
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