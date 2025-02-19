// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventHubs.Models
{
    internal static partial class EventHubEntityStatusExtensions
    {
        public static string ToSerialString(this EventHubEntityStatus value) => value switch
        {
            EventHubEntityStatus.Unknown => "Unknown",
            EventHubEntityStatus.Active => "Active",
            EventHubEntityStatus.Disabled => "Disabled",
            EventHubEntityStatus.Restoring => "Restoring",
            EventHubEntityStatus.SendDisabled => "SendDisabled",
            EventHubEntityStatus.ReceiveDisabled => "ReceiveDisabled",
            EventHubEntityStatus.Creating => "Creating",
            EventHubEntityStatus.Deleting => "Deleting",
            EventHubEntityStatus.Renaming => "Renaming",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EventHubEntityStatus value.")
        };

        public static EventHubEntityStatus ToEventHubEntityStatus(this string value)
        {
            if (string.Equals(value, "Unknown", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Unknown;
            if (string.Equals(value, "Active", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Active;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Disabled;
            if (string.Equals(value, "Restoring", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Restoring;
            if (string.Equals(value, "SendDisabled", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.SendDisabled;
            if (string.Equals(value, "ReceiveDisabled", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.ReceiveDisabled;
            if (string.Equals(value, "Creating", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Creating;
            if (string.Equals(value, "Deleting", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Deleting;
            if (string.Equals(value, "Renaming", StringComparison.InvariantCultureIgnoreCase)) return EventHubEntityStatus.Renaming;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EventHubEntityStatus value.");
        }
    }
}
