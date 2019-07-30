// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Carts
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Types of Participants
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ParticipantType
    {
        /// <summary>
        /// Default value if not known.
        /// </summary>
        Unknown,

        /// <summary>
        /// An indirect reseller with a transaction role.
        /// </summary>
        TransactionReseller,
    }
}