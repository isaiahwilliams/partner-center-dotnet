// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Extensions
{
    using Products;

    /// <summary>
    /// Holds operations that extend another set of operations.
    /// </summary>
    public interface IExtensions : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the product extension operations.
        /// </summary>
        IProductExtensions Product { get; }
    }
}