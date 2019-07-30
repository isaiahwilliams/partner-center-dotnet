// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Customers
{
    /// <summary>
    /// The customer billing profile information.
    /// </summary>
    public sealed class CustomerBillingProfile : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or stes the company name.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets the culture.
        /// </summary>
        public string Culture { get; set; }

        /// <summary>
        /// Gets or sets the default address.
        /// </summary>
        public Address DefaultAddress { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the profile.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }
    }
}