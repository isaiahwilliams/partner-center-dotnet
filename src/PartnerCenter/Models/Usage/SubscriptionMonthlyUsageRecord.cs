// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Usage
{
    using Models.Subscriptions;

    /// <summary>
    /// Defines the monthly usage record of a subscription.
    /// </summary>
    public sealed class SubscriptionMonthlyUsageRecord : UsageRecordBase
    {
        /// <summary>
        /// Gets or sets the offer identifier associated to this subscription.
        /// </summary>
        public string OfferId { get; set; }

        /// <summary>Gets or sets the partner on record.</summary>
        public string PartnerOnRecord { get; set; }

        /// <summary>
        /// Gets or sets the status of the subscription.
        /// </summary>
        public SubscriptionStatus Status { get; set; }
    }
}