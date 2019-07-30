// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Profiles
{
    using GenericOperations;
    using Models.Partners;

    /// <summary>
    /// Encapsulates the behavior of an organization profile.
    /// </summary>
    public interface IOrganizationProfile : IPartnerComponent<string>, IEntityGetOperations<OrganizationProfile>, IEntityUpdateOperations<OrganizationProfile, OrganizationProfile>
    {
    }
}