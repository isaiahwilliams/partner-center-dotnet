// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Incidents
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Lists the supported service incident search fields.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ServiceIncidentSearchField
    {
        /// <summary>
        /// Search by service health incidents resolved status.
        /// </summary>
        Resolved
    }
}