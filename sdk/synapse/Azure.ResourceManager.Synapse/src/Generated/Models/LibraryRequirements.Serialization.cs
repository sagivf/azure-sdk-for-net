// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class LibraryRequirements : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content");
                writer.WriteStringValue(Content);
            }
            if (Optional.IsDefined(Filename))
            {
                writer.WritePropertyName("filename");
                writer.WriteStringValue(Filename);
            }
            writer.WriteEndObject();
        }

        internal static LibraryRequirements DeserializeLibraryRequirements(JsonElement element)
        {
            Optional<DateTimeOffset> time = default;
            Optional<string> content = default;
            Optional<string> filename = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("content"))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filename"))
                {
                    filename = property.Value.GetString();
                    continue;
                }
            }
            return new LibraryRequirements(Optional.ToNullable(time), content.Value, filename.Value);
        }
    }
}
