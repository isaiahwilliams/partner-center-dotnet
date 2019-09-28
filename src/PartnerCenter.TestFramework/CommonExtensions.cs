// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.TestFramework
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains common extension methods.
    /// </summary>
    internal static class CommonExtensions
    {
        /// <summary>
        /// Perform an action on each element of a sequence.
        /// </summary>
        /// <typeparam name="T">Type of elements in the sequence.</typeparam>
        /// <param name="sequence">The sequence.</param>
        /// <param name="action">The action to perform.</param>
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (T element in sequence)
            {
                action(element);
            }
        }
    }
}