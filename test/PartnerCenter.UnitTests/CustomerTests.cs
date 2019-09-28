// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.UnitTests
{
    using System.Threading.Tasks;
    using Models.Customers;
    using VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit tests for operations involving customers.
    /// </summary>
    [TestClass]
    public class CustomerTests : TestBase
    {
        /// <summary>
        /// Test that verifies the get customer qualification operation.
        /// </summary>
        /// <returns>An instance of the <see cref="Task" /> class that represents the asynchronous operation.</returns>
        // [TestMethod]
        public async Task GetCustomerQualification()
        {
            await UsePartnerForAsync(async partnerOperations =>
            {
                CustomerQualification qualification = await partnerOperations
                    .Customers[TestConstants.CustomerId]
                    .Qualification.GetAsync()
                    .ConfigureAwait(false);

                Assert.AreEqual(CustomerQualification.None, qualification);
            }).ConfigureAwait(false);
        }
    }
}