// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Incidents
{
    using GenericOperations;
    using Models;
    using Models.Incidents;
    using Models.Query;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the operations available on service incidents.
    /// </summary>
    public interface IServiceIncidentCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<ServiceIncidents, ResourceCollection<ServiceIncidents>>
    {
        /// <summary>
        /// Queries service incidents.
        /// </summary>
        /// <param name="query">A query to retrieve service incidents based on the active status.
        /// The <see cref="QueryFactory" /> can be used to build queries.
        /// Service incident queries support simple queries. You can filter service incidents using their active status.
        /// <see cref="ServiceIncidentSearchField" /> lists
        /// the supported search fields. You can use the <see cref="FieldFilterOperation" /> enumeration to specify filtering operations.
        /// Supported filtering operations are: equals.
        /// </param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The list of service incidents that match the query.</returns>
        Task<ResourceCollection<ServiceIncidents>> QueryAsync(IQuery query, CancellationToken cancellationToken = default);
    }
}