// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Offers
{
    using Models;
    using Models.Offers;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Customer Offer Category operations implementation class.
    /// </summary>
    internal class CustomerOfferCategoryCollectionOperations : BasePartnerComponent<string>, ICustomerOfferCategoryCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerOfferCategoryCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        public CustomerOfferCategoryCollectionOperations(IPartner rootPartnerOperations, string customerId)
          : base(rootPartnerOperations, customerId)
        {
        }

        /// <summary>
        /// Gets the offer categories available to customer from partner.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>Offer categories available to customer from partner.</returns>
        public async Task<ResourceCollection<OfferCategory>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<OfferCategory>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerOfferCategories.Path}",
                        Context),
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }
    }
}
