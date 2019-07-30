// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Entitlements
{
    /// <summary>
    /// Class that represents reserved instance artifact.
    /// </summary>
    public class ReservedInstanceArtifact : Artifact
    {
        /// <summary>
        /// Gets or sets the artifact link.
        /// </summary>
        public Link Link { get; set; }

        /// <summary>
        /// Gets or sets the resource identity (reservation order identifier).
        /// </summary>
        public string ResourceId { get; set; }
    }
}