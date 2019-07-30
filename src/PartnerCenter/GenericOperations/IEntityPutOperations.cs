// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.GenericOperations
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Groups operations for updating a single entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public interface IEntityPutOperations<T> where T : ResourceBase
    {
        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="entity">The entity information.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The updated entity.</returns>
        Task<T> PutAsync(T entity, CancellationToken cancellationToken = default);
    }
}