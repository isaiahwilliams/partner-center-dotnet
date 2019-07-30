// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using Extensions;
    using Models;
    using Models.JsonConverters;
    using Models.Usage;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Implements operations related to a single subscription daily usage records.
    /// </summary>
    internal class SubscriptionDailyUsageRecordCollectionOperations : BasePartnerComponent<Tuple<string, string>>, ISubscriptionDailyUsageRecordCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionDailyUsageRecordCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="subscriptionId">The subscription identifier.</param>
        public SubscriptionDailyUsageRecordCollectionOperations(IPartner rootPartnerOperations, string customerId, string subscriptionId)
          : base(rootPartnerOperations, new Tuple<string, string>(customerId, subscriptionId))
        {
            customerId.AssertNotEmpty(nameof(customerId));
            subscriptionId.AssertNotEmpty(nameof(subscriptionId));
        }

        /// <summary>
        /// Retrieves the subscription daily usage records.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Collection of subscription daily usage records.</returns>
        public async Task<ResourceCollection<SubscriptionDailyUsageRecord>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<SubscriptionDailyUsageRecord>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetSubscriptionDailyUsageRecords.Path}",
                        Context.Item1,
                        Context.Item2),
                    UriKind.Relative),
                new ResourceCollectionConverter<SubscriptionDailyUsageRecord>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}