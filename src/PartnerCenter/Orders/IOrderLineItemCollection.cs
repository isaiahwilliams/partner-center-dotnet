// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using System;
    using GenericOperations;

    /// <summary>
    /// Represents the available order line item operations.
    /// </summary>
    public interface IOrderLineItemCollection : IPartnerComponent<Tuple<string, string>>, IEntitySelector<int, IOrderLineItem>
    {
    }
}