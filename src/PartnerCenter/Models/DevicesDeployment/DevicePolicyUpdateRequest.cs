// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.DevicesDeployment
{
    using System.Collections.Generic;

    /// <summary>
    /// Represents the list of devices to be updated with a policy.
    /// </summary>
    public sealed class DevicePolicyUpdateRequest : ResourceBase
    {
        /// <summary>
        /// Gets or sets the list of devices to be updated.
        /// </summary>
        public IEnumerable<Device> Devices { get; set; }
    }
}