// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using GenericOperations;
    using System.IO;

    /// <summary>
    /// Represents the operations available to an invoice statement.
    /// </summary>
    public interface IInvoiceStatement : IPartnerComponent<string>, IEntityGetOperations<Stream>
    {
    }
}