// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using GenericOperations;
    using Models;
    using Models.Agreements;

    /// <summary>
    /// Represents the agreement details behavior.
    /// </summary>
    public interface IAgreementDetailsCollection : IPartnerComponent<string>, IEntireEntityCollectionRetrievalOperations<AgreementMetaData, ResourceCollection<AgreementMetaData>>, IEntitySelector<string, IAgreement>
    {
        /// <summary>
        /// Scopes agreements behavior to a specific agreement type.
        /// </summary>
        /// <param name="agreementType">The agreement type used to scope.</param>
        /// <returns>The agreement collection operations customized for the given agreement type.</returns>
        IAgreementDetailsCollection ByAgreementType(string agreementType);
    }
}