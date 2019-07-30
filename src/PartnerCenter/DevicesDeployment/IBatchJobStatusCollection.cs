// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.DevicesDeployment
{
    using GenericOperations;

    /// <summary>
    /// Represents the operations that can be done on the partner's batch upload status collection.
    /// </summary>
    public interface IBatchJobStatusCollection : IPartnerComponent<string>, IEntitySelector<string, IBatchJobStatus>
    {
    }
}