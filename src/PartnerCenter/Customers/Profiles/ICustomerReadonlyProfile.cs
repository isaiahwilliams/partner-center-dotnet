// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Profiles
{
    using GenericOperations;
    using Models;

    /// <summary>
    /// Encapsulates a single customer readonly profile behavior.
    /// </summary>
    /// <typeparam name="T">The type of the customer profile.</typeparam>
    public interface ICustomerReadonlyProfile<T> : IPartnerComponent<string>, IEntityGetOperations<T> where T : ResourceBase
    {
    }
}