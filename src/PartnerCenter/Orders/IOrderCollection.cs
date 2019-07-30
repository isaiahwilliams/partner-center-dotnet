// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using GenericOperations;
    using Models;
    using Models.Offers;
    using Models.Orders;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Encapsulates the order collection operations.
    /// </summary>
    public interface IOrderCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<Order, ResourceCollection<Order>>, IEntityCreateOperations<Order, Order>, IEntitySelector<string, IOrder>
    {
        /// <summary>
        /// Gets the order collection behavior given a billing cycle type.
        /// </summary>
        /// <param name="billingCycleType">The billing cycle type.</param>
        /// <returns>The order collection by billing cycle type.</returns>
        IOrderCollectionByBillingCycleType ByBillingCycleType(BillingCycleType billingCycleType);

        /// <summary>
        /// Gets a collection of orders.
        /// </summary>
        /// <param name="includePrice">A flag indicating whether to include pricing details in the order information or not.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The collection of orders including pricing details (based on access permissions) when requested.</returns>
        Task<ResourceCollection<Order>> GetAsync(bool includePrice, CancellationToken cancellationToken = default);
    }
}
