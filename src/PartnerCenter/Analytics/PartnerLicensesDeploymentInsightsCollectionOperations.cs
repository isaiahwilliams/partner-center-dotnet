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
    /// Implements the operations on partner licenses deployment insights collection.
    /// </summary>
    internal class PartnerLicensesDeploymentInsightsCollectionOperations : BasePartnerComponent<string>, IPartnerLicensesDeploymentInsightsCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerLicensesDeploymentInsightsCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public PartnerLicensesDeploymentInsightsCollectionOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Retrieves the collection of partner's licenses' deployment insights.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Collection of licenses deployment insights</returns>
        public async Task<ResourceCollection<PartnerLicensesDeploymentInsights>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<PartnerLicensesDeploymentInsights>>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.PartnerLicensesDeploymentInsights.Path}",
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }
    }
}