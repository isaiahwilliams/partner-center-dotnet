// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using Models.Agreements;

    /// <summary>
    /// Represents operations on an agreement template.
    /// </summary>
    public interface IAgreementTemplate : IPartnerComponent<AgreementTemplateContext>
    {
        /// <summary>
        /// Retrieves the agreement document.
        /// </summary>
        /// <returns>The agreement document.</returns>
        IAgreementDocument Document { get; }
    }
}