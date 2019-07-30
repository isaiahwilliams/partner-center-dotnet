// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using JsonConverters;
    using Newtonsoft.Json;
    /// <summary>
    /// The way billing is processed for a subscription.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum BillingType
    {
        /// <summary>
        /// Indicates nothing - not set, used as an initializer.
        /// </summary>
        None = 0,

        /// <summary>
        /// Usage based billing.
        /// </summary>
        Usage = 1,

        /// <summary>
        /// License based billing.
        /// </summary>
        License = 2
    }
}