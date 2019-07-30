// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Invoices
{
    using System;

    /// <summary>
    /// Represents the tax receipt details.
    /// </summary>
    public sealed class TaxReceipt
    {
        /// <summary>
        /// Gets or sets the tax receipt unique identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the tax receipt download link.
        /// </summary>
        public Uri TaxReceiptPdfDownloadLink { get; set; }
    }
}
