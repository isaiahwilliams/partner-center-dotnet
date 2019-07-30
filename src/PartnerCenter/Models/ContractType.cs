// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Describes the type of contract.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ContractType
    {
        /// <summary>
        /// Refers to a contract which provides subscription for the order item placed
        /// </summary>
        Subscription,

        /// <summary>
        /// Refers to a contract which provides a product key result for the order item placed
        /// </summary>
        ProductKey,

        /// <summary>
        /// Refers to a contract which provides Redemption code result for the order item placed.
        /// </summary>
        RedemptionCode
    }
}