// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using Models.JsonConverters;
    using Newtonsoft.Json;

    /// <summary>Lists invoice line item types.</summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum InvoiceLineItemType
    {
        None,
        UsageLineItems,
        BillingLineItems
    }
}