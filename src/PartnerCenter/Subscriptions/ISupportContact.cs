// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using System;
    using GenericOperations;
    using Models.Subscriptions;

    /// <summary>
    /// Defines the operations available on a customer's subscription support contact.
    /// </summary>
    public interface ISubscriptionSupportContact : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<SupportContact>, IEntityUpdateOperations<SupportContact, SupportContact>
    {
    }
}