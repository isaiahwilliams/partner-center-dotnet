// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.ServiceRequests
{
    using System;

    /// <summary>
    /// Represents a service request note.
    /// </summary>
    public sealed class ServiceRequestNote
    {
        /// <summary>
        /// Gets or sets the name of the creator of the note.
        /// </summary>
        public string CreatedByName { get; set; }

        /// <summary>
        /// Gets or sets the time the note was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the text of the note.
        /// </summary>
        public string Text { get; set; }
    }
}