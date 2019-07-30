// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Authentication
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents a response for the authentication system.
    /// </summary>
    [DataContract]
    internal sealed class AuthenticationResponse
    {
        [DataMember(IsRequired = false, Name = "access_token")]
        public string AccessToken { get; set; }

        [DataMember(IsRequired = false, Name = "created_on")]
        public long CreatedOn { get; set; }

        [DataMember(IsRequired = false, Name = "error")]
        public string Error { get; set; }

        [DataMember(IsRequired = false, Name = "error_codes")]
        public string[] ErrorCodes { get; set; }

        [DataMember(IsRequired = false, Name = "error_description")]
        public string ErrorDescription { get; set; }

        [DataMember(IsRequired = false, Name = "expires_in")]
        public long ExpiresIn { get; set; }

        [DataMember(IsRequired = false, Name = "expires_on")]
        public long ExpiresOn { get; set; }

        [DataMember(IsRequired = false, Name = "id_token")]
        public string IdTokenString { get; set; }

        [DataMember(IsRequired = false, Name = "refresh_token")]
        public string RefreshToken { get; set; }

        [DataMember(IsRequired = false, Name = "resource")]
        public string Resource { get; set; }

        [DataMember(IsRequired = false, Name = "token_type")]
        public string TokenType { get; set; }
    }
}