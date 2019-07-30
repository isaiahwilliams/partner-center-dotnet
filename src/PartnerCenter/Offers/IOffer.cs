// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using GenericOperations;
    using Models.Offers;
    using System;

    /// <summary>
    /// Represents operations that can be performed on a single offer.
    /// </summary>
    public interface IOffer : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<Offer>
    {
        /// <summary>
        /// Gets the operations for the current offer's add-ons.
        /// </summary>
        IOfferAddOns AddOns { get; }
    }
}