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
        /// <summary>
        /// Scopes customer agreements behavior to a specific agreement type.
        /// </summary>
        /// <param name="agreementType">The type of agreement used to filter.</param>
        /// <returns>The customer agreement collection operations customized for the given type.</returns>
        ICustomerAgreementCollection ByAgreementType(string agreementType);
    }
}