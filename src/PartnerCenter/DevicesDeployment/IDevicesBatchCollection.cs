// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.DevicesDeployment
{
    using GenericOperations;
    using Models;
    using Models.DevicesDeployment;

    /// <summary>
    /// Represents the operations that can be done on the partner's devices batches.
    /// </summary>
    public interface IDevicesBatchCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<DeviceBatch, ResourceCollection<DeviceBatch>>, IEntitySelector<string, IDevicesBatch>, IEntityCreateOperations<DeviceBatchCreationRequest, string>
    {
    }
}