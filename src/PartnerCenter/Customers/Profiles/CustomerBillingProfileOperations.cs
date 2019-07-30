// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Customers.Profiles
{
    using Extensions;
    using Models.Customers;
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Implements the customer billing profile operations.
    /// </summary>
    internal class CustomerBillingProfileOperations : BasePartnerComponent<string>, ICustomerProfile<CustomerBillingProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerBillingProfileOperations" /> class.
        /// </summary>
        /// <param name="rootPartnerOperations">The root partner operations instance.</param>
        /// <param name="customerId">The customer identifier.</param>
        public CustomerBillingProfileOperations(IPartner rootPartnerOperations, string customerId)
          : base(rootPartnerOperations, customerId)
        {
            customerId.AssertNotEmpty(nameof(customerId));
        }

        /// <summary>
        /// Gets the customer's billing profile.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The customer's billing profile.</returns>
        public async Task<CustomerBillingProfile> GetAsync(CancellationToken cancellationToken = default)
        {
            return await Partner.ServiceClient.GetAsync<CustomerBillingProfile>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.GetCustomerBillingProfile.Path}",
                        Context),
                    UriKind.Relative),
                cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the customer's billing profile.
        /// </summary>
        /// <param name="billingProfile">A customer billing profile with updated fields.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The updated customer billing profile.</returns>
        public async Task<CustomerBillingProfile> UpdateAsync(CustomerBillingProfile entity, CancellationToken cancellationToken = default)
        {
            entity.AssertNotNull(nameof(entity));

            return await Partner.ServiceClient.PutAsync<CustomerBillingProfile, CustomerBillingProfile>(
                new Uri(
                    string.Format(
                        CultureInfo.InvariantCulture,
                        $"/{PartnerService.Instance.ApiVersion}/{PartnerService.Instance.Configuration.Apis.UpdateCustomerBillingProfile.Path}",
                        Context),
                    UriKind.Relative),
                entity,
                cancellationToken).ConfigureAwait(false);
        }
    }
}