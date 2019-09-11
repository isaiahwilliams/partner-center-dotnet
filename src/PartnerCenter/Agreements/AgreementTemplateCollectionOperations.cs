// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    /// <summary>
    /// Agreement template collection operations implementation class.
    /// </summary>
    internal class AgreementTemplateCollectionOperations : BasePartnerComponent<string>, IAgreementTemplateCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementTemplateCollectionOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public AgreementTemplateCollectionOperations(IPartner rootPartnerOperations) :
            base(rootPartnerOperations)
        {
        }

        /// <inheritdoc/>
        public IAgreementTemplate this[string id] => ById(id);

        /// <inheritdoc/>
        public IAgreementTemplate ById(string id) => new AgreementTemplateOperations(Partner, id);
    }
}