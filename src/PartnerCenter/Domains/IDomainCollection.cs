// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Domains
{
    /// <summary>
    /// Encapsulates domains behavior.
    /// </summary>
    public interface IDomainCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the specific domain behavior.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <returns>The domain operations.</returns>
        IDomain ByDomain(string domain);
    }
}