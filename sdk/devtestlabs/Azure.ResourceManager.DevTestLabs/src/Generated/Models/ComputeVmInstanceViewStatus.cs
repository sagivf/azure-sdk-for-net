// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Status information about a virtual machine. </summary>
    public partial class ComputeVmInstanceViewStatus
    {
        /// <summary> Initializes a new instance of ComputeVmInstanceViewStatus. </summary>
        internal ComputeVmInstanceViewStatus()
        {
        }

        /// <summary> Initializes a new instance of ComputeVmInstanceViewStatus. </summary>
        /// <param name="code"> Gets the status Code. </param>
        /// <param name="displayStatus"> Gets the short localizable label for the status. </param>
        /// <param name="message"> Gets the message associated with the status. </param>
        internal ComputeVmInstanceViewStatus(string code, string displayStatus, string message)
        {
            Code = code;
            DisplayStatus = displayStatus;
            Message = message;
        }

        /// <summary> Gets the status Code. </summary>
        public string Code { get; }
        /// <summary> Gets the short localizable label for the status. </summary>
        public string DisplayStatus { get; }
        /// <summary> Gets the message associated with the status. </summary>
        public string Message { get; }
    }
}
