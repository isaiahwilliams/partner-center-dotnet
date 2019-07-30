// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.RelationshipRequests
{
    using GenericOperations;
    using Models.RelationshipRequests;

    /// <summary>
    /// Holds operations that apply to customer relationship requests.
    /// </summary>
    public interface ICustomerRelationshipRequest : IPartnerComponent<string>, IEntityGetOperations<CustomerRelationshipRequest>
    {
    }
}