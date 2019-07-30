// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Incidents
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the status of Partner Center services.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum MessageType
    {
        /// <summary>
        /// Default type none.
        /// </summary>
        None,

        /// <summary>
        /// Active incident.
        /// </summary>
        Incident,

        /// <summary>
        /// Message center message.
        /// </summary>
        MessageCenter,

        /// <summary>
        /// All types.
        /// </summary>
        All,
    }
}