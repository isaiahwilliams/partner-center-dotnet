// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using GenericOperations;
    using Models.Invoices;

    /// <summary>
    /// Represents all the operations that can be done on an invoice summary.
    /// </summary>
    public interface IInvoiceSummary : IPartnerComponent<string>, IEntityGetOperations<InvoiceSummary>
    {
    }
}