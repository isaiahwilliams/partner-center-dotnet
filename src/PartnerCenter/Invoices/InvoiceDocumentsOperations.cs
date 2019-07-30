// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    /// <summary>
    /// Defines the operations available for an invoice document.
    /// </summary>
    internal class InvoiceDocumentsOperations : BasePartnerComponent<string>, IInvoiceDocuments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDocumentsOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="invoiceId">The invoice id.</param>
        public InvoiceDocumentsOperations(IPartner rootPartnerOperations, string invoiceId)
          : base(rootPartnerOperations, invoiceId)
        {
        }

        /// <summary>
        /// Gets an invoice statement operations.
        /// </summary>
        public IInvoiceStatement Statement => new InvoiceStatementOperations(Partner, Context);
    }
}