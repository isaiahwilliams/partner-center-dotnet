// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using GenericOperations;
    using Models;
    using Models.Offers;

    /// <summary>
    /// Represents operations that can be performed on Offers available for the Customer.
    /// </summary>
    public interface ICustomerOfferCollection : IPartnerComponent<string>, IEntityCollectionRetrievalOperations<Offer, ResourceCollection<Offer>>
    {
    }
}