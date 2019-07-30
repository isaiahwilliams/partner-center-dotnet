// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Licenses
{
    /// <summary>
    /// Model for product details.
    /// </summary>
    public sealed class ProductSku
    {
        /// <summary>
        /// Gets or sets the product identifier for the product SKU.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the group id of a license.
        /// </summary>
        /// <remarks>
        /// For example 'Windows 10 Enterprise E3' is managed through Group1.
        /// </remarks>
        public LicenseGroupId LicenseGroupId { get; set; }

        /// <summary>
        /// Gets or sets a localized display name for the product SKU.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a SKU part number name for the product.
        /// </summary>
        /// <remarks>
        /// For example, for Office 365 Plan E3 , this value is "EnterprisePack".
        /// This can be used in place of Id if the id is not available.
        /// </remarks>
        public string SkuPartNumber { get; set; }

        /// <summary>
        /// Gets or sets the target type of a product.
        /// </summary>
        /// <remarks>
        /// It can be used to filter products which are applicable to user or tenant.
        /// For example, if we need to know all products applicable to user , we can filter where target type == "User".
        /// </remarks>
        public string TargetType { get; set; }
    }
}