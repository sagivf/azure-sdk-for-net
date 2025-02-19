// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class TriggerDataMoveContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sourceResourceId");
            writer.WriteStringValue(SourceResourceId);
            writer.WritePropertyName("sourceRegion");
            writer.WriteStringValue(SourceRegion);
            writer.WritePropertyName("dataMoveLevel");
            writer.WriteStringValue(DataMoveLevel.ToString());
            writer.WritePropertyName("correlationId");
            writer.WriteStringValue(CorrelationId);
            if (Optional.IsCollectionDefined(SourceContainerArmIds))
            {
                writer.WritePropertyName("sourceContainerArmIds");
                writer.WriteStartArray();
                foreach (var item in SourceContainerArmIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PauseGC))
            {
                writer.WritePropertyName("pauseGC");
                writer.WriteBooleanValue(PauseGC.Value);
            }
            writer.WriteEndObject();
        }
    }
}
