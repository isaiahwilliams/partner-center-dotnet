// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Resolvers
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Reflection;

    /// <summary>
    /// Used by <see cref="JsonSerializer" /> to resolve a <see cref="JsonContract" /> for a given type.
    /// </summary>
    public class PrivateContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// Creates a <see cref="JsonProperty" /> for the given <see cref="MemberInfo" />.
        /// </summary>
        /// <param name="member">The member for which the <see cref="JsonProperty" /> is created.</param>
        /// <param name="memberSerialization">The member's parent <see cref="MemberSerialization" />.</param>
        /// <returns> A created <see cref="JsonProperty" /> for the given <see cref="MemberInfo" />.</returns>
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (!property.Writable)
            {
                property.Writable = ((PropertyInfo)member).GetSetMethod(true) != null;
            }

            return property;
        }
    }
}