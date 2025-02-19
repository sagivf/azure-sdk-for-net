// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> A paged list of ExpressRoute Circuit Authorizations. </summary>
    internal partial class ExpressRouteAuthorizationList
    {
        /// <summary> Initializes a new instance of ExpressRouteAuthorizationList. </summary>
        internal ExpressRouteAuthorizationList()
        {
            Value = new ChangeTrackingList<ExpressRouteAuthorizationData>();
        }

        /// <summary> Initializes a new instance of ExpressRouteAuthorizationList. </summary>
        /// <param name="value"> The items on a page. </param>
        /// <param name="nextLink"> URL to get the next page if any. </param>
        internal ExpressRouteAuthorizationList(IReadOnlyList<ExpressRouteAuthorizationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on a page. </summary>
        public IReadOnlyList<ExpressRouteAuthorizationData> Value { get; }
        /// <summary> URL to get the next page if any. </summary>
        public string NextLink { get; }
    }
}
