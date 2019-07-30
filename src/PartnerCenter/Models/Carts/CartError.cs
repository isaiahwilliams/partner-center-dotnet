// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Carts
{
    /// <summary>
    /// Represents an error associated to a cart line item.
    /// </summary>
    public class CartError
    {
        /// <summary>
        /// Gets or sets a cart error code.
        /// </summary>
        public CartErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets an error description.
        /// </summary>
        public string ErrorDescription { get; set; }
    }
}
