// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.DevicesDeployment
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Devices Batch upload status.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum DeviceUploadStatusType
    {
        /// <summary>
        /// Should never happen.
        /// </summary>
        Unknown,

        /// <summary>
        /// Batch is queued.
        /// </summary>
        Queued,

        /// <summary>
        /// Batch is processing.
        /// </summary>
        Processing,

        /// <summary>
        /// Batch is complete.
        /// </summary>
        Finished,

        /// <summary>
        /// Batch is complete with an error.
        /// </summary>
        FinishedWithErrors,
    }
}