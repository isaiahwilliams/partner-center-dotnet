// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the standard links associated with a resource collection.
    /// </summary>
    public sealed class StandardResourceCollectionLinks : StandardResourceLinks
    {
        /// <summary>
        /// Gets or sets the next page of items.
        /// </summary>
        [JsonProperty]
        public Link Next { get; set; }

        /// <summary>
        /// Gets or sets the previous page of items.
        /// </summary>
        [JsonProperty]
        public Link Previous { get; set; }
    }
}