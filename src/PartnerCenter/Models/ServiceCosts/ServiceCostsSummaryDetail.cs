// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ServiceCosts
{

    /// <summary>
    /// Represent a service cost summary of individual details for an invoice type.
    /// </summary>
    public class ServiceCostsSummaryDetail
    {
        /// <summary>
        /// Gets or sets the invoice type.
        /// </summary>
        public string InvoiceType { get; set; }

        /// <summary>
        /// Gets or sets the service cost summary.
        /// </summary>
        public ServiceCostsSummary Summary { get; set; }
    }
}