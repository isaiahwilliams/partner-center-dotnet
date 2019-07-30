// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Users
{
    /// <summary>
    /// Class that stores a password profile.
    /// </summary>
    public sealed class PasswordProfile
    {
        /// <summary>
        /// Gets or sets a value indicating whether force change password on first login is required or not.
        /// </summary>
        public bool ForceChangePassword { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }
    }
}