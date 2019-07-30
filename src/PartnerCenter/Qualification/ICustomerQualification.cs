// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Qualification
{
    using GenericOperations;
    using Models.Customers;
    using Models.ValidationCodes;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines the operations available on a customer's qualification.
    /// </summary>
    public interface ICustomerQualification : IPartnerComponent<string>, IEntityGetOperations<CustomerQualification>, IEntityUpdateOperations<CustomerQualification, CustomerQualification>
    {
        /// <summary>
        /// Updates the customer qualification. Use for GovernmentCommunityCloud with validation code after successful registration through Microsoft.
        /// </summary>
        /// <param name="customerQualification">Customer qualification to be updated.</param>
        /// <param name="governmentCommunityCloudValidationCode">Validation code necessary to complete only Government Community Cloud customer creation. List validation codes with GetValidationCodes in ValidationOperations.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The updated customer qualification.</returns>
        Task<CustomerQualification> UpdateAsync(CustomerQualification customerQualification, ValidationCode governmentCommunityCloudValidationCode, CancellationToken cancellationToken = default);
    }
}