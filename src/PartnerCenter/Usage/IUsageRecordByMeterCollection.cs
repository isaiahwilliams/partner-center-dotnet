// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Usage;

    /// <summary>
    /// Defines the behavior for a subscription's meter usage records.
    /// </summary>
    public interface IUsageRecordByMeterCollection : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<MeterUsageRecord, ResourceCollection<MeterUsageRecord>>
    {
    }
}