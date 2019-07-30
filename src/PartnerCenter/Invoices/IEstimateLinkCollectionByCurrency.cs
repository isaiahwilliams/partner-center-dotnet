// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using GenericOperations;
    using Models;
    using Models.Invoices;

    /// <summary>
    /// Holds operations that can be performed on estimate link collection that belong to a given currency.
    /// </summary>
    public interface IEstimateLinkCollectionByCurrency : IPartnerComponent<string>, IEntityGetOperations<ResourceCollection<EstimateLink>>
    {
    }
}
