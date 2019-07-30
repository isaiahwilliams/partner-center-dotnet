// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ServiceCosts
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Represents a service costs summary for a customer.
    /// </summary>
    public sealed class ServiceCostsSummary : ResourceBaseWithLinks<ServiceCostsSummaryLinks>
    {
        /// <summary>
        /// Gets or sets the total = pretax + tax for the customer.
        /// </summary>
        public decimal AfterTaxTotal { get; set; }

        /// <summary>
        /// Gets or sets the end of the billing period.
        /// </summary>
        public DateTime BillingEndDate { get; set; }

        /// <summary>
        /// Gets or sets the start of the billing period.
        /// </summary>
        public DateTime BillingStartDate { get; set; }

        /// <summary>
        /// Gets or sets the currency code for the costs.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol for the costs.
        /// </summary>
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the service costs summary details.
        /// </summary>
        public IEnumerable<ServiceCostsSummaryDetail> Details { get; set; }

        /// <summary>
        /// Gets or sets the pre tax total of costs of the customer.
        /// </summary>
        public decimal PretaxTotal { get; set; }

        /// <summary>
        /// Gets or sets the total tax for the customer.
        /// </summary>
        public decimal Tax { get; set; }
    }
}