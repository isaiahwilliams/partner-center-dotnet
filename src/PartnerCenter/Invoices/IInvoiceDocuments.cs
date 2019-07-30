// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    /// <summary>
    /// Defines the operations available on invoice documents.
    /// </summary>
    public interface IInvoiceDocuments : IPartnerComponent<string>
    {
        /// <summary>Gets an invoice statement operations.</summary>
        IInvoiceStatement Statement { get; }
    }
}