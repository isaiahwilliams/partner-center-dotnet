// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Compliance
{
    using System.Threading;
    using System.Threading.Tasks;
    using Models.Compliance;

    /// <summary>
    /// Represents the agreement signature status for partner operations.
    /// </summary>
    public interface IAgreementSignatureStatus : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the agreement signature status by MPN identifer or tenant identifer.
        /// </summary>
        /// <param name="mpnId">The identifier for the Microsoft Partner Network (MPN).</param>
        /// <param name="tenantId">The identifier for the tenant.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The status for the agreement signature.</returns>
        Task<AgreementSignatureStatus> GetAsync(string mpnId = null, string tenantId = null, CancellationToken cancellationToken = default);
    }
}