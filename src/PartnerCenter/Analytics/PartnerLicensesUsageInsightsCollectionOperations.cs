// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    using Models;
    using Models.Analytics;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Implements the operations on partner licenses usage insights collection.
    /// </summary>
    internal class PartnerLicensesUsageInsightsCollectionOperations : BasePartnerComponent<string>, IPartnerLicensesUsageInsightsCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerLicensesUsageInsightsCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public PartnerLicensesUsageInsightsCollectionOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Retrieves the collection of partner's licenses' usage insights.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Collection of licenses usage insights</returns>
        public async Task<ResourceCollection<PartnerLicensesUsageInsights>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<PartnerLicensesUsageInsights>>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.PartnerLicensesUsageInsights.Path}",
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }
    }
}