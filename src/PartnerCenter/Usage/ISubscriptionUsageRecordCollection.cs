// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Usage
{
    using System;

    /// <summary>
    /// This interface defines behavior for a single subscription usage records.
    /// </summary>
    public interface ISubscriptionUsageRecordCollection : IPartnerComponent<Tuple<string, string>>
    {
        /// <summary>
        /// Gets the subscription usage records grouped by resource.
        /// </summary>
        IUsageRecordByResourceCollection ByResource { get; }

        /// <summary>
        /// Gets the subscription usage records grouped by meter.
        /// </summary>
        IUsageRecordByMeterCollection ByMeter { get; }
    }
}