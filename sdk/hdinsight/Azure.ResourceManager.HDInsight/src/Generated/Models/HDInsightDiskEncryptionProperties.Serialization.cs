// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightDiskEncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VaultUri))
            {
                writer.WritePropertyName("vaultUri");
                writer.WriteStringValue(VaultUri.AbsoluteUri);
            }
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName");
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion");
                writer.WriteStringValue(KeyVersion);
            }
            if (Optional.IsDefined(EncryptionAlgorithm))
            {
                if (EncryptionAlgorithm != null)
                {
                    writer.WritePropertyName("encryptionAlgorithm");
                    writer.WriteStringValue(EncryptionAlgorithm.Value.ToString());
                }
                else
                {
                    writer.WriteNull("encryptionAlgorithm");
                }
            }
            if (Optional.IsDefined(MsiResourceId))
            {
                if (MsiResourceId != null)
                {
                    writer.WritePropertyName("msiResourceId");
                    writer.WriteStringValue(MsiResourceId);
                }
                else
                {
                    writer.WriteNull("msiResourceId");
                }
            }
            if (Optional.IsDefined(IsEncryptionAtHostEnabled))
            {
                writer.WritePropertyName("encryptionAtHost");
                writer.WriteBooleanValue(IsEncryptionAtHostEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightDiskEncryptionProperties DeserializeHDInsightDiskEncryptionProperties(JsonElement element)
        {
            Optional<Uri> vaultUri = default;
            Optional<string> keyName = default;
            Optional<string> keyVersion = default;
            Optional<JsonWebKeyEncryptionAlgorithm?> encryptionAlgorithm = default;
            Optional<ResourceIdentifier> msiResourceId = default;
            Optional<bool> encryptionAtHost = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vaultUri"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        vaultUri = null;
                        continue;
                    }
                    vaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyName"))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionAlgorithm"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionAlgorithm = null;
                        continue;
                    }
                    encryptionAlgorithm = new JsonWebKeyEncryptionAlgorithm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("msiResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        msiResourceId = null;
                        continue;
                    }
                    msiResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryptionAtHost"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryptionAtHost = property.Value.GetBoolean();
                    continue;
                }
            }
            return new HDInsightDiskEncryptionProperties(vaultUri.Value, keyName.Value, keyVersion.Value, Optional.ToNullable(encryptionAlgorithm), msiResourceId.Value, Optional.ToNullable(encryptionAtHost));
        }
    }
}
