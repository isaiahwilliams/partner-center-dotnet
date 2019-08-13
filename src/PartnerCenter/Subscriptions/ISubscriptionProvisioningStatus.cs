// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using System;
    using GenericOperations;
    using Models.Subscriptions;

    /// <summary>
    /// The subscription provisioning status.
    /// </summary>
    public interface ISubscriptionProvisioningStatus : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<SubscriptionProvisioningStatus>
    {
    }
}