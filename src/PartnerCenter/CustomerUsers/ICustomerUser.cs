// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerUsers
{
    using System;
    using GenericOperations;
    using Models.Users;

    /// <summary>
    /// Encapsulates a customer user behavior.
    /// </summary>
    public interface ICustomerUser : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<CustomerUser>, IEntityDeleteOperations<CustomerUser>, IEntityPatchOperations<CustomerUser>
    {
        /// <summary>
        /// Gets the current user's directory role collection operations.
        /// </summary>
        ICustomerUserRoleCollection DirectoryRoles { get; }

        /// <summary>
        /// Gets the current user's licenses collection operations.
        /// </summary>
        ICustomerUserLicenseCollection Licenses { get; }

        /// <summary>
        /// Gets the current user's license updates operations.
        /// </summary>
        ICustomerUserLicenseUpdates LicenseUpdates { get; }
    }
}