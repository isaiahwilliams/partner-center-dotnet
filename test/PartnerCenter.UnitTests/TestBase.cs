﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.UnitTests
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading.Tasks;
    using TestFramework;
    using TestFramework.Network;

    /// <summary>
    /// Test base for all partner service tests.
    /// </summary>
    public abstract class TestBase
    {
        /// <summary>
        /// Delegating handler used to intercept partner service client operations.
        /// </summary>
        private readonly static HttpMockHandler httpMockHandler = new HttpMockHandler(HttpMockHandlerMode.Playback);

        /// <summary>
        /// Use the partner operations to perform the test.
        /// </summary>
        /// <param name="test">Encapsulates a test to execute.</param>
        /// <param name="identity">Identity of the test being executed.</param>
        /// <returns>
        /// An instance of the <see cref="Task" /> class that represents the asynchronous operation.
        /// </returns>
        public async Task UsePartnerForAsync(Func<IPartner, Task> test, [CallerMemberName] string identity = null)
        {
            IPartnerCredentials credentials = new TestPartnerCredentials();

            await test(TestPartnerService.CreatePartnerOperations(credentials, httpMockHandler));

            if (httpMockHandler.Mode == HttpMockHandlerMode.Record)
            {
                httpMockHandler.Flush(identity);
            }
        }
    }
}
