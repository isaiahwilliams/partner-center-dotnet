// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using System.Threading;
    using System.Threading.Tasks;
    using GenericOperations;
    using Models.Agreements;

    /// <summary>
    /// Represents the available agreement template operations.
    /// </summary>
    public interface IAgreementTemplate : IPartnerComponent<string>, IEntityGetOperations<AgreementTemplate>
    {
        /// <summary>
        /// Gets the specified agreement template document.
        /// </summary>
        /// <param name="country">The country where the agreement template applies.</param>
        /// <param name="language">The localized langage for the agreement template.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        Task<AgreementTemplate> GetAsync(string country, string language, CancellationToken cancellationToken = default);
    }
}