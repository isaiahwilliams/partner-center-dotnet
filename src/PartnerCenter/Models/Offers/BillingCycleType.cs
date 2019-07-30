// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Offers
{
    using JsonConverters;
    using Newtonsoft.Json;

    [JsonConverter(typeof(EnumJsonConverter))]
    public enum BillingCycleType
    {
        Unknown,
        Monthly,
        Annual,
        None,
        OneTime,
    }
}