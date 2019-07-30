// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.GenericOperations
{
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Groups operations for checking if a single entity exists or not.
    /// </summary>
    public interface IEntityExistsOperations
    {

        /// <summary>
        /// Checks if an entity exists or not.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>
        /// <c>true</c> if the entity exists; otherwise <c>false</c>.
        /// </returns>
        Task<bool> ExistsAsync(CancellationToken cancellationToken = default);
    }
}