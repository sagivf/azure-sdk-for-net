// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.ManagedNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary> A class representing the ManagedNetworkPeeringPolicy data model. </summary>
    public partial class ManagedNetworkPeeringPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of ManagedNetworkPeeringPolicyData. </summary>
        public ManagedNetworkPeeringPolicyData()
        {
        }

        /// <summary> Initializes a new instance of ManagedNetworkPeeringPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Gets or sets the properties of a Managed Network Policy. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal ManagedNetworkPeeringPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedNetworkPeeringPolicyProperties properties, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
        }

        /// <summary> Gets or sets the properties of a Managed Network Policy. </summary>
        public ManagedNetworkPeeringPolicyProperties Properties { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; set; }
    }
}
