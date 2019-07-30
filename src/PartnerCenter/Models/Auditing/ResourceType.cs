// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Auditing
{
    using JsonConverters;
    using Newtonsoft.Json;

    /// <summary>
    /// Enumeration to represent type of resource being performed
    /// </summary>
    [JsonConverter(typeof(EnumJsonConverter))]
    public enum ResourceType
    {
        /// <summary>
        /// The undefined
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// Customer resource
        /// </summary>
        Customer = 1,

        /// <summary>
        /// Customer User
        /// </summary>
        CustomerUser = 2,

        /// <summary>
        /// Order resource
        /// </summary>
        Order = 3,

        /// <summary>
        /// Subscription resource
        /// </summary>
        Subscription = 4,

        /// <summary>
        /// License resource
        /// </summary>
        License = 5,

        /// <summary>
        /// Third party add-on resource
        /// </summary>
        ThirdPartyAddOn = 6,

        /// <summary>
        /// MPN association resource
        /// </summary>
        MpnAssociation = 7,

        /// <summary>
        /// Transfer resource
        /// </summary>
        Transfer = 8,

        /// <summary>
        /// Application resource
        /// </summary>
        Application = 9,

        /// <summary>
        /// Application Credential resource
        /// </summary>
        ApplicationCredential = 10,

        /// <summary>
        /// Partner User resource
        /// </summary>
        PartnerUser = 11,

        /// <summary>
        /// Partner Relationship resource
        /// </summary>
        PartnerRelationship = 12,

        /// <summary>
        /// Partner Referral resource
        /// </summary>
        Referral = 13,

        /// <summary>
        /// Software Key resource
        /// </summary>
        SoftwareKey = 14,

        /// <summary>
        /// Software Download Link resource
        /// </summary>
        SoftwareDownloadLink = 15,

        /// <summary>
        /// Credit Limit resource
        /// </summary>
        CreditLimit = 16,

        /// <summary>
        /// Invoice resource
        /// </summary>
        Invoice = 17,

        /// <summary>
        /// Agreement resource
        /// </summary>
        Agreement = 18,

        /// <summary>
        /// Partner to customer relationship resource
        /// </summary>
        PartnerCustomerRelationship = 19
    }
}