// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Usage
{
    /// <summary>
    /// The spending budget allocated to the customer by the partner.
    /// </summary>
    public sealed class SpendingBudget : ResourceBase
    {
        /// <summary>
        /// Gets or sets the usage spending budget.
        /// </summary>
        public decimal? Amount { get; set; }
    }
}