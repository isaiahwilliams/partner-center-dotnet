// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Compliance
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Models.Compliance;

    /// <summary>
    /// Class which contains operations for Agreement signature status.
    /// </summary>
    internal class AgreementSignatureStatusOperations : BasePartnerComponent<string>, IAgreementSignatureStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementSignatureStatusOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public AgreementSignatureStatusOperations(IPartner rootPartnerOperations)
            : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Gets the agreement signature status by MPN identifer or tenant identifer.
        /// </summary>
        /// <param name="mpnId">The identifier for the Microsoft Partner Network (MPN).</param>
        /// <param name="tenantId">The identifier for the tenant.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The status for the agreement signature.</returns>
        public async Task<AgreementSignatureStatus> GetAsync(string mpnId = null, string tenantId = null, CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();

            if (!string.IsNullOrEmpty(mpnId))
            {
                parameters.Add(
                    PartnerService.Instance.Configuration.Apis.GetAgreementSignatureStatus.Parameters.MpnId,
                    mpnId);
            }

            if (!string.IsNullOrEmpty(tenantId))
            {
                parameters.Add(
                    PartnerService.Instance.Configuration.Apis.GetAgreementSignatureStatus.Parameters.TenantId,
                    tenantId);
            }

            return await Partner.ServiceClient.GetAsync<AgreementSignatureStatus>(
                new Uri
                    ($"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetAgreementSignatureStatus.Path}",
                    UriKind.Relative),
                parameters,
                cancellationToken).ConfigureAwait(false);
        }
    }
}