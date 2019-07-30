// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using Models;
    using Models.Invoices;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the operations that can be done on invoice summary collection.
    /// </summary>
    internal class InvoiceSummaryCollectionOperations : BasePartnerComponent<string>, IInvoiceSummaryCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummaryCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public InvoiceSummaryCollectionOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Retrieves invoice summary collection of the partner's billing information.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The invoice summary collection.</returns>
        public async Task<ResourceCollection<InvoiceSummary>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<ResourceCollection<InvoiceSummary>>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetInvoiceSummaries.Path}",
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }
    }
}