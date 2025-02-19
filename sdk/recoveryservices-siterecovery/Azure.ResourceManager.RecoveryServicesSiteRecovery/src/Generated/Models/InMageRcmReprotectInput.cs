// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcm specific provider input. </summary>
    public partial class InMageRcmReprotectInput : ReverseReplicationProviderSpecificInput
    {
        /// <summary> Initializes a new instance of InMageRcmReprotectInput. </summary>
        /// <param name="reprotectAgentId"> The reprotect agent Id. </param>
        /// <param name="datastoreName"> The target datastore name. </param>
        /// <param name="logStorageAccountId"> The log storage account ARM Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="reprotectAgentId"/>, <paramref name="datastoreName"/> or <paramref name="logStorageAccountId"/> is null. </exception>
        public InMageRcmReprotectInput(string reprotectAgentId, string datastoreName, string logStorageAccountId)
        {
            if (reprotectAgentId == null)
            {
                throw new ArgumentNullException(nameof(reprotectAgentId));
            }
            if (datastoreName == null)
            {
                throw new ArgumentNullException(nameof(datastoreName));
            }
            if (logStorageAccountId == null)
            {
                throw new ArgumentNullException(nameof(logStorageAccountId));
            }

            ReprotectAgentId = reprotectAgentId;
            DatastoreName = datastoreName;
            LogStorageAccountId = logStorageAccountId;
            InstanceType = "InMageRcm";
        }

        /// <summary> The reprotect agent Id. </summary>
        public string ReprotectAgentId { get; }
        /// <summary> The target datastore name. </summary>
        public string DatastoreName { get; }
        /// <summary> The log storage account ARM Id. </summary>
        public string LogStorageAccountId { get; }
        /// <summary> The Policy Id. </summary>
        public string PolicyId { get; set; }
    }
}
