// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using GenericOperations;

    /// <summary>
    /// An implementation that scopes offers and categories into a specific country.
    /// </summary>
    internal class OfferCountrySelector : BasePartnerComponent<string>, ICountrySelector<IOfferCollection>, ICountrySelector<IOfferCategoryCollection>
    {
        /// Initializes a new instance of the <see cref="OfferCountrySelector" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public OfferCountrySelector(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        public IOfferCollection ByCountry(string country)
        {
            return new OfferCollectionOperations(Partner, country);
        }

        IOfferCategoryCollection ICountrySelector<IOfferCategoryCollection>.ByCountry(string country)
        {
            return new OfferCategoryCollectionOperations(Partner, country);
        }
    }
}