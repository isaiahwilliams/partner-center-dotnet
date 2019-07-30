// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Lists the supported invoice search fields.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum InvoiceSearchField
    {
        /// <summary>
        /// The invoice date.
        /// </summary>
        InvoiceDate
    }
}