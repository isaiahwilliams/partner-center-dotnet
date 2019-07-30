// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Domains
{
    using Exceptions;
    using Extensions;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// The domain operations implementation class.
    /// </summary>
    internal class DomainOperations : BasePartnerComponent<string>, IDomain
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="domain">The domain.</param>
        public DomainOperations(IPartner rootPartnerOperations, string domain)
          : base(rootPartnerOperations, domain)
        {
            domain.AssertNotEmpty(nameof(domain));
        }

        /// <summary>
        /// Checks the availability of a domain.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns><c>true</c> if the domain is available; otherwise <c>false</c>.</returns>
        public async Task<bool> ExistsAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await Partner.ServiceClient.HeadAsync<string>(
                    new Uri(
                        string.Format(
                            CultureInfo.InvariantCulture,
                            $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.CheckDomainAvailability.Path}",
                            Context),
                        UriKind.Relative),
                    cancellationToken).ConfigureAwait(false);
            }
            catch (PartnerException ex)
            {
                if (ex.ErrorCategory == PartnerErrorCategory.NotFound)
                {
                    return false;
                }

                throw;
            }

            return true;
        }
    }
}