// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class that represents an inventory check request.
    /// </summary>
    public sealed class InventoryCheckRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryCheckRequest" /> class.
        /// </summary>
        public InventoryCheckRequest()
        {
            InventoryContext = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets any context values that apply towards inventory check of the provided items.
        /// </summary>
        public Dictionary<string, string> InventoryContext { get; private set; }

        /// <summary>
        /// Gets or sets the target items for the inventory check.
        /// </summary>
        public IEnumerable<InventoryItem> TargetItems { get; set; }
    }
}