// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Roles
{
    using System;

    /// <summary>
    /// Implements the available role operations.
    /// </summary>
    internal class RoleOperations : BasePartnerComponent<string>, IRole
    {
        /// <summary>
        /// A lazy reference to the partner role members operations. 
        /// </summary>
        private readonly Lazy<IRoleMemberCollection> members;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="roleId">Identifier for the partner role.</param>
        public RoleOperations(IPartner rootPartnerOperations, string roleId)
            : base(rootPartnerOperations, roleId)
        {
            members = new Lazy<IRoleMemberCollection>(() => new RoleMemberCollectionOperations(rootPartnerOperations, roleId));
        }

        /// <summary>
        /// Gets the partner role member collection operations.
        /// </summary>
        public IRoleMemberCollection Members => members.Value;
    }
}