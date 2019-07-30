// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using System;

    /// <summary>
    /// Represents the operations available on receipt documents.
    /// </summary>
    public interface IReceiptDocuments : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Gets the receipt statement operations.
        /// </summary>
        IReceiptStatement Statement { get; }
    }
}