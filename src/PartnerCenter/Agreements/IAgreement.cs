// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    /// <summary>
    /// Represents the available agreement operations.
    /// </summary>
    public interface IAgreement : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the available agreement template operations.
        /// </summary>
        IAgreementTemplate Templates { get; }
    }
}