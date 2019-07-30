// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ApplicationConsents
{
    using GenericOperations;
    using Models.ApplicationConsents;

    public interface IApplicationConsentCollection : IPartnerComponent<string>, IEntityCreateOperations<ApplicationConsent, ApplicationConsent>
    {
    }
}