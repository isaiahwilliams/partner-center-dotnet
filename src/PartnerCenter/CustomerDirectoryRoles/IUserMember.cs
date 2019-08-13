// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerDirectoryRoles
{
    using System;
    using GenericOperations;
    using Models.Roles;

    /// <summary>
    /// Represents the behavior of a user member.
    /// </summary>
    public interface IUserMember : IPartnerComponent<Tuple<string, string, string>>, IEntityDeleteOperations<UserMember>
    {
    }
}