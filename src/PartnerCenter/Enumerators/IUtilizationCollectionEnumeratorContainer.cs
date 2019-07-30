// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Enumerators
{
    using Factories;
    using Models;
    using Models.Utilizations;

    /// <summary>
    /// Groups all supported utilization record enumerators for usage based subscriptions.
    /// </summary>
    public interface IUtilizationCollectionEnumeratorContainer : IPartnerComponent<string>
    {
        /// <summary>
        /// Gets a factory that creates Azure utilization record collection enumerators.
        /// </summary>
        IResourceCollectionEnumeratorFactory<ResourceCollection<AzureUtilizationRecord>> Azure { get; }
    }
}