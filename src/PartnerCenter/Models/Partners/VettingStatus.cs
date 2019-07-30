// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Partners
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Enumeration of vetting status.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum VettingStatus
    {
        /// <summary>
        /// None vetting status
        /// </summary>
        None,

        /// <summary>
        /// Pending vetting status
        /// </summary>
        Pending,

        /// <summary>
        /// Authorized vetting status
        /// </summary>
        Authorized,

        /// <summary>
        /// Rejected vetting status
        /// </summary>
        Rejected
    }
}