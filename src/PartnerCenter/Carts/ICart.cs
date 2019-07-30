// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Carts
{
    using GenericOperations;
    using Models.Carts;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Encapsulates a customer cart behavior.
    /// </summary>
    public interface ICart : IPartnerComponent<Tuple<string, string>>, IEntityPutOperations<Cart>, IEntityGetOperations<Cart>
    {
        /// <summary>
        /// Checks out the cart.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The cart checkout result.</returns>
        Task<CartCheckoutResult> CheckoutAsync(CancellationToken cancellationToken = default);
    }
}