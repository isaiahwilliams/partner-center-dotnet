// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerUsers
{
    using Models;
    using Models.Licenses;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the behavior of a customer's user license collection.
    /// </summary>
    public interface ICustomerUserLicenseCollection : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Retrieves the assigned licenses to a customer user.
        /// </summary>
        /// <param name="licenseGroupIds">The license group identifier.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The assigned licenses to a customer user.</returns>
        Task<ResourceCollection<License>> GetAsync(List<LicenseGroupId> licenseGroupIds = null, CancellationToken cancellationToken = default);
    }
}