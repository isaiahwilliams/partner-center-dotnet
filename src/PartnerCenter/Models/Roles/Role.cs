// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Roles
{
    /// <summary>
    /// Represents a role at the partner level.
    /// </summary>
    public sealed class Role : ResourceBase
    {
        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the role.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
        public string Name { get; set; }
    }
}