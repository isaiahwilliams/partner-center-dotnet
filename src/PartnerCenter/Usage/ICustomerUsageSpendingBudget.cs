// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using GenericOperations;
    using Models.Usage;

    /// <summary>
    /// Defines the operations available on a customer's usage spending budget.
    /// </summary>
    public interface ICustomerUsageSpendingBudget : IPartnerComponent<string>, IEntityGetOperations<SpendingBudget>, IEntityPatchOperations<SpendingBudget>
    {
    }
}