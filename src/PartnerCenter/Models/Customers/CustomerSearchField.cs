// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Customers
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Lists the supported customer search fields.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum CustomerSearchField
    {
        /// <summary>
        /// Customer company name.
        /// </summary>
        CompanyName,

        /// <summary>
        /// Customer domain name.
        /// </summary>
        Domain,

        /// <summary>
        /// The indirect reseller
        /// </summary>
        IndirectReseller,

        /// <summary>
        /// The indirect CSP
        /// </summary>
        IndirectCloudSolutionProvider
    }
}