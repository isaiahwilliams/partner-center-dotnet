// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Carts
{
    using System.Collections.Generic;
    using Orders;

    /// <summary>Represents a result of a cart checkout.</summary>
    public class CartCheckoutResult : ResourceBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCheckoutResult" /> class.
        /// </summary>
        public CartCheckoutResult()
        {
            Orders = new List<Order>();
            OrderErrors = new List<OrderError>();
        }

        /// <summary>Gets or sets the orders created.</summary>
        public IEnumerable<Order> Orders { get; set; }

        /// <summary>
        /// Gets or sets a collection of order failure information.
        /// </summary>
        /// <value>A collection of order failure information.</value>
        public IEnumerable<OrderError> OrderErrors { get; set; }
    }
}
