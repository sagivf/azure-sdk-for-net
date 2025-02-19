// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The result returned from a database check name availability request. </summary>
    public partial class DatabaseCheckNameContent
    {
        /// <summary> Initializes a new instance of DatabaseCheckNameContent. </summary>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> The type of resource, for instance Microsoft.Synapse/workspaces/kustoPools/databases. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DatabaseCheckNameContent(string name, KustoDatabaseResourceType resourceType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            ResourceType = resourceType;
        }

        /// <summary> Resource name. </summary>
        public string Name { get; }
        /// <summary> The type of resource, for instance Microsoft.Synapse/workspaces/kustoPools/databases. </summary>
        public KustoDatabaseResourceType ResourceType { get; }
    }
}
