// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using Extensions;
    using Models;
    using Models.Invoices;
    using Models.JsonConverters;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the operations available on an estimate link collection by currency.
    /// </summary>
    internal class EstimateLinkCollectionByCurrencyOperations : BasePartnerComponent<string>, IEstimateLinkCollectionByCurrency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateLinkCollectionByCurrencyOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="currencyCode">The currency code.</param>
        public EstimateLinkCollectionByCurrencyOperations(IPartner rootPartnerOperations, string currencyCode)
            : base(rootPartnerOperations, currencyCode)
        {
            currencyCode.AssertNotEmpty(nameof(currencyCode));
        }

        /// <summary>
        /// Retrieves the estimate link resource collection.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The estimate link resource collection.</returns>
        public async Task<ResourceCollection<EstimateLink>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<EstimateLink>>(
               new Uri(
                   string.Format(
                       CultureInfo.InvariantCulture,
                       $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetEstimatesLinks.Path}",
                       Context),
                   UriKind.Relative),
                new ResourceCollectionConverter<EstimateLink>(),
               cancellationToken).ConfigureAwait(false);
        }
    }
}