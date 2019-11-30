// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Compliance
{
    /// <summary>
    /// Represents the compliance status of a partner.
    /// </summary>
    public interface IComplianceCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the operations available for agreement signature status.
        /// </summary>
        IAgreementSignatureStatus AgreementSignatureStatus { get; }
    }
}