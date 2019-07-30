// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using Extensions;
    using Models.Usage;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// This class implements the operations for a customer's subscription.
    /// </summary>
    internal class SubscriptionUsageSummaryOperations : BasePartnerComponent<Tuple<string, string>>, ISubscriptionUsageSummary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUsageSummaryOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="subscriptionId">The subscription identifier.</param>
        public SubscriptionUsageSummaryOperations(IPartner rootPartnerOperations, string customerId, string subscriptionId)
          : base(rootPartnerOperations, new Tuple<string, string>(customerId, subscriptionId))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            subscriptionId.AssertNotEmpty(nameof(subscriptionId));
        }

        /// <summary>
        /// Gets the subscription usage summary.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The subscription usage summary.</returns>
        public async Task<SubscriptionUsageSummary> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<SubscriptionUsageSummary>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetSubscriptionUsageSummary.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }
    }
}