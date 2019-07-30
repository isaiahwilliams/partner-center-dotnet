// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Offers
{
    using Newtonsoft.Json;

    /// <summary>
    /// Bundles offer links.
    /// </summary>
    public sealed class OfferLinks : StandardResourceLinks
    {
        /// <summary>
        /// Gets or sets the learn more link.
        /// </summary>
        [JsonProperty]
        public Link LearnMore { get; set; }
    }
}