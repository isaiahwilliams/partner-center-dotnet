// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Query
{
    /// <summary>
    /// A base class that represents a filter applied to a field.
    /// </summary>
    public abstract class FieldFilter
    {
        /// <summary>
        /// Gets or sets the filter operator.
        /// </summary>
        public FieldFilterOperation Operator { get; protected set; }
    }
}