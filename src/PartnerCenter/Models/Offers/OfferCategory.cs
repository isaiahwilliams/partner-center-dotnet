// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Offers
{
    /// <summary>
    /// Represents an offer category.
    /// </summary>
    public sealed class OfferCategory : ResourceBase
    {
        /// <summary>
        /// Gets or sets the country where the offer category applies.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the category identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the locale to which the offer category applies.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        /// Gets or sets the category name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category rank in the collection.
        /// </summary>
        public int Rank { get; set; }
    }
}