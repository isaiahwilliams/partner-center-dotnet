// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the operations available on a customer's subscription registrations.
    /// </summary>
    public interface ISubscriptionRegistration : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Register a subscription to enable Azure Reserved instance purchase.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The location which indicates the URL of the API to query for status.</returns>
        Task<string> RegisterAsync(CancellationToken cancellationToken = default);
    }
}