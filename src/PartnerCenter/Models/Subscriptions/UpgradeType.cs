// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Lists upgrade options for a subscription.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum UpgradeType
    {
        /// <summary>
        /// Default value.
        /// </summary>
        None,

        /// <summary>
        /// Subscription upgrade only.
        /// </summary>
        UpgradeOnly,

        /// <summary>
        /// Subscription upgrade and license transfer.
        /// </summary>
        UpgradeWithLicenseTransfer
    }
}