// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    /// <summary>
    /// The type of errors that prevent trial subscription conversion from happening.
    /// </summary>
    public enum ConversionErrorCode
    {
        /// <summary>
        /// General error.
        /// </summary>
        Other,

        /// <summary>
        /// Cannot find any conversions for the trial subscription to convert to.
        /// </summary>
        ConversionsNotFound
    }
}