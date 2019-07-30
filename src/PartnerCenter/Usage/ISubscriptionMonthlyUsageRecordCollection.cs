// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using GenericOperations;
    using Models;
    using Models.Usage;

    /// <summary>
    /// Defines the behavior for a customer's subscription usage records.
    /// </summary>
    public interface ISubscriptionMonthlyUsageRecordCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<SubscriptionMonthlyUsageRecord, ResourceCollection<SubscriptionMonthlyUsageRecord>>
    {
    }
}