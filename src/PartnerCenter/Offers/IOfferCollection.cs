// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using GenericOperations;
    using Models;
    using Models.Offers;

    /// <summary>
    /// Represents the operations that can be performed on offers.
    /// </summary>
    public interface IOfferCollection : IPartnerComponent<string>, IEntityCollectionRetrievalOperations<Offer, ResourceCollection<Offer>>, IEntitySelector<string, IOffer>
    {
        /// <summary>
        /// Retrieves the operations that can be applied on offers that belong to an offer category.
        /// </summary>
        /// <param name="categoryId">The offer category identifier.</param>
        /// <returns>The category offers operations.</returns>
        ICategoryOffersCollection ByCategory(string categoryId);
    }
}