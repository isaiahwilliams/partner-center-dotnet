// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Analytics
{
    /// <summary>
    /// Model for Insights of license usage at customer level.
    /// </summary>
    public sealed class CustomerLicensesUsageInsights : CustomerLicensesInsightsBase
    {
        /// <summary>
        /// Gets or sets the total active seats as of processed time stamp.
        /// </summary>
        public long LicensesActive { get; set; }

        /// <summary>
        /// Gets or sets the total qualified entitlements as of processed time stamp.
        /// </summary>
        public long LicensesQualified { get; set; }

        /// <summary>
        /// Gets or sets the usage percent of the given workload.
        /// </summary>
        public double UsagePercent { get; set; }

        /// <summary>
        /// Gets or sets the Workload Code. (Example : Exchange - EXO).
        /// </summary>
        public string WorkloadCode { get; set; }

        /// <summary>Gets or sets the Workload name (Example: Exchange).</summary>
        public string WorkloadName { get; set; }
    }
}