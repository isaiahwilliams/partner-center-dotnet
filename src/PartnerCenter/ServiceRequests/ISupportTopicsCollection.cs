// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ServiceRequests
{
    using GenericOperations;
    using Models;
    using Models.ServiceRequests;

    /// <summary>
    /// Represents the behavior of support topics.
    /// </summary>
    public interface ISupportTopicsCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<SupportTopic, ResourceCollection<SupportTopic>>
    {
    }
}