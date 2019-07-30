// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Relationships
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Lists the supported partner relationship search fields.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum PartnerRelationshipSearchField
    {
        /// <summary>
        /// Partner company name.
        /// </summary>
        Name
    }
}