// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    /// <summary>
    /// Represents the operations that can be done on the partner's estimate collection.
    /// </summary>
    public interface IEstimateCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the estimate links of the recon line items.
        /// </summary>
        IEstimateLink Links { get; }
    }
}