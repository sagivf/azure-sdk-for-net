// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DistributionConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("distributionType");
            writer.WriteStringValue(DistributionType.ToString());
            writer.WriteEndObject();
        }

        internal static DistributionConfiguration DeserializeDistributionConfiguration(JsonElement element)
        {
            if (element.TryGetProperty("distributionType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Mpi": return Mpi.DeserializeMpi(element);
                    case "PyTorch": return PyTorch.DeserializePyTorch(element);
                    case "TensorFlow": return TensorFlow.DeserializeTensorFlow(element);
                }
            }
            DistributionType distributionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("distributionType"))
                {
                    distributionType = new DistributionType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownDistributionConfiguration(distributionType);
        }
    }
}
