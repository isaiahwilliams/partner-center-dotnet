// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerDirectoryRoles
{
    using System;

    /// <summary>
    /// Represents the behavior of directory role.
    /// </summary>
    public interface IDirectoryRole : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Gets the current directory role's user member collection operations.
        /// </summary>
        IUserMemberCollection UserMembers { get; }
    }
}