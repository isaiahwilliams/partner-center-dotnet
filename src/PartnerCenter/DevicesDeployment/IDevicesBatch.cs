// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.DevicesDeployment
{
    using System;

    /// <summary>
    /// Represents the operations that can be done on the partner's devices batches.
    /// </summary>
    public interface IDevicesBatch : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Gets the devices behavior of the devices batch.
        /// </summary>
        IDeviceCollection Devices { get; }
    }
}