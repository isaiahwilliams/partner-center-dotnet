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
    using Models.Agreements;

    /// <summary>
    /// Implements the operations on an agreement document.
    /// </summary>
    internal class AgreementDocumentOperations : BasePartnerComponent<AgreementDocumentContext>, IAgreementDocument
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementDocumentOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="templateId">The template identifier.</param>
        /// <param name="language">The language for the document.</param>
        /// <param name="country">The country for the document.</param>
        public AgreementDocumentOperations(IPartner rootPartnerOperations, string templateId, string language = null, string country = null) :
            base(rootPartnerOperations, new AgreementDocumentContext { TemplateId = templateId })
        {
            templateId.AssertNotEmpty(nameof(templateId));

            if (!string.IsNullOrWhiteSpace(country) || !string.IsNullOrWhiteSpace(language))
            {
                Context.TransformOptions = new AgreementDocumentTransformOptions
                {
                    Country = country,
                    Language = language
                };
            }
        }

        /// <inheritdoc/>
        public IAgreementDocument ByCountry(string country)
        {
            country.AssertNotEmpty(nameof(country));

            return new AgreementDocumentOperations(Partner, Context.TemplateId, Context.TransformOptions?.Language, country);
        }

        /// <inheritdoc/>
        public IAgreementDocument ByLanguage(string language)
        {
            language.AssertNotEmpty(nameof(language));

            return new AgreementDocumentOperations(Partner, Context.TemplateId, language, Context.TransformOptions?.Country);
        }


        /// <summary>
        /// Gets the agreement document.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The agreement document.</returns>
        public async Task<AgreementDocument> GetAsync(CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();


            if (!string.IsNullOrEmpty(Context.TransformOptions?.Country))
            {
                parameters.Add(PartnerService.Instance.Configuration.Apis.GetAgreementDocument.Parameters.Country, Context.TransformOptions.Country);
            }

            if (!string.IsNullOrEmpty(Context.TransformOptions?.Language))
            {
                parameters.Add(PartnerService.Instance.Configuration.Apis.GetAgreementDocument.Parameters.CouLanguagentry, Context.TransformOptions.Language);
            }

            return await Partner.ServiceClient.GetAsync<AgreementDocument>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetAgreementDocument.Path}",
                        Context),
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}