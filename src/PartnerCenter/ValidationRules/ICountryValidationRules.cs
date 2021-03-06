﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.ValidationRules
{
    using GenericOperations;
    using Models.ValidationRules;

    /// <summary>
    /// Represents the behavior of a specific country validation rules.
    /// </summary>
    public interface ICountryValidationRules : IPartnerComponent<string>, IEntityGetOperations<CountryValidationRules>
    {
    }
}