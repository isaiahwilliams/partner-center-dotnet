// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.DevicesDeployment
{
    /// <summary>
    /// Represents the status of batch upload of devices.
    /// </summary>
    public class DeviceUploadDetails : ResourceBase
    {
        /// <summary>
        /// Gets or sets the device identifier.
        /// </summary>
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the error code upon device upload failure.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the error description upon device upload failure.
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or sets the product key.
        /// </summary>
        public string ProductKey { get; set; }

        /// <summary>
        /// Gets or sets the serial number.
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets the device upload status.
        /// </summary>
        public DeviceUploadStatusType Status { get; set; }
    }
}