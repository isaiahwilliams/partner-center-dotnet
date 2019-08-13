// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models;
    using Models.JsonConverters;
    using Models.Orders;

    /// <summary>
    /// Order activation link operations implementation class.
    /// </summary>
    internal class OrderActivationLinkCollectionOperations : BasePartnerComponent<Tuple<string, string>>, IOrderActivationLinkCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderActivationLinkCollectionOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="orderId">The order identifier.</param>
        public OrderActivationLinkCollectionOperations(IPartner rootPartnerOperations, string customerId, string orderId)
            : base(rootPartnerOperations, new Tuple<string, string>(customerId, orderId))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            orderId.AssertNotEmpty(nameof(orderId));
        }

        /// <summary>
        /// Gets the order activation link collection.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The order activation link collection.</returns>
        public async Task<ResourceCollection<OrderLineItemActivationLink>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<OrderLineItemActivationLink>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetOrderActivationLinks.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                new ResourceCollectionConverter<Order>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}