// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Usage
{
    using System;

    /// <summary>
    /// Defines the daily usage record of a specific subscription.
    /// </summary>
    public sealed class SubscriptionDailyUsageRecord : UsageRecordBase
    {
        /// <summary>
        /// Gets or sets the usage date.
        /// </summary>
        public DateTimeOffset DateUsed { get; set; }
    }
}