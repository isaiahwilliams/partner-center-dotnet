// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Usage
{
    /// <summary>
    /// This class defines the monthly usage record of a customer for all its subscriptions.
    /// </summary>
    public sealed class CustomerMonthlyUsageRecord : UsageRecordBase
    {
        /// <summary>
        /// Gets or sets the spending budget allocated for the customer.
        /// </summary>
        public SpendingBudget Budget { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the customer's Azure subscription was upgraded.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this customer's Azure subscription was upgraded; otherwise, <c>false</c>.
        /// </value>
        public bool IsUpgraded { get; set; }

        /// <summary>
        /// Gets or sets the percentage used out of the allocated budget.
        /// </summary>
        public decimal PercentUsed { get; set; }
    }
}