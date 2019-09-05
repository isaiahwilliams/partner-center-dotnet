// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using System.Threading;
    using System.Threading.Tasks;
    using GenericOperations;
    using Models;
    using Models.Agreements;

    /// <summary>
    /// Defines the operations available on a partner-customer agreement.
    /// </summary>
    public interface ICustomerAgreementCollection : IPartnerComponent<string>, IEntityCreateOperations<Agreement, Agreement>
    {
        /// <summary>
        /// Gets the list of agreements between a partner and customer.
        /// </summary>
        /// <param name="agreementType">The agreement type used to filter.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The list of the customer's agreements.</returns>
        Task<ResourceCollection<Agreement>> GetAsync(string agreementType = null, CancellationToken cancellationToken = default);
    }
}