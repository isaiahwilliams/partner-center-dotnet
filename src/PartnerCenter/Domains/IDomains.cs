// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Domains
{
    using GenericOperations;

    /// <summary>
    /// Represents the behavior of a domain.
    /// </summary>
    public interface IDomain : IPartnerComponent<string>, IEntityExistsOperations
    {
    }
}
