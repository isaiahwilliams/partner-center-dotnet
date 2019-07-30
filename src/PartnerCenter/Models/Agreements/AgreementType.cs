// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Agreements
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Represents the types of agreements supported.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgreementType
    {
        /// <summary>
        /// Microsoft cloud agreement
        /// </summary>
        MicrosoftCloudAgreement,
    }
}