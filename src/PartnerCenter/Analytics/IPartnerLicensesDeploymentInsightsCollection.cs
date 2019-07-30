// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Analytics
{
    using GenericOperations;
    using Models;
    using Models.Analytics;

    /// <summary>
    /// Encapsulates the operations on the partner's licenses' deployment insights collection.
    /// </summary>
    public interface IPartnerLicensesDeploymentInsightsCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<PartnerLicensesDeploymentInsights, ResourceCollection<PartnerLicensesDeploymentInsights>>
    {
    }
}