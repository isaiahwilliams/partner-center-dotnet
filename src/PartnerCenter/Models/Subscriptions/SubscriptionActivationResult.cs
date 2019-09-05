// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    /// <summary>
    /// Provides information about activation status of a subscription.
    /// </summary>
    public sealed class SubscriptionActivationResult
    {
        /// <summary>
        /// Gets or sets subscription identifier.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets activation \status.
        /// </summary>
        public string Status { get; set; }
    }
}