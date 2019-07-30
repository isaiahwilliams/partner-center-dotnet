// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using Models.JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Different providers of billing information.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum DocumentType
    {
        None,
        Invoice,
        VoidNote,
        AdjustmentNote,
    }
}