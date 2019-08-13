// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Offers;

    /// <summary>
    /// Represents the operations that can be performed on offers that belong to an offer category.
    /// </summary>
    public interface ICategoryOffersCollection : IPartnerComponent<Tuple<string, string>>, IEntityCollectionRetrievalOperations<Offer, ResourceCollection<Offer>>
    {
    }
}