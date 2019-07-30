// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Partners
{
    /// <summary>
    /// Represents a partner's support profile.
    /// </summary>
    public sealed class SupportProfile : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        public string Telephone { get; set; }

        /// <summary>
        /// Gets or sets the website.
        /// </summary>
        public string Website { get; set; }
    }
}