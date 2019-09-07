// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Models;
    using Models.Agreements;

    /// <summary>
    /// Agreement details collection operations implementation class.
    /// </summary>
    internal class AgreementDetailsCollectionOperations : BasePartnerComponent<string>, IAgreementDetailsCollection
    {
        /// <summary>
        /// The agreement type used to filter.
        /// </summary>
        private readonly string agreementType;

        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementDetailsCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="agreementType">The agreement type used to filter.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="rootPartnerOperations"/> is null.
        /// </exception>
        public AgreementDetailsCollectionOperations(IPartner rootPartnerOperations, string agreementType = null)
          : base(rootPartnerOperations)
        {
            this.agreementType = agreementType;
        }

        /// <summary>
        /// Gets the available agreement template operations.
        /// </summary>
        /// <param name="id">Identifier for the agreement.</param>
        public IAgreement this[string id] => ById(id);

        /// <summary>
        /// Scopes agreements behavior to a specific agreement type.
        /// </summary>
        /// <param name="agreementType">The agreement type used to scope.</param>
        /// <returns>The agreement collection operations customized for the given agreement type.</returns>
        public IAgreementDetailsCollection ByAgreementType(string agreementType)
        {
            return new AgreementDetailsCollectionOperations(Partner, agreementType);
        }

        /// <summary>
        /// Gets the available agreement template operations.
        /// </summary>
        /// <param name="id">Identifier for the agreement.</param>
        /// <returns>The available agreement template operations.</returns>
        public IAgreement ById(string id)
        {
            return new AgreementOperations(Partner, id);
        }

        /// <summary>
        /// Gets the agreement details.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>List of details about agreements.</returns>
        public async Task<ResourceCollection<AgreementMetaData>> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = null;

            if (!string.IsNullOrEmpty(agreementType))
            {
                parameters = new Dictionary<string, string>
                {
                    {
                        PartnerService.Instance.Configuration.Apis.GetAgreementsDetails.Parameters.AgreementType,
                        agreementType
                    }
                };
            }

            return await Partner.ServiceClient.GetAsync<ResourceCollection<AgreementMetaData>>(
                new Uri(
                     $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetAgreementsDetails.Path}",
                     UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}