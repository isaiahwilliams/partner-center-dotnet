// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using System;
    using GenericOperations;
    using Models.Usage;

    /// <summary>
    /// This interface defines the operations available on a customer's subscription usage summary.
    /// </summary>
    public interface ISubscriptionUsageSummary : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<SubscriptionUsageSummary>
    {
    }
}