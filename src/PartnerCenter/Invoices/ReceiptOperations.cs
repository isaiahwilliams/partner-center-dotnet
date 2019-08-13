// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using System;
    using Extensions;

    /// <summary>
    /// Implements the available receipt operations.
    /// </summary>
    internal class ReceiptOperations : BasePartnerComponent<Tuple<string, string>>, IReceipt
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiptOperations"/> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="invoiceId">The invoice identifier.</param>
        /// <param name="receiptId">The receipt identifier.</param>
        public ReceiptOperations(IPartner rootPartnerOperations, string invoiceId, string receiptId)
            : base(rootPartnerOperations, new Tuple<string, string>(invoiceId, receiptId))
        {
            invoiceId.AssertNotEmpty(nameof(invoiceId));
            receiptId.AssertNotEmpty(nameof(receiptId));
        }

        /// <summary>
        /// Gets the available receipt document operations.
        /// </summary>
        public IReceiptDocuments Documents => new ReceiptDocumentsOperations(Partner, Context.Item1, Context.Item2);
    }
}