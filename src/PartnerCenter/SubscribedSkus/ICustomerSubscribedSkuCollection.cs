// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.SubscribedSkus
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Models;
    using Models.Licenses;

    /// <summary>
    /// Represents the behavior of the customer's subscribed products.
    /// </summary>
    public interface ICustomerSubscribedSkuCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets all the customer subscribed products.
        /// </summary>
        /// <param name="licenseGroupIds">A collection of license group identifiers.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All the customer subscribed products.</returns>
        Task<ResourceCollection<SubscribedSku>> GetAsync(List<LicenseGroupId> licenseGroupIds = null, CancellationToken cancellationToken = default);
    }
}