// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Customers
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents a partner's customer.
    /// </summary>
    public sealed class Customer : ResourceBaseWithLinks<StandardResourceLinks>
    {
        /// <summary>
        /// Gets or sets a value that indicates if delegated access is allowed for this customer or not.
        /// </summary>
        public bool? AllowDelegatedAccess { get; set; }

        /// <summary>
        /// Gets or sets the indirect reseller associated to this customer account.
        /// This value can be set only by indirect CSP partners.
        /// </summary>
        public string AssociatedPartnerId { get; set; }

        /// <summary>
        /// Gets or sets the customer's billing profile.
        /// </summary>
        public CustomerBillingProfile BillingProfile { get; set; }

        /// <summary>
        /// Gets or sets the customer commerce identifier.
        /// </summary>
        public string CommerceId { get; set; }

        /// <summary>
        /// Gets or sets the customer's company profile.
        /// </summary>
        public CustomerCompanyProfile CompanyProfile { get; set; }

        /// <summary>
        /// Gets the custom domains.
        /// </summary>
        public IEnumerable<string> CustomDomains { get; private set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the customer's relationship to partner.
        /// </summary>
        public CustomerPartnerRelationship RelationshipToPartner { get; set; }

        /// <summary>
        /// Gets or sets the user credentials.
        /// </summary>
        public UserCredentials UserCredentials { get; set; }
    }
}