// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Carts
{
    using GenericOperations;
    using Models.Carts;

    /// <summary>
    /// Encapsulates a customer cart behavior.
    /// </summary>
    public interface ICartCollection : IPartnerComponent<string>, IEntityCreateOperations<Cart, Cart>, IEntitySelector<string, ICart>
    {
    }
}
