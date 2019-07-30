// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerUsers
{
    using GenericOperations;
    using Models;
    using Models.Query;
    using Models.Users;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the behavior of the customers users.
    /// </summary>
    public interface ICustomerUserCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<CustomerUser, SeekBasedResourceCollection<CustomerUser>>, IEntityCreateOperations<CustomerUser, CustomerUser>, IEntitySelector<string, ICustomerUser>
    {
        /// <summary>
        /// Queries users of customer.
        /// - Count queries are not supported by this operation.
        /// - You can set page size, filter and sort option.
        /// - You can navigate to other pages by specifying a seek query with the seek operation and the continuation
        ///   token sent by the previous operation.
        /// </summary>
        /// <param name="query">A query to apply onto customer users. Check <see cref="QueryFactory" /> to see how
        /// to build queries.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The requested customer users.</returns>
        Task<SeekBasedResourceCollection<CustomerUser>> QueryAsync(IQuery query, CancellationToken cancellationToken = default);
    }
}