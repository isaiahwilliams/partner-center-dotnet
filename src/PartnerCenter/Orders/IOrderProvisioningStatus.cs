// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Orders
{
    using GenericOperations;
    using Models;
    using Models.Orders;
    using System;

    /// <summary>
    /// Holds operations that apply Order provisioning status.
    /// </summary>
    public interface IOrderProvisioningStatus : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<OrderLineItemProvisioningStatus, ResourceCollection<OrderLineItemProvisioningStatus>>
    {
    }
}
