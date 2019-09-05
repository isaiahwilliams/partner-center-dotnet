// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Agreements
{
    using System;

    /// <summary>
    /// Represents an agreement template that can be downloaded or viewed.
    /// </summary>
    public sealed class AgreementTemplate : ResourceBase
    {
        /// <summary>
        /// Gets or sets the country for the agreement document.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the link to preview the agreeement document.
        /// </summary>
        public Uri DisplayUri { get; set; }

        /// <summary>
        /// Gets or sets the link to download the agreement document.
        /// </summary>
        public Uri DownloadUri { get; set; }

        /// <summary>
        /// Gets or sets the localized langauge for the agreement document.
        /// </summary>
        public string Language { get; set; }
    }
}