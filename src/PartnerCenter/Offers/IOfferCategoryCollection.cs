// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using GenericOperations;
    using Models;
    using Models.Offers;

    /// <summary>
    /// Represents the behavior of offer categories available to partners.
    /// </summary>
    public interface IOfferCategoryCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<OfferCategory, ResourceCollection<OfferCategory>>
    {
    }
}