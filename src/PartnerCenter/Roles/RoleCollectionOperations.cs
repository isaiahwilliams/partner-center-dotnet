// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Models;
    using Models.JsonConverters;
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
        /// Gets a partner role operations object.
        /// </summary>
        /// <param name="id">The partner role identifier.</param>
        /// <returns>The partner role operations object.</returns>
        public IRole this[string id] => ById(id);

        /// <summary>
        /// Gets a partner role operations object.
        /// </summary>
        /// <param name="id">The partner role identifier.</param>
        /// <returns>The partner role operations object.</returns>
        public IRole ById(string id)
        {
            return new RoleOperations(Partner, id);
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
    }
}
