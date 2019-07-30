// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    /// <summary>
    /// Bundles the links for an order.
    /// </summary>
    public sealed class OrderLinks : StandardResourceLinks
    {
        /// <summary>
        /// Gets or sets the link to the patch operation. 
        /// </summary>
        public Link PatchOperation { get; set; }

        /// <summary>
        /// Gets or sets the link to the provisioning status of an order.
        /// </summary>
        public Link ProvisioningStatus { get; set; }
    }
}