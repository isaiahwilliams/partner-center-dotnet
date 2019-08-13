// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [JsonObject]
    public class ResourceCollection<TResource> : ResourceCollection<TResource, StandardResourceCollectionLinks>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCollection{TResource}" /> class.
        /// </summary>
        /// <param name="items">The collection whose elements are copied to the new list.</param>
        public ResourceCollection(ICollection<TResource> items)
          : base(items)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceCollection{TResource}" /> class.
        /// </summary>
        /// <param name="resourceCollection">The collection whose elements are copied to the new list.</param>
        protected ResourceCollection(ResourceCollection<TResource> resourceCollection)
          : base(resourceCollection)
        {
        }
    }
}