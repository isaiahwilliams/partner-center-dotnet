// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.RequestContext
{
    using System;

    /// <summary>
    /// Used to create instances of the request context.
    /// </summary>
    public sealed class RequestContextFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestContextFactory" /> class.
        /// </summary>
        private RequestContextFactory()
        {
        }

        /// <summary>
        /// Creates a request context object which will use a randomly generated correlation identifier and a unique request identifier for each call to the partner service.
        /// </summary>
        /// <returns>A request context object.</returns>
        public static IRequestContext Create()
        {
            return new RequestContext();
        }

        /// <summary>
        /// Creates a request context object with the provided correlation Id and a unique request Id for each partner API call.
        /// </summary>
        /// <param name="correlationId">The correlation identifier used to group logical operations together.</param>
        /// <returns>A request context object.</returns>
        public static IRequestContext Create(Guid correlationId)
        {
            return new RequestContext(correlationId);
        }

        /// <summary>
        /// Creates a request context object which will use a randomly generated correlation Id, a unique request Id and provided locale for each partner API call.
        /// </summary>
        /// <param name="locale">The locale to be used for the oepration.</param>
        /// <returns>A request context object.</returns>
        public static IRequestContext Create(string locale)
        {
            return new RequestContext(locale);
        }

        /// <summary>
        /// Creates a request context object with the provided correlation Id, a unique request Id and provided locale for each partner API call.
        /// </summary>
        /// <param name="correlationId">The correlation identifier used to group logical operations together.</param>
        /// <param name="locale">The locale to be used for the oepration.</param>
        /// <returns>A request context object.</returns>
        public static IRequestContext Create(Guid correlationId, string locale)
        {
            return new RequestContext(correlationId, locale);
        }

        /// <summary>
        /// Creates a request context object with the provided correlation and request Ids.
        /// </summary>
        /// <param name="correlationId">The correlation identifier used to group logical operations together.</param>
        /// <param name="requestId">The request identifier that uniquely identifies the operation.</param>
        /// <returns>A request context object.</returns>
        public static IRequestContext Create(Guid correlationId, Guid requestId)
        {
            return new RequestContext(correlationId, requestId, null);
        }

        /// <summary>
        /// Creates a request context object with the provided correlation, request Ids and locale.
        /// </summary>
        /// <param name="correlationId">The correlation identifier used to group logical operations together.</param>
        /// <param name="requestId">The request identifier that uniquely identifies the operation.</param>
        /// <param name="locale">The locale to be used for the oepration.</param>
        /// <returns>A request context object.</returns>
        public static IRequestContext Create(Guid correlationId, Guid requestId, string locale)
        {
            return new RequestContext(correlationId, requestId, locale);
        }
    }
}