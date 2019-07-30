// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Auditing
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents status of an operation.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum OperationStatus
    {
        /// <summary>
        /// Indicates success of the operation.
        /// </summary>
        Succeeded,

        /// <summary>
        /// Indicates failure of the operation.
        /// </summary>
        Failed,

        /// <summary>
        /// Indicates that the operation is still in progress.
        /// </summary>
        Progress,

        /// <summary>
        /// Indicates that the operation is declined.
        /// </summary>
        Decline,
    }
}