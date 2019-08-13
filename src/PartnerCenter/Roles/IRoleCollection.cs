// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using System.Threading;
    using System.Threading.Tasks;
    using GenericOperations;
    using Models;
    using Models.Query;
    using Models.Roles;

    /// <summary>
    /// Represents the available operations for roles.
    /// </summary>
    public interface IRoleCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<Role, SeekBasedResourceCollection<Role>> // , IEntitySelector<string, ICustomerUser>
    {
        /// <summary>
        /// Queries for the list of partner roles.
        /// - Count queries are not supported by this operation.
        /// - You can set page size and sort option.
        /// - You can navigate to other pages by specifying a seek query with the seek operation and the continuation
        ///   token sent by the previous operation.
        /// </summary>
        /// <param name="query">A query to apply onto customer users. Check <see cref="QueryFactory" /> to see how
        /// to build queries.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The requested customer users.</returns>
        Task<SeekBasedResourceCollection<Role>> QueryAsync(IQuery query, CancellationToken cancellationToken = default);
    }
}