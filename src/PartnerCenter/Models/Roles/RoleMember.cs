// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Roles
{
    /// <summary>
    /// Represents a member of partner role.
    /// </summary>
    public sealed class RoleMember : ResourceBase
    {
        /// <summary>
        /// Gets or sets the account identifier.
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or set the identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        public string RoleId { get; set; }
    }
}