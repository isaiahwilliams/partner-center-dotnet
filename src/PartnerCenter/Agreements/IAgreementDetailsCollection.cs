// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using GenericOperations;
    using Models;
    using Models.Agreements;

    /// <summary>
    /// This interface represents the agreement details behavior.
    /// </summary>
    public interface IAgreementDetailsCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<AgreementMetaData, ResourceCollection<AgreementMetaData>>
    {
    }
}