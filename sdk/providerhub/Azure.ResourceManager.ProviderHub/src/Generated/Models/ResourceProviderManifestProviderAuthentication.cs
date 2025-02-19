// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceProviderManifestProviderAuthentication. </summary>
    internal partial class ResourceProviderManifestProviderAuthentication : ResourceProviderAuthentication
    {
        /// <summary> Initializes a new instance of ResourceProviderManifestProviderAuthentication. </summary>
        /// <param name="allowedAudiences"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedAudiences"/> is null. </exception>
        public ResourceProviderManifestProviderAuthentication(IEnumerable<string> allowedAudiences) : base(allowedAudiences)
        {
            if (allowedAudiences == null)
            {
                throw new ArgumentNullException(nameof(allowedAudiences));
            }
        }

        /// <summary> Initializes a new instance of ResourceProviderManifestProviderAuthentication. </summary>
        /// <param name="allowedAudiences"></param>
        internal ResourceProviderManifestProviderAuthentication(IList<string> allowedAudiences) : base(allowedAudiences)
        {
        }
    }
}
