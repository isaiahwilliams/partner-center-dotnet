// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Query
{
    /// <summary>
    /// Represents a query on an entity. All different queries should implement this contract.
    /// </summary>
    public interface IQuery
    {
        /// <summary>
        /// Gets the query type.
        /// </summary>
        QueryType Type { get; }

        /// <summary>
        /// Gets or sets the query filter.
        /// </summary>
        FieldFilter Filter { get; set; }

        /// <summary>Gets or sets the query sorting options.
        /// </summary>
        Sort Sort { get; set; }

        /// <summary>
        /// Gets or sets the result starting index.
        /// </summary>
        int Index { get; set; }

        /// <summary>
        /// Gets or sets the results page size.
        /// </summary>
        int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the query token. The token may hold context used to represent current state with back end services.
        /// </summary>
        object Token { get; set; }

        /// <summary>
        /// Gets or sets the seek operation that needs to be performed.
        /// </summary>
        SeekOperation SeekOperation { get; set; }
    }
}