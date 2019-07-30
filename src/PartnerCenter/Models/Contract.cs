// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models
{
    /// <summary>
    /// Base class for contracts.
    /// </summary>
    public abstract class Contract : ResourceBase
    {
        /// <summary>
        /// Gets the contract type.
        /// </summary>
        public abstract ContractType ContractType { get; }

        /// <summary>
        /// Gets or sets the  order identifier.
        /// </summary>
        public string OrderId { get; set; }
    }
}