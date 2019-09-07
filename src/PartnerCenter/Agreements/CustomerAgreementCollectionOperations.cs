// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models;
    using Models.Agreements;

    /// <summary>
    /// Customer's agreement collection operations implementations class.
    /// </summary>
    internal class CustomerAgreementCollectionOperations : BasePartnerComponent<string>, ICustomerAgreementCollection
    {
        /// <summary>
        /// The agreement type used to filter.
        /// </summary>
        private readonly string agreementType;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAgreementCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The identifier for the customer.</param>
        /// <param name="agreementType">The agreement type used to filter.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="rootPartnerOperations"/> is null.
        /// </exception>
        /// <exception>
        /// <paramref name="customerId"/> is empty or null.
        /// </exception>
        public CustomerAgreementCollectionOperations(IPartner rootPartnerOperations, string customerId, string agreementType = null)
          : base(rootPartnerOperations, customerId)
        {
            customerId.AssertNotEmpty(nameof(customerId));

            this.agreementType = agreementType;
        }

        /// <summary>
        /// Creates an agreement between the partner and customer.
        /// </summary>
        /// <param name="newEntity">The agreement to be created.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The newly created agreement.</returns>
        public async Task<Agreement> CreateAsync(Agreement newEntity, CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.PostAsync<Agreement, Agreement>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.CreateCustomerAgreement.Path}",
                        Context),
                    UriKind.Relative),
                newEntity,
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the list of agreements between a partner and customer.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The list of the customer's agreements.</returns>
        public async Task<ResourceCollection<Agreement>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = null;

            if (!string.IsNullOrEmpty(agreementType))
            {
                parameters = new Dictionary<string, string>
                {
                    {
                        PartnerService.Instance.Configuration.Apis.GetCustomerAgreements.Parameters.AgreementType,
                        agreementType
                    }
                };
            }

            return await Partner.ServiceClient.GetAsync<ResourceCollection<Agreement>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerAgreements.Path}",
                        Context),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}