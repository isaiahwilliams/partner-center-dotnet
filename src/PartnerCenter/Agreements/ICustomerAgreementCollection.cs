// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using GenericOperations;
    using Models;
    using Models.Agreements;

    /// <summary>
    /// Defines the operations available on a partner-customer agreement.
    /// </summary>
    public interface ICustomerAgreementCollection : IPartnerComponent<string>, IEntityCreateOperations<Agreement, Agreement>, IEntireEntityCollectionRetrievalOperations<Agreement, ResourceCollection<Agreement>>
    {
    }
}