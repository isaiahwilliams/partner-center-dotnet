// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    /// <summary>
    /// Encapsulates collection of customer level analytics.
    /// </summary>
    public interface ICustomerLicensesAnalyticsCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Encapsulates customer level licenses deployment analytics.
        /// </summary>
        ICustomerLicensesDeploymentInsightsCollection Deployment { get; }

        /// <summary>
        /// Encapsulates customer level licenses usage analytics.
        /// </summary>
        ICustomerLicensesUsageInsightsCollection Usage { get; }
    }
}