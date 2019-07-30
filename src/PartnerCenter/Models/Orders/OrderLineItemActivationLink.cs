// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    /// <summary>
    /// Represents the activation link for the order line item.
    /// </summary>
    public sealed class OrderLineItemActivationLink
    {
        /// <summary>
        /// Gets or sets the line item number.
        /// </summary>
        public int LineItemNumber { get; set; }

        /// <summary>
        /// Gets or sets the activation link.
        /// </summary>
        public Link Link { get; set; }
    }
}