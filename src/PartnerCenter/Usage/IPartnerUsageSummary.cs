// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using GenericOperations;
    using Models.Usage;

    /// <summary>
    /// Defines the operations available on a partner's usage summary.
    /// </summary>
    public interface IPartnerUsageSummary : IPartnerComponent<string>, IEntityGetOperations<PartnerUsageSummary>
    {
    }
}