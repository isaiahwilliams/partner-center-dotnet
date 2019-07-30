// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Partners
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Enumeration of vetting version
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum VettingVersion
    {
        /// <summary>
        /// None vetting version
        /// </summary>
        None,

        /// <summary>
        /// Latest vetting information: Will always get the latest vetting information no matter if it is vetted or not
        /// </summary>
        Current,

        /// <summary>
        /// Latest finalized vetting information: Will return the latest vetting information that is either (Authorized or Rejected)
        /// </summary>
        LastFinalized
    }
}