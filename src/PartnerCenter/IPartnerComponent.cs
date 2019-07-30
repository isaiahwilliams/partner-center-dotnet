// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter
{
    /// <summary>
    /// Represents a partner service component.
    /// </summary>
    /// <typeparam name="TContext">The type of the component's context object.</typeparam>
    public interface IPartnerComponent<out TContext>
    {
        /// <summary>
        /// Gets a reference to the partner operations instance that generated this component.
        /// </summary>
        IPartner Partner { get; }

        /// <summary>
        /// Gets the component context object.
        /// </summary>
        TContext Context { get; }
    }
}