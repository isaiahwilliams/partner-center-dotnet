// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.DevicesDeployment
{
    using GenericOperations;
    using Models;
    using Models.DevicesDeployment;

    /// <summary>
    /// Represents the operations that can be done on the partner's configuration policies.
    /// </summary>
    public interface IConfigurationPolicyCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<ConfigurationPolicy, ResourceCollection<ConfigurationPolicy>>, IEntityCreateOperations<ConfigurationPolicy, ConfigurationPolicy>, IEntitySelector<string, IConfigurationPolicy>
    {
    }
}