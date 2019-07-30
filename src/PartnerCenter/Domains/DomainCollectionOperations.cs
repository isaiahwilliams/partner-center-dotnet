// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Domains
{
    /// <summary>
    /// Domains collection operations implementation class.
    /// </summary>
    internal class DomainCollectionOperations : BasePartnerComponent<string>, IDomainCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public DomainCollectionOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Gets the specific domain behavior.
        /// </summary>
        /// <param name="domain">The domain.</param>
        /// <returns>The domain operations.</returns>
        public IDomain ByDomain(string domain)
        {
            return new DomainOperations(Partner, domain);
        }
    }
}