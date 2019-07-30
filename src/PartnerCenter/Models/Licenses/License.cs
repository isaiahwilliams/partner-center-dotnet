// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Licenses
{
    using System.Collections.Generic;

    /// <summary>
    /// Model for user licenses assigned to a user.
    /// </summary>
    public sealed class License : ResourceBase
    {
        /// <summary>
        /// Gets or sets the product SKU associated with the license.
        /// </summary>
        public ProductSku ProductSku { get; set; }

        /// <summary>
        /// Gets or sets the service plan collection. 
        /// </summary>
        /// <remarks>
        /// Service plans refer to services that user is assigned to use.
        /// For example , Delve is a service plan which a user is either assigned to use or can be assigned to use.
        /// </remarks>
        public IEnumerable<ServicePlan> ServicePlans { get; set; }
    }
}