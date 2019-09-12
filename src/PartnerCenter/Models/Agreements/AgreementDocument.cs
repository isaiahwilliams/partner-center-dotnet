// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Agreements
{
    /// <summary>
    /// Represents an agreement document that contains links to the content of an agreement template.
    /// </summary>
    public class AgreementDocument
    {
        /// <summary>
        /// Gets or sets the ISO alpha-2 code of the country for which the agreement document is tailored.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the display URI of the agreement document.
        /// </summary>
        public string DisplayUri { get; set; }

        /// <summary>
        /// Gets or sets the download URI of the agreement document.
        /// </summary>
        public string DownloadUri { get; set; }

        /// <summary>
        /// Gets or sets the language and locale of the agreement document.
        /// </summary>
        public string Language { get; set; }
    }
}