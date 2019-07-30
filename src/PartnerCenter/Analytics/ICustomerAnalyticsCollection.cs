// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    /// <summary>
    /// Represents the customer analytics collection operations.
    /// </summary>
    public interface ICustomerAnalyticsCollection : IPartnerComponent<string>
    {
        /// <summary>Gets the customer's licenses analytics collection.</summary>
        ICustomerLicensesAnalyticsCollection Licenses { get; }
    }
}