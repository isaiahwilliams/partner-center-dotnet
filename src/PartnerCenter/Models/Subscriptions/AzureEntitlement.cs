// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    /// <summary>
    /// Represents an Azure entitlement.
    /// </summary>
    public class AzureEntitlement
    {
        /// <summary>
        /// Gets or sets the friendly name of the entitlement.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the entitlement.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the status of the entitlement.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the subscription identifier of the entitlement.
        /// </summary>
        public string SubscriptionId { get; set; }
    }
}