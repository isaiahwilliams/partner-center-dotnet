// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.UnitTests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Models;
    using Models.Subscriptions;
    using VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit tests for operations involving subscriptions.
    /// </summary>
    [TestClass]
    public class SubscriptionTests : TestBase
    {
        /// <summary>
        /// Test that verifies the get subscription add on operation.
        /// </summary>
        /// <returns>An instance of the <see cref="Task" /> class that represents the asynchronous operation.</returns>
        // [TestMethod]
        public async Task GetSubscriptionAddOns()
        {
            await UsePartnerForAsync(async partnerOperations =>
            {
                ResourceCollection<Subscription> addons = await partnerOperations
                    .Customers[TestConstants.CustomerId]
                    .Subscriptions[TestConstants.SubscriptionId].AddOns.GetAsync().ConfigureAwait(false);

                Assert.IsNotNull(addons);
                Assert.IsNotNull(addons.Attributes);
                Assert.IsNotNull(addons.Items);
                Assert.IsNotNull(addons.Links);

                Assert.IsTrue(addons.Items.Any());
                Assert.IsTrue(addons.TotalCount > 0);
            }).ConfigureAwait(false);
        }
    }
}