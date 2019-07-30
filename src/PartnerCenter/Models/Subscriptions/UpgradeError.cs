// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Subscriptions
{
    /// <summary>
    /// Represents an error for subscription upgrade eligibility.
    /// </summary>
    public sealed class UpgradeError
    {
        /// <summary>
        /// Gets or sets additional details regarding the error.
        /// </summary>
        public string AdditionalDetails { get; set; }

        /// <summary>
        /// Gets or sets the error code associated with the issue.
        /// </summary>
        public UpgradeErrorCode Code { get; set; }

        /// <summary>
        /// Gets or sets the friendly text describing the error.
        /// </summary>
        public string Description { get; set; }
    }
}