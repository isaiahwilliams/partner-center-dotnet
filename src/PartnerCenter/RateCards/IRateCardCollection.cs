// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.RateCards
{
    /// <summary>
    /// Holds operations that apply to rate cards.
    /// </summary>
    public interface IRateCardCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the Azure rate card operations.
        /// </summary>
        IAzureRateCard Azure { get; }
    }
}