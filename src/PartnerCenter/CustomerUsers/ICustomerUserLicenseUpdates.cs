// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.CustomerUsers
{
    using GenericOperations;
    using Models.Licenses;
    using System;

    /// <summary>
    /// Represents the behavior of a customer user's license update collection.
    /// </summary>
    public interface ICustomerUserLicenseUpdates : IPartnerComponent<Tuple<string, string>>, IEntityCreateOperations<LicenseUpdate, LicenseUpdate>
    {
    }
}