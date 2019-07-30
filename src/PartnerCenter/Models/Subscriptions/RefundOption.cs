// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    using System;

    /// <summary>
    /// Represents the refund option for a subscription.
    /// </summary>
    public sealed class RefundOption
    {
        /// <summary>
        /// Gets or sets the timestamp when this policy expires if applicable, null otherwise.
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or sets the type of refund ("Full, Partial")
        /// </summary>
        public string Type { get; set; }
    }
}
