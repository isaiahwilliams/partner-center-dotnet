// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.GenericOperations
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Groups operations for getting a single entity.
    /// </summary>
    /// <typeparam name="T">The entity type.</typeparam>
    public interface IEntityGetOperations<T>
    {
        /// <summary>
        /// Retrieves an entity.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The entity.</returns>
        Task<T> GetAsync(CancellationToken cancellationToken = default);
    }
}