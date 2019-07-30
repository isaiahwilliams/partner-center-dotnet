// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    /// <summary>
    /// Represents a form of support contact for a customer's subscription.
    /// </summary>
    public sealed class SupportContact : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the support MPN identifier.
        /// </summary>
        public string SupportMpnId { get; set; }

        /// <summary>
        /// Gets or sets the support tenant identifier.
        /// </summary>
        public string SupportTenantId { get; set; }
    }
}