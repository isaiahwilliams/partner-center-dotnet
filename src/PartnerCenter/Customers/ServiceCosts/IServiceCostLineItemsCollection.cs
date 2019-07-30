// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.ServiceCosts
{
    using GenericOperations;
    using Models;
    using Models.ServiceCosts;
    using System;

    /// <summary>
    /// Represents the behavior of the customer service cost line items as a whole.
    /// </summary>
    public interface IServiceCostLineItemsCollection : IPartnerComponent<Tuple<string, ServiceCostsBillingPeriod>>, IEntireEntityCollectionRetrievalOperations<ServiceCostLineItem, ResourceCollection<ServiceCostLineItem>>
    {
    }
}