// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    /// <summary>
    /// Represents the available role operations.
    /// </summary>
    public interface IRole : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the partner role member collection operations.
        /// </summary>
        IRoleMemberCollection Members { get; }
    }
}