// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Licenses
{
    /// <summary>
    /// Model class for a service plan associated with a product.
    /// </summary>
    public sealed class ServicePlan
    {
        /// <summary>
        /// Gets or sets the service plan status of a service plan.
        /// </summary>
        public string CapabilityStatus { get; set; }

        /// <summary>
        /// Gets or sets the localized display name for service plan.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the service plan identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the service name.
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets the target type of a service plan.
        /// </summary>
        /// <remarks>
        /// It can be used to filter service plans which are applicable to user or tenant.
        /// For example, if we need to know all service plans applicable to user , we can filter where target type == "User".
        /// </remarks>
        public string TargetType { get; set; }
    }
}