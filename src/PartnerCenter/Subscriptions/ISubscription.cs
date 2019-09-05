// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Subscriptions
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using GenericOperations;
    using Models.Subscriptions;
    using Usage;
    using Utilization;

    /// <summary>
    /// This interface defines the operations available on a customer's subscription.
    /// </summary>
    public interface ISubscription : IPartnerComponent<Tuple<string, string>>, IEntityGetOperations<Subscription>, IEntityPatchOperations<Subscription>
    {
        /// <summary>
        /// Gets the current subscription's activation link operations.
        /// </summary>
        ISubscriptionActivationLinkCollection ActivationLinks { get; }

        /// <summary>
        /// Gets the current subscription's add-ons operations.
        /// </summary>
        ISubscriptionAddOnCollection AddOns { get; }

        /// <summary>
        /// Gets the current subscription's conversion operations. These operations will only apply to trial subscriptions.
        /// </summary>
        ISubscriptionConversionCollection Conversions { get; }

        /// <summary>
        /// Gets the current subscription's provisioning status operations.
        /// </summary>
        ISubscriptionProvisioningStatus ProvisioningStatus { get; }

        /// <summary>
        /// Gets the current subscription's registration operations.
        /// </summary>
        ISubscriptionRegistration Registration { get; }

        /// <summary>
        /// Gets the current subscription's registration status operations.
        /// </summary>
        ISubscriptionRegistrationStatus RegistrationStatus { get; }

        /// <summary>
        /// Gets the current subscription's support contact operations.
        /// </summary>
        ISubscriptionSupportContact SupportContact { get; }

        /// <summary>
        /// Gets the current subscription's upgrade operations.
        /// </summary>
        ISubscriptionUpgradeCollection Upgrades { get; }

        /// <summary>
        /// Gets the current subscription's resource usage records operations.
        /// </summary>
        ISubscriptionUsageRecordCollection UsageRecords { get; }

        /// <summary>
        /// Gets the current subscription's usage summary operations.
        /// </summary>
        ISubscriptionUsageSummary UsageSummary { get; }

        /// <summary>
        /// Gets the current subscription's utilization operations.
        /// </summary>
        IUtilizationCollection Utilization { get; }

        /// <summary>
        /// Activates a the subscription.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>The result from the subscription activation.</returns>
        /// <remarks>
        /// This operation is currently available for the integration sandbox, and it is used used to activate a third-party subscriptions.
        /// </remarks>
        Task<SubscriptionActivationResult> ActivateAsync(CancellationToken cancellationToken = default);
    }
}