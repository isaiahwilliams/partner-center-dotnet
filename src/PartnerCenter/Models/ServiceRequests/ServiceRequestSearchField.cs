// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ServiceRequests
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Lists the supported service request search fields.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ServiceRequestSearchField
    {
        /// <summary>
        /// Service request status.
        /// </summary>
        Status
    }
}