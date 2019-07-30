// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using GenericOperations;
    using Models.Orders;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Encapsulates a customer order behavior.
    /// </summary>
    public interface IOrder : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<Order>, IEntityPatchOperations<Order>
    {
        /// <summary>
        /// Gets order activation link collection operations.
        /// </summary>
        IOrderActivationLinkCollection OrderActivationLinks { get; }

        /// <summary>
        /// Gets the line item collection operations.
        /// </summary>
        IOrderLineItemCollection OrderLineItems { get; }

        /// <summary>
        /// Gets the order provisioning status operations.
        /// </summary>
        IOrderProvisioningStatus ProvisioningStatus { get; }

        /// <summary>
        /// Gets the order information.
        /// </summary>
        /// <param name="includePrice">A flag indicating whether to include pricing details in the order information or not.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The order information including pricing details (based on access permissions) when requested.</returns>
        Task<Order> GetAsync(bool includePrice, CancellationToken cancellationToken = default);
    }
}