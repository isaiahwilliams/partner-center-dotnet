// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerDirectoryRoles
{
    using GenericOperations;
    using Models;
    using Models.Roles;

    /// <summary>
    /// Represents the behavior of directory role collection.
    /// </summary>
    public interface IDirectoryRoleCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<DirectoryRole, ResourceCollection<DirectoryRole>>, IEntitySelector<string, IDirectoryRole>
    {
    }
}