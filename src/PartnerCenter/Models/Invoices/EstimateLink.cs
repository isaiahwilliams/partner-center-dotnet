// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    /// <summary>
    /// Represents a URI and the HTTP method which indicates the desired action for accessing the resource.
    /// </summary>
    public sealed class EstimateLink
    {
        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>        
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the period.
        /// </summary>
        public string Period { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }
    }
}