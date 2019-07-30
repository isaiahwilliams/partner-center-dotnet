// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Profiles
{
    using GenericOperations;
    using Models;

    /// <summary>
    /// Encapsulates a single customer profile behavior.
    /// </summary>
    /// <typeparam name="T">The type of the customer profile.</typeparam>
    public interface ICustomerProfile<T> : ICustomerReadonlyProfile<T>, IEntityUpdateOperations<T, T>
      where T : ResourceBase
    {
    }
}