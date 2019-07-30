// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a cancellation policy.
    /// </summary>
    public class CancellationPolicy
    {
        /// <summary>
        /// Gets or sets the refund options that can apply to this cancellation policy.
        /// </summary>
        public IEnumerable<CancellationRefundOption> RefundOptions { get; set; }
    }
}