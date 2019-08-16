// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using GenericOperations;
    using Models;
    using Models.Roles;

    /// <summary>
    /// Represents the behavior of the role member collection.
    /// </summary>
    public interface IRoleMemberCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<RoleMember, SeekBasedResourceCollection<RoleMember>>
    {
    }
}