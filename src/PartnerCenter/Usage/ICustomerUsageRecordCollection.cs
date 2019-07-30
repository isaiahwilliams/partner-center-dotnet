// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using GenericOperations;
    using Models;
    using Models.Usage;

    /// <summary>
    /// Defines the behavior of a customer usage record collection operations.
    /// </summary>
    public interface ICustomerUsageRecordCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<CustomerMonthlyUsageRecord, ResourceCollection<CustomerMonthlyUsageRecord>>
    {
    }
}