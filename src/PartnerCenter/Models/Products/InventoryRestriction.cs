// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Products
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class that represents an inventory restriction.
    /// </summary>
    public class InventoryRestriction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryRestriction" /> class.
        /// </summary>
        public InventoryRestriction()
        {
            Properties = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets the set of properties that further describe this restriction.
        /// </summary>
        public Dictionary<string, string> Properties { get; private set; }

        /// <summary>
        /// Gets or sets the reason code.
        /// </summary>
        public string ReasonCode { get; set; }
    }
}