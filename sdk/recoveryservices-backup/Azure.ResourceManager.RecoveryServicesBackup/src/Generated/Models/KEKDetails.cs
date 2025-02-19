// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> KEK is encryption key for BEK. </summary>
    public partial class KEKDetails
    {
        /// <summary> Initializes a new instance of KEKDetails. </summary>
        public KEKDetails()
        {
        }

        /// <summary> Initializes a new instance of KEKDetails. </summary>
        /// <param name="keyUri"> Key is KEK. </param>
        /// <param name="keyVaultId"> Key Vault ID where this Key is stored. </param>
        /// <param name="keyBackupData"> KEK data. </param>
        internal KEKDetails(Uri keyUri, string keyVaultId, string keyBackupData)
        {
            KeyUri = keyUri;
            KeyVaultId = keyVaultId;
            KeyBackupData = keyBackupData;
        }

        /// <summary> Key is KEK. </summary>
        public Uri KeyUri { get; set; }
        /// <summary> Key Vault ID where this Key is stored. </summary>
        public string KeyVaultId { get; set; }
        /// <summary> KEK data. </summary>
        public string KeyBackupData { get; set; }
    }
}
