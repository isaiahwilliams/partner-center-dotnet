// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ValidationRules
{
    using GenericOperations;

    /// <summary>
    /// Encapsulates country validation rules behavior.
    /// </summary>
    public interface ICountryValidationRulesCollection : IPartnerComponent<string>, ICountrySelector<ICountryValidationRules>
    {
    }
}