// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Extensions;
    using Models;
    using Models.JsonConverters;
    using Models.Query;
    using Models.Roles;

    /// <summary>
    /// Implements the available role operations.
    /// </summary>
    internal class RoleCollectionOperations : BasePartnerComponent<string>, IRoleCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        public RoleCollectionOperations(IPartner rootPartnerOperations)
          : base(rootPartnerOperations)
        {
        }

        /// <summary>
        /// Gets all roles that belong to the partner.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>All roles that belong to the partner.</returns>
        public async Task<SeekBasedResourceCollection<Role>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<SeekBasedResourceCollection<Role>>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Path}",
                    UriKind.Relative),
                new ResourceCollectionConverter<Role>(),
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Queries for the list of partner roles.
        /// - Count queries are not supported by this operation.
        /// - You can set page size and sort option.
        /// - You can navigate to other pages by specifying a seek query with the seek operation and the continuation
        ///   token sent by the previous operation.
        /// </summary>
        /// <param name="query">A query to apply onto customer users. Check <see cref="QueryFactory" /> to see how
        /// to build queries.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The roles that match the specified criteria.</returns>
        public async Task<SeekBasedResourceCollection<Role>> QueryAsync(IQuery query, CancellationToken cancellationToken = default)
        {
            IDictionary<string, string> headers = null;
            IDictionary<string, string> parameters;

            query.AssertNotNull(nameof(query));

            if (query.Type == QueryType.Seek)
            {
                query.Token.AssertNotNull(nameof(query.Token));

                headers = new Dictionary<string, string>
                {
                    {
                        PartnerService.Instance.Configuration.Apis.GetPartnerRoles.AdditionalHeaders.ContinuationToken,
                        query.Token.ToString()
                    }
                };

                parameters = new Dictionary<string, string>
                {
                    {
                        PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Parameters.SeekOperation,
                        query.SeekOperation.ToString()
                    }
                };
            }
            else
            {
                parameters = new Dictionary<string, string>();

                if (query.Type == QueryType.Indexed)
                {
                    query.PageSize = Math.Max(query.PageSize, 0);

                    parameters.Add(
                        PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Parameters.Size,
                        query.PageSize.ToString(CultureInfo.InvariantCulture));
                }
                else
                {
                    parameters.Add(
                        PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Parameters.Size,
                        "0");
                }

                if (query.Sort != null)
                {
                    parameters.Add(
                        PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Parameters.SortDirection,
                        query.Sort.SortDirection.ToString());

                    parameters.Add(
                       PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Parameters.SortField,
                       query.Sort.SortField.ToString(CultureInfo.InvariantCulture));
                }
            }

            return await Partner.ServiceClient.GetAsync<SeekBasedResourceCollection<Role>>(
                new Uri(
                    $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetPartnerRoles.Path}",
                    UriKind.Relative),
                headers,
                parameters,
                new ResourceCollectionConverter<Role>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}
