// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using GenericOperations;
    using Models;
    using Models.Invoices;

    /// <summary>
    /// Represents all the operations that can be done on invoice summary collection.
    /// </summary>
    public interface IInvoiceSummaryCollection : IPartnerComponent<string>, IEntityGetOperations<ResourceCollection<InvoiceSummary>>
    {
    }
}