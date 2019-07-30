// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.DevicesDeployment
{
    using GenericOperations;
    using Models.DevicesDeployment;
    using System;

    /// <summary>
    /// Represents the operations that can be done on the partner's Batch Upload Status.
    /// </summary>
    public interface IBatchJobStatus : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<BatchUploadDetails>
    {
    }
}