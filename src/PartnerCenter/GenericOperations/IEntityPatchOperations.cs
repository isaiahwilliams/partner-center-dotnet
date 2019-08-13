// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.GenericOperations
{
    using System.Threading;
    using System.Threading.Tasks;
    using Models;

    /// <summary>
    /// Groups operations for patching a single entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public interface IEntityPatchOperations<T> where T : ResourceBase
    {
        /// <summary>
        /// Patches an entity.
        /// </summary>
        /// <param name="entity">The entity information.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The updated entity.</returns>
        Task<T> PatchAsync(T entity, CancellationToken cancellationToken = default);
    }
}