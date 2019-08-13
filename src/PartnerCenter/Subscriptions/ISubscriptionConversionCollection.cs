// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using System;
    using GenericOperations;
    using Models;
    using Models.Subscriptions;

    /// <summary>
    /// This interface defines the conversion operations available on a customer's trial subscription.
    /// </summary>
    public interface ISubscriptionConversionCollection : IPartnerComponent<Tuple<string, string>>, IEntireEntityCollectionRetrievalOperations<Conversion, ResourceCollection<Conversion>>, IEntityCreateOperations<Conversion, ConversionResult>
    {
    }
}