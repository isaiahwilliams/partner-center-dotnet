// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Agreements
{
    /// <summary>
    /// This class represents the contact information for a specific individual.
    /// </summary>
    public sealed class Contact
    {
        /// <summary>
        /// Gets or sets the contact's email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the contact's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the contact's phone number.
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}