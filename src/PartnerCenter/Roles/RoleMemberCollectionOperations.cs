// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;
    using Models;
    using Models.JsonConverters;
    using Models.Roles;

    /// <summary>
    /// Implements the available role member collection operations.
    /// </summary>
    internal class RoleMemberCollectionOperations : BasePartnerComponent<string>, IRoleMemberCollection
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleMemberCollectionOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="roleId">Identifier for the partner role.</param>
        public RoleMemberCollectionOperations(IPartner rootPartnerOperations, string roleId)
          : base(rootPartnerOperations, roleId)
        {
        }

        /// <summary>
        /// Gets all the members of a partner role.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The directory role user memberships.</returns>
        public async Task<SeekBasedResourceCollection<UserMember>> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<SeekBasedResourceCollection<UserMember>>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetPartnerRoleMembers.Path}",
                        Context),
                    UriKind.Relative),
                new ResourceCollectionConverter<UserMember>(),
                cancellationToken).ConfigureAwait(false);
        }
    }
}