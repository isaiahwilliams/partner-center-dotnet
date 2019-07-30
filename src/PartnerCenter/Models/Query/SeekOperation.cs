// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Query
{
    /// <summary>
    /// Specifies how to seek a query.
    /// </summary>
    public enum SeekOperation
    {
        /// <summary>
        /// Gets the next set of results.
        /// </summary>
        Next,

        /// <summary>
        /// Gets the previous set of results.</summary>
        Previous,

        /// <summary>
        /// Gets the first set of results.
        /// </summary>
        First,

        /// <summary>
        /// Gets the last set of results.
        /// </summary>
        Last,

        /// <summary>
        /// Gets a set of results using a page index. E.g. Get the seventh set of results.
        /// </summary>
        PageIndex
    }
}