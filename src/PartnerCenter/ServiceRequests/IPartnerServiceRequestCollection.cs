// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ServiceRequests
{
    using Models.ServiceRequests;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents the behavior of partner service requests.
    /// </summary>
    public interface IPartnerServiceRequestCollection : IServiceRequestCollection
    {
        /// <summary>
        /// Gets a set of operations that can be performed on Support Topics.
        /// </summary>
        /// <returns>Support topic operations.</returns>
        ISupportTopicsCollection SupportTopics { get; }

        /// <summary>
        /// Creates a new service request.
        /// </summary>
        /// <param name="serviceRequest">The new service request information.</param>
        /// <param name="agentLocale">The agent locale.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The service request information that was just created.</returns>
        Task<ServiceRequest> CreateAsync(ServiceRequest serviceRequest, string agentLocale, CancellationToken cancellationToken = default);
    }
}
