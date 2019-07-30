// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    /// <summary>
    /// Represents the quantity provisioning status.
    /// </summary>
    public class QuantityProvisioningStatus : ResourceBase
    {
        /// <summary>
        /// Gets or sets quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets provisioning status.
        /// </summary>
        public string Status { get; set; }
    }
}