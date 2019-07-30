// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using GenericOperations;
    using Models;
    using Models.Orders;
    using System;

    /// <summary>
    /// Represents the customer order line item activation link operations.
    /// </summary>
    public interface IOrderLineItemActivationLink : IPartnerComponent<Tuple<string, string, int>>, IEntityGetOperations<ResourceCollection<OrderLineItemActivationLink>>
    {
    }
}