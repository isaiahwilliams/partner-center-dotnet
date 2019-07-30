// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ManagedServices
{
    using GenericOperations;
    using Models;
    using Models.ManagedServices;

    /// <summary>
    /// Holds the customer's managed services operations.
    /// </summary>
    public interface IManagedServiceCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<ManagedService, ResourceCollection<ManagedService>>
    {
    }
}
