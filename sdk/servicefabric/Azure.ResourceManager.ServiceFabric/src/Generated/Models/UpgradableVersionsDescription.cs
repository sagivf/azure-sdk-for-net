// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The UpgradableVersionsDescription. </summary>
    public partial class UpgradableVersionsDescription
    {
        /// <summary> Initializes a new instance of UpgradableVersionsDescription. </summary>
        /// <param name="targetVersion"> The target code version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetVersion"/> is null. </exception>
        public UpgradableVersionsDescription(string targetVersion)
        {
            if (targetVersion == null)
            {
                throw new ArgumentNullException(nameof(targetVersion));
            }

            TargetVersion = targetVersion;
        }

        /// <summary> The target code version. </summary>
        public string TargetVersion { get; }
    }
}
