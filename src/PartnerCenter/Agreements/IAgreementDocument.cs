// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using GenericOperations;
    using Models.Agreements;

    /// <summary>
    /// Represents operations on an agreement document.
    /// </summary>
    public interface IAgreementDocument : IPartnerComponent<AgreementDocumentContext>, IEntityGetOperations<AgreementDocument>
    {
        /// <summary>
        /// Customizes operations based on the given country.
        /// </summary>
        /// <param name="country">The ISO alpha-2 code of the country for which the agreement document is tailored.</param>
        /// <returns>An operations interface customized for the provided country.</returns>
        IAgreementDocument ByCountry(string country);

        /// <summary>
        /// Customizes operations based on the given language and locale.
        /// </summary>
        /// <param name="language">The language and locale to be used by the returned operations.</param>
        /// <returns>An operations interface customized for the provided language and locale.</returns>
        IAgreementDocument ByLanguage(string language);
    }
}