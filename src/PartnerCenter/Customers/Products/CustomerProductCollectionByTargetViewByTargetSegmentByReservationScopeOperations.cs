﻿// Copyright (c) Isaiah Williams. All rights reserved.
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

    /// <summary>
    /// Implements the product operations by customer, by target view, by target segment, and by reservation scope.
    /// </summary>
    internal class CustomerProductCollectionByTargetViewByTargetSegmentByReservationScopeOperations : BasePartnerComponent<Tuple<string, string, string, string>>, ICustomerProductCollectionByTargetViewByTargetSegmentByReservationScope
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerProductCollectionByTargetViewByTargetSegmentByReservationScopeOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer id for which to retrieve the products.</param>
        /// <param name="targetView">The target view which contains the products.</param>
        /// <param name="targetSegment">The target segment used for filtering the products.</param>
        /// <param name="reservationScope">The reservation scope used for filtering the products.</param>
        public CustomerProductCollectionByTargetViewByTargetSegmentByReservationScopeOperations(IPartner rootPartnerOperations, string customerId, string targetView, string targetSegment, string reservationScope) :
            base(rootPartnerOperations, new Tuple<string, string, string, string>(customerId, targetView, targetSegment, reservationScope))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            targetView.AssertNotEmpty(nameof(targetView));
            targetSegment.AssertNotEmpty(nameof(targetSegment));
            reservationScope.AssertNotEmpty(nameof(reservationScope));
        }

        /// <summary>
        /// Gets all the products in a given product collection and that apply to a given customer, filtered by reservation scope.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The products in a given product collection and that apply to a given customer, filtered by reservation scope.</returns>
        public async Task<ResourceCollection<Product>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerProducts.Parameters.TargetView,
                    Context.Item2
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerProducts.Parameters.TargetSegment,
                    Context.Item4
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetCustomerProducts.Parameters.ReservationScope,
                    Context.Item4
                }
            };

            return await Partner.ServiceClient.GetAsync<ResourceCollection<Product>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerProducts.Path}",
                        Context.Item1),
                    UriKind.Relative),
                parameters,
                new ResourceCollectionConverter<Product>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}
