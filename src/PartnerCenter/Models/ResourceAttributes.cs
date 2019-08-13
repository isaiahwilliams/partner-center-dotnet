// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models
{
    using System;
    using Newtonsoft.Json;

    public sealed class ResourceAttributes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAttributes" /> class.
        /// </summary>
        public ResourceAttributes()
        {
        }

        /// <summary>
        /// Intializes a new instance of the <see cref="ResourceAttributes" /> class.
        /// </summary>
        /// <param name="type">The type of resource.</param>
        public ResourceAttributes(Type type)
        {
            if (type == null)
            {
                return;
            }

            ObjectType = type.Name;
        }

        /// <summary>
        /// Gets or sets the etag.
        /// </summary>
        [JsonProperty]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets the object type.
        /// </summary>
        public string ObjectType { get; set; }
    }
}