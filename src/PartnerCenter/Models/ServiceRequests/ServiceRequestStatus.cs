// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ServiceRequests
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Describes service request status.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ServiceRequestStatus
    {
        /// <summary>
        /// Default service request status.
        /// </summary>
        None,

        /// <summary>
        /// An opened service request.
        /// </summary>
        Open,

        /// <summary>
        /// A closed service request.
        /// </summary>
        Closed,

        /// <summary>
        /// A service request that needs attention.
        /// </summary>
        AttentionNeeded
    }
}