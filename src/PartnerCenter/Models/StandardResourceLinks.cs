// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models
{
    using Newtonsoft.Json;

    public class StandardResourceLinks
    {
        /// <summary>
        /// Gets or sets the self link.
        /// </summary>
        [JsonProperty]
        public Link Self { get; set; }
    }
}
