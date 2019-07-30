// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Auditing
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>Lists the supported audit search fields.</summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum AuditRecordSearchField
    {
        /// <summary
        /// >Customer company name.
        /// </summary>
        CompanyName,

        /// <summary>Customer identifier (Guid).
        /// </summary>
        CustomerId,

        /// <summary>
        /// Resource Type as defined in available Resource Types (Example: Order, Subscription).
        /// </summary>
        ResourceType,
    }
}