// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using System;

    /// <summary>
    /// Represents the available receipt operations.
    /// </summary>
    public interface IReceipt : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Gets the receipt documents behavior of the invoices.
        /// </summary>
        IReceiptDocuments Documents { get; }
    }
}