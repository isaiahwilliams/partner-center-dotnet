// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.RelationshipRequests
{
    using Models.RelationshipRequests;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Customer relationship request implementation class.
    /// </summary>
    internal class CustomerRelationshipRequestOperations : BasePartnerComponent<string>, ICustomerRelationshipRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRelationshipRequestOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public CustomerRelationshipRequestOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Retrieves the customer relationship request which can be used by a customer to establish a relationship with the current partner.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>A customer relationship request.</returns>
        public async Task<CustomerRelationshipRequest> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<CustomerRelationshipRequest>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerRelationshipRequest.Path}",
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }
    }
}