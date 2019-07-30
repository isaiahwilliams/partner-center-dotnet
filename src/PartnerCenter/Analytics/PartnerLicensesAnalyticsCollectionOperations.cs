// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    /// <summary>
    /// Implements the operations on partner licenses analytics collection.
    /// </summary>
    internal class PartnerLicensesAnalyticsCollectionOperations : BasePartnerComponent<string>, IPartnerLicensesAnalyticsCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnerLicensesAnalyticsCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public PartnerLicensesAnalyticsCollectionOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
            Deployment = new PartnerLicensesDeploymentInsightsCollectionOperations(rootPartnerOperations);
            Usage = new PartnerLicensesUsageInsightsCollectionOperations(rootPartnerOperations);
        }

        /// <summary>
        /// Gets the partner's licenses' deployment insights collection operations.
        /// </summary>
        public IPartnerLicensesDeploymentInsightsCollection Deployment { get; }

        /// <summary>
        /// Gets the partner's licenses' usage insights collection operations.
        /// </summary>
        public IPartnerLicensesUsageInsightsCollection Usage { get; }
    }
}