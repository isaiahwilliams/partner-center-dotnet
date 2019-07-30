// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.ServiceCosts
{
    using GenericOperations;
    using Models.ServiceCosts;
    using System;

    /// <summary>
    /// This interface defines the operations available on a customer's service cost summary.
    /// </summary>
    public interface IServiceCostSummary : IPartnerComponent<Tuple<string, ServiceCostsBillingPeriod>>, IEntityGetOperations<ServiceCostsSummary>
    {
    }
}
