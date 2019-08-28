// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Models.Agreements;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Implements the available agreement template operations.
    /// </summary>
    internal class AgreementTemplateOperations : BasePartnerComponent<string>, IAgreementTemplate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementTemplateOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="templateId">Identifier for the agreement.</param>
        public AgreementTemplateOperations(IPartner rootPartnerOperations, string templateId)
            : base(rootPartnerOperations, templateId)
        { }

        /// <summary>
        /// Gets the specified agreement template document.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<AgreementTemplate> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<AgreementTemplate>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetAgreementTemplate.Path}",
                        Context),
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the specified agreement template document.
        /// </summary>
        /// <param name="country">The country where the agreement template applies.</param>
        /// <param name="language">The localized langage for the agreement template.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        public async Task<AgreementTemplate> GetAsync(string country, string language, CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters;

            parameters = new Dictionary<string, string>
            {
                {
                    PartnerService.Instance.Configuration.Apis.GetAgreementTemplate.Parameters.Country,
                    country
                },
                {
                    PartnerService.Instance.Configuration.Apis.GetAgreementTemplate.Parameters.Language,
                    language
                }
            };

            return await Partner.ServiceClient.GetAsync<AgreementTemplate>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetAgreementTemplate.Path}",
                        Context),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}