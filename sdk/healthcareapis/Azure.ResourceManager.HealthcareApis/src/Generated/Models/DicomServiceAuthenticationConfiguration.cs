// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> Authentication configuration information. </summary>
    public partial class DicomServiceAuthenticationConfiguration
    {
        /// <summary> Initializes a new instance of DicomServiceAuthenticationConfiguration. </summary>
        public DicomServiceAuthenticationConfiguration()
        {
            Audiences = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of DicomServiceAuthenticationConfiguration. </summary>
        /// <param name="authority"> The authority url for the service. </param>
        /// <param name="audiences"> The audiences for the service. </param>
        internal DicomServiceAuthenticationConfiguration(string authority, IReadOnlyList<string> audiences)
        {
            Authority = authority;
            Audiences = audiences;
        }

        /// <summary> The authority url for the service. </summary>
        public string Authority { get; }
        /// <summary> The audiences for the service. </summary>
        public IReadOnlyList<string> Audiences { get; }
    }
}
