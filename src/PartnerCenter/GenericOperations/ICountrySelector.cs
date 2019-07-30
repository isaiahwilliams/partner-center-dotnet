// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.GenericOperations
{
    /// <summary>
    /// Returns operations interfaces based on the given country.
    /// </summary>
    /// <typeparam name="TOperations">The type of the operations to return.</typeparam>
    public interface ICountrySelector<out TOperations>
    {
        /// <summary>
        /// Customizes operations based on the given country.
        /// </summary>
        /// <param name="country">The country to be used by the returned operations.</param>
        /// <returns>An operations interface customized for the provided country.</returns>
        TOperations ByCountry(string country);
    }
}