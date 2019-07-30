// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Roles
{
    /// <summary>
    /// Represents a customer directory role object.
    /// </summary>
    public sealed class DirectoryRole : ResourceBase
    {
        /// <summary>
        /// Gets or sets the identifier of the directory role.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the directory role.
        /// </summary>
        public string Name { get; set; }
    }
}