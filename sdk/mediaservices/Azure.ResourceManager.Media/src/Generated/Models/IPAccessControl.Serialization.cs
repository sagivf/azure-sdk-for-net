// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class IPAccessControl : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedIPs))
            {
                writer.WritePropertyName("allow");
                writer.WriteStartArray();
                foreach (var item in AllowedIPs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IPAccessControl DeserializeIPAccessControl(JsonElement element)
        {
            Optional<IList<IPRange>> allow = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allow"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<IPRange> array = new List<IPRange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IPRange.DeserializeIPRange(item));
                    }
                    allow = array;
                    continue;
                }
            }
            return new IPAccessControl(Optional.ToList(allow));
        }
    }
}
