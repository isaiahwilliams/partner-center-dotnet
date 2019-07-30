// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.GenericOperations
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Groups operations for creating a single entity.
    /// </summary>
    /// <typeparam name="T">The entity type request.</typeparam>
    /// <typeparam name="T1">The entity type response.</typeparam>
    public interface IEntityCreateOperations<in T, T1>
    {
        /// <summary>
        /// Creates a new entity.
        /// </summary>
        /// <param name="newEntity">The new entity information.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The entity information that was just created.</returns>
        Task<T1> CreateAsync(T newEntity, CancellationToken cancellationToken = default);
    }
}