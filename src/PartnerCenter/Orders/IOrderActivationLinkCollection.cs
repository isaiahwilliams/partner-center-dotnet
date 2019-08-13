// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Orders;

    /// <summary>
    /// Encapsulates customer order activation link behavior.
    /// </summary>
    public interface IOrderActivationLinkCollection : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<OrderLineItemActivationLink, ResourceCollection<OrderLineItemActivationLink>>
    {
    }
}