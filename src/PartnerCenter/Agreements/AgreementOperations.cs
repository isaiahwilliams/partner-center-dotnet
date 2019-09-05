// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    /// <summary>
    /// Implements the available agreement operations.
    /// </summary>
    internal sealed class AgreementOperations : BasePartnerComponent<string>, IAgreement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="agreementId">Identifier for the agreement.</param>
        public AgreementOperations(IPartner rootPartnerOperations, string agreementId)
          : base(rootPartnerOperations, agreementId)
        {
        }

        /// <summary>
        /// Gets the available agreement template operations.
        /// </summary>
        public IAgreementTemplate Templates => new AgreementTemplateOperations(Partner, Context);
    }
}