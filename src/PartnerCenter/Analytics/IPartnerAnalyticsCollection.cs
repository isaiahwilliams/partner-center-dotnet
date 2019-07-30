// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    /// <summary>
    /// Encapsulates collection of partner's analytics.
    /// </summary>
    public interface IPartnerAnalyticsCollection : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets the partner's licenses analytics collection.
        /// </summary>
        IPartnerLicensesAnalyticsCollection Licenses { get; }
    }
}