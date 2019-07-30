// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Extensions
{
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a delegate used to retrieve updated tokens.
    /// </summary>
    /// <param name="expiredAuthenticationToken">The authentication token which has expired.</param>
    /// <returns>A delegate used to retrieve updated tokens.</returns>
    public delegate Task<AuthenticationToken> TokenRefresher(AuthenticationToken expiredAuthenticationToken);
}
