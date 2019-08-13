// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerUsers
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Roles;

    /// <summary>
    /// Represents the behavior of the customers user's directory roles.
    /// </summary>
    public interface ICustomerUserRoleCollection : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<DirectoryRole, ResourceCollection<DirectoryRole>>
    {
    }
}
