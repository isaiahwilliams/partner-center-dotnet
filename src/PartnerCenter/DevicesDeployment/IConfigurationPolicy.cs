// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.DevicesDeployment
{
    using System;
    using GenericOperations;
    using Models.DevicesDeployment;

    /// <summary>
    /// Represents all the operations that can be done on a configuration policy.
    /// </summary>
    public interface IConfigurationPolicy : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<ConfigurationPolicy>, IEntityPatchOperations<ConfigurationPolicy>, IEntityDeleteOperations<ConfigurationPolicy>
    {
    }
}