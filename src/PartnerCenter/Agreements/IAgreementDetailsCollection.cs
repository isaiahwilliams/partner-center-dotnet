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
    /// Represents the agreement details behavior.
    /// </summary>
    public interface IAgreementDetailsCollection : IPartnerComponent<string>, IEntitySelector<string, IAgreement>
    {
        /// <summary>
        /// Gets the agreement details.
        /// </summary>
        /// <param name="agreementType">The agreement type used to filter.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>List of details about agreements.</returns>
        Task<ResourceCollection<AgreementMetaData>> GetAsync(string agreementType = null, CancellationToken cancellationToken = default);
    }
}