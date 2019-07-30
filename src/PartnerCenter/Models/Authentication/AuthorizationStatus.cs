// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Authentication
{
    /// <summary>
    /// The available status entries for an authorization request.
    /// </summary>
    internal enum AuthorizationStatus
    {
        Success,
        ErrorHttp,
        ProtocolError,
        UserCancel,
        UnknownError
    }
}