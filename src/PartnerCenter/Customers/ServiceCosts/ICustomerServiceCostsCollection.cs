// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.ServiceCosts
{
    using Models.ServiceCosts;

    /// <summary>
    /// Holds customer service costs behavior.
    /// </summary>
    public interface ICustomerServiceCostsCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Obtains the service cost operations by billing period.
        /// </summary>
        /// <param name="billingPeriod">The billing period.</param>
        /// <returns>The service cost operations.</returns>
        IServiceCostsCollection ByBillingPeriod(ServiceCostsBillingPeriod billingPeriod);
    }
}
