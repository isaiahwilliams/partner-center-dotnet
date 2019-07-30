// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Users
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// The possible states for a user.
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum UserState
    {
        /// <summary>
        /// Active user
        /// </summary>
        Active,

        /// <summary>
        /// Inactive user
        /// </summary>
        Inactive
    }
}