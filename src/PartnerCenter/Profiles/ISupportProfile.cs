// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Profiles
{
    using GenericOperations;
    using Models.Partners;

    /// <summary>
    /// Encapsulates behavior of a support profile.
    /// </summary>
    public interface ISupportProfile : IPartnerComponent<string>, IEntityGetOperations<SupportProfile>, IEntityUpdateOperations<SupportProfile, SupportProfile>
    {
    }
}