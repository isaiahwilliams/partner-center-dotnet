// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Agreements
{
    using GenericOperations;

    /// <summary>
    /// This interface represents the operations that can be done on agreement templates.
    /// </summary>
    public interface IAgreementTemplateCollection : IPartnerComponent<string>, IEntitySelector<string, IAgreementTemplate>
    {
    }
}
