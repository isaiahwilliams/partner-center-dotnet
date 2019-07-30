// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.RequestContext
{
    using System;

    /// <summary>
    /// Bundles context information which is amended to the partner service operations.
    /// </summary>
    public interface IRequestContext
    {
        /// <summary>
        /// Gets the correlation identifier used to group logical operations together.
        /// </summary>
        Guid CorrelationId { get; }

        /// <summary>
        /// Gets the locale to be used for the oepration.
        /// </summary>
        string Locale { get; }

        /// <summary>
        /// Gets the request identifier that uniquely identifies the operation.
        /// </summary>
        Guid RequestId { get; }
    }
}