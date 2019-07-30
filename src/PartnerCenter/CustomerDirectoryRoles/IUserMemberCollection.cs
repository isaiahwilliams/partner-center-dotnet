// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerDirectoryRoles
{
    using GenericOperations;
    using Models;
    using Models.Query;
    using Models.Roles;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the behavior of user member collection.
    /// </summary>
    public interface IUserMemberCollection : IPartnerComponent<Tuple<string, string>>, IEntityCreateOperations<UserMember, UserMember>, IEntireEntityCollectionRetrievalOperations<UserMember, SeekBasedResourceCollection<UserMember>>, IEntitySelector<string, IUserMember>
    {
        /// <summary>
        /// Queries the user members of a customer directory role.
        /// </summary>
        /// <param name="query">A query to apply onto user member collection.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The directory role user members.</returns>
        Task<SeekBasedResourceCollection<UserMember>> QueryAsync(IQuery query, CancellationToken cancellationToken = default);
    }
}