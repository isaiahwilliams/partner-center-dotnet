// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Products
{
    using GenericOperations;
    using Models.Products;
    using System;

    /// <summary>
    /// Holds operations that can be performed on a single availability.
    /// </summary>
    public interface IAvailability : IPartnerComponent<Tuple<string, string, string, string>>, IEntityGetOperations<Availability>
    {
    }
}