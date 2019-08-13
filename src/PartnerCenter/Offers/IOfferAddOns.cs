// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Offers;

    /// <summary>
    /// Represents the behavior of an offer's add-ons.
    /// </summary>
    public interface IOfferAddOns : IPartnerComponent<Tuple<string, string>>, IEntityCollectionRetrievalOperations<Offer, ResourceCollection<Offer>>
    {
    }
}