// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Usage
{
    /// <summary>
    /// Defines the usage summary for a specific customer.
    /// </summary>
    public sealed class CustomerUsageSummary : UsageSummaryBase
    {
        /// <summary>
        /// Gets or sets the spending budget allocated to the customer.
        /// </summary>
        public SpendingBudget Budget { get; set; }
    }
}