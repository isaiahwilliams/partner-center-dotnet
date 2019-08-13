// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ServiceRequests
{
    using System;
    using GenericOperations;
    using Models.ServiceRequests;

    /// <summary>
    /// Groups operations that can be performed on a single service request.
    /// </summary>
    public interface IServiceRequest : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<ServiceRequest>, IEntityPatchOperations<ServiceRequest>
    {
    }
}