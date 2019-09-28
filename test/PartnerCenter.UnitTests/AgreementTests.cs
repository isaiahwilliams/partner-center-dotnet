// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.UnitTests
{
    using System.Linq;
    using System.Threading.Tasks;
    using Models;
    using Models.Agreements;
    using VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit tests for operations involving agreements.
    /// </summary>
    [TestClass]
    public class AgreementTests : TestBase
    {
        /// <summary>
        /// Test that verifies the get agreement details operation.
        /// </summary>
        /// <returns>An instance of the <see cref="Task" /> class that represents the asynchronous operation.</returns>
        [TestMethod]
        public async Task GetAgreementDetails()
        {
            await UsePartnerForAsync(async partnerOperations =>
            {
                ResourceCollection<AgreementMetaData> details = await partnerOperations.AgreementDetails.GetAsync().ConfigureAwait(false);

                Assert.IsNotNull(details);
                Assert.IsNotNull(details.Items);
                Assert.IsTrue(details.Items.Any());
            }).ConfigureAwait(false);
        }
    }
}