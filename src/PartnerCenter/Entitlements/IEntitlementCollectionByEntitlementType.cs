// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Entitlements
{
    using GenericOperations;
    using Models;
    using Models.Entitlements;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the operations that can be performed on entitlements (by type) associated to the customer based on the logged in partner.
    /// </summary>
    public interface IEntitlementCollectionByEntitlementType : IEntireEntityCollectionRetrievalOperations<Entitlement, ResourceCollection<Entitlement>>
    {
        /// <summary>
        /// Gets an entitlement collection with the given entitlement type.
        /// </summary>
        /// <param name="showExpiry">A flag to indicate if the expiry date is required to be returned along with the entitlement (if applicable).</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The collection of entitlements corresponding to a specific entitlement type for the customer.</returns>
        Task<ResourceCollection<Entitlement>> GetAsync(bool showExpiry, CancellationToken cancellationToken = default);
    }
}