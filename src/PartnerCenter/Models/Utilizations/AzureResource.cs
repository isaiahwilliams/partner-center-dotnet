// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Utilizations
{
    public class AzureResource
    {
        /// <summary>
        /// Gets or sets the category of the consumed resource.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the resource.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the friendly name of the resource.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the region of the consumed resource.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets the sub-category of the consumed Azure resource.
        /// </summary>
        public string Subcategory { get; set; }

    }
}