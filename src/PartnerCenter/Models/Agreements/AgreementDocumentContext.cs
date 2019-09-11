// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Agreements
{
    /// <summary>
    /// Context for an agreement document.
    /// </summary>
    public class AgreementDocumentContext
    {
        /// <summary>
        /// Gets or sets the template ID.
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        ///  Gets or sets the transform options for the agreement document.
        /// </summary>
        public AgreementDocumentTransformOptions TransformOptions { get; set; }
    }
}