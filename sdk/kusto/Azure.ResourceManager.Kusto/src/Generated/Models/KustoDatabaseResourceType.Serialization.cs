// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Kusto.Models
{
    internal static partial class KustoDatabaseResourceTypeExtensions
    {
        public static string ToSerialString(this KustoDatabaseResourceType value) => value switch
        {
            KustoDatabaseResourceType.MicrosoftKustoClustersDatabases => "Microsoft.Kusto/clusters/databases",
            KustoDatabaseResourceType.MicrosoftKustoClustersAttachedDatabaseConfigurations => "Microsoft.Kusto/clusters/attachedDatabaseConfigurations",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KustoDatabaseResourceType value.")
        };

        public static KustoDatabaseResourceType ToKustoDatabaseResourceType(this string value)
        {
            if (string.Equals(value, "Microsoft.Kusto/clusters/databases", StringComparison.InvariantCultureIgnoreCase)) return KustoDatabaseResourceType.MicrosoftKustoClustersDatabases;
            if (string.Equals(value, "Microsoft.Kusto/clusters/attachedDatabaseConfigurations", StringComparison.InvariantCultureIgnoreCase)) return KustoDatabaseResourceType.MicrosoftKustoClustersAttachedDatabaseConfigurations;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KustoDatabaseResourceType value.");
        }
    }
}
