// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using GenericOperations;
    using Models;
    using Models.Subscriptions;
    using Usage;

    /// <summary>
    /// Represents the behavior of the customer subscriptions as a whole.
    /// </summary>
    public interface ISubscriptionCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<Subscription, ResourceCollection<Subscription>>, IEntitySelector<string, ISubscription>
    {
        /// <summary>
        /// Groups customer subscriptions by an order.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <returns>The order subscriptions operations.</returns>
        IEntireEntityCollectionRetrievalOperations<Subscription, ResourceCollection<Subscription>> ByOrder(string orderId);

        /// <summary>
        /// Groups customer subscriptions by a partner.
        /// </summary>
        /// <param name="partnerId">The partner identifier.</param>
        /// <returns>The partner subscriptions operations.</returns>
        IEntireEntityCollectionRetrievalOperations<Subscription, ResourceCollection<Subscription>> ByPartner(string partnerId);

        /// <summary>
        /// Gets the subscription usage records behavior for the customer.
        /// </summary>
        ISubscriptionMonthlyUsageRecordCollection UsageRecords { get; }
    }
}