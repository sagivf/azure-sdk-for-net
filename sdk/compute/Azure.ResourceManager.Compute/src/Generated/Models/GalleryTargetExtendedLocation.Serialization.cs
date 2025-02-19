// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GalleryTargetExtendedLocation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation");
                writer.WriteObjectValue(ExtendedLocation);
            }
            if (Optional.IsDefined(ExtendedLocationReplicaCount))
            {
                writer.WritePropertyName("extendedLocationReplicaCount");
                writer.WriteNumberValue(ExtendedLocationReplicaCount.Value);
            }
            if (Optional.IsDefined(StorageAccountType))
            {
                writer.WritePropertyName("storageAccountType");
                writer.WriteStringValue(StorageAccountType.Value.ToString());
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            writer.WriteEndObject();
        }

        internal static GalleryTargetExtendedLocation DeserializeGalleryTargetExtendedLocation(JsonElement element)
        {
            Optional<string> name = default;
            Optional<GalleryExtendedLocation> extendedLocation = default;
            Optional<int> extendedLocationReplicaCount = default;
            Optional<ImageStorageAccountType> storageAccountType = default;
            Optional<EncryptionImages> encryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocation = GalleryExtendedLocation.DeserializeGalleryExtendedLocation(property.Value);
                    continue;
                }
                if (property.NameEquals("extendedLocationReplicaCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    extendedLocationReplicaCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    storageAccountType = new ImageStorageAccountType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("encryption"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    encryption = EncryptionImages.DeserializeEncryptionImages(property.Value);
                    continue;
                }
            }
            return new GalleryTargetExtendedLocation(name.Value, extendedLocation.Value, Optional.ToNullable(extendedLocationReplicaCount), Optional.ToNullable(storageAccountType), encryption.Value);
        }
    }
}
