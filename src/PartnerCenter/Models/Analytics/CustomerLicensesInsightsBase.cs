// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Analytics
{
    /// <summary>
    /// Model for common properties of customer licenses analytics.
    /// </summary>
    public abstract class CustomerLicensesInsightsBase : LicensesInsightsBase
    {
        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the product/plan name of the given service. (Example: OFFICE 365 BUSINESS ESSENTIALS).
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or sets the Service Code of the License. Example (Office 365 : O365).
        /// </summary>
        public string ServiceCode { get; set; }
    }
}