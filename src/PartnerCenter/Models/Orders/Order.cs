﻿// Copyright (c) Isaiah Williams. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Store.PartnerCenter.Models.Orders
{
    using System;
    using System.Collections.Generic;
    using Offers;

    /// <summary>
    /// An order is the mean of purchasing offers. Offers are represented by line items within the order.
    /// </summary>
    public sealed class Order : ResourceBase
    {
        /// <summary>
        /// Gets or sets the type of billing cycle for the selected offers.
        /// </summary>
        public BillingCycleType BillingCycle { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the order.
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the currency code.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the currency symbol.
        /// </summary>
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the Order line items. Each order line item refers to one offer's purchase data.
        /// </summary>
        public IEnumerable<OrderLineItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets the links corresponding to the order.
        /// </summary>
        public OrderLinks Links { get; set; }

        /// <summary>
        /// Gets or sets the reference customer identifier.
        /// </summary>
        public string ReferenceCustomerId { get; set; }

        /// <summary>
        /// Gets or sets the order status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets the total price for the order.
        /// </summary>
        /// <remarks>
        /// This information will not be returned unless explicitly requested. 
        /// </remarks>
        public double? TotalPrice { get; private set; }

        /// <summary>
        /// Gets the transaction type.
        /// </summary>
        public string TransactionType { get; private set; }
    }
}