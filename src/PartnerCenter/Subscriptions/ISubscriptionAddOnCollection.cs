// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Subscriptions;

    /// <summary>
    /// Defines the behavior for a subscription's add-ons.
    /// </summary>
    public interface ISubscriptionAddOnCollection : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<Subscription, ResourceCollection<Subscription>>
    {
    }
}