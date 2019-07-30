// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using Models.JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the billing periods.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum BillingPeriod
    {
        /// <summary>
        /// Default period, does not mean anything.
        /// </summary>
        None,

        /// <summary>
        /// The current period that is ongoing.
        /// </summary>
        Current,

        /// <summary>
        /// The previous period.
        /// </summary>
        Previous
    }
}