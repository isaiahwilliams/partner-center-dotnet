// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using GenericOperations;
    using Models;
    using Models.Usage;
    using System;

    /// <summary>
    /// Defines the behavior for a subscription's daily usage records.
    /// </summary>
    public interface ISubscriptionDailyUsageRecordCollection : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<SubscriptionDailyUsageRecord, ResourceCollection<SubscriptionDailyUsageRecord>>
    {
    }
}