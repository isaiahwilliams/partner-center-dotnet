// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Invoices
{
    using GenericOperations;

    /// <summary>
    /// Represents the operations that can be done on receipt collection.
    /// </summary>
    public interface IReceiptCollection : IPartnerComponent<string>, IEntitySelector<string, IReceipt>
    {
    }
}