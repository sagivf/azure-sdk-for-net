// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Deployment along with OS Configuration. </summary>
    public partial class DeploymentWithOSConfiguration : SapConfiguration
    {
        /// <summary> Initializes a new instance of DeploymentWithOSConfiguration. </summary>
        public DeploymentWithOSConfiguration()
        {
            ConfigurationType = SapConfigurationType.DeploymentWithOSConfig;
        }

        /// <summary> Initializes a new instance of DeploymentWithOSConfiguration. </summary>
        /// <param name="configurationType"> The configuration Type. </param>
        /// <param name="appLocation"> The geo-location where the SAP system is to be created. </param>
        /// <param name="infrastructureConfiguration">
        /// The infrastructure configuration.
        /// Please note <see cref="InfrastructureConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SingleServerConfiguration"/> and <see cref="ThreeTierConfiguration"/>.
        /// </param>
        /// <param name="softwareConfiguration">
        /// The software configuration.
        /// Please note <see cref="SoftwareConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SapInstallWithoutOSConfigSoftwareConfiguration"/> and <see cref="ServiceInitiatedSoftwareConfiguration"/>.
        /// </param>
        /// <param name="osSapConfiguration"> The OS and SAP configuration. </param>
        internal DeploymentWithOSConfiguration(SapConfigurationType configurationType, AzureLocation? appLocation, InfrastructureConfiguration infrastructureConfiguration, SoftwareConfiguration softwareConfiguration, OSSapConfiguration osSapConfiguration) : base(configurationType)
        {
            AppLocation = appLocation;
            InfrastructureConfiguration = infrastructureConfiguration;
            SoftwareConfiguration = softwareConfiguration;
            OSSapConfiguration = osSapConfiguration;
            ConfigurationType = configurationType;
        }

        /// <summary> The geo-location where the SAP system is to be created. </summary>
        public AzureLocation? AppLocation { get; set; }
        /// <summary>
        /// The infrastructure configuration.
        /// Please note <see cref="InfrastructureConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SingleServerConfiguration"/> and <see cref="ThreeTierConfiguration"/>.
        /// </summary>
        public InfrastructureConfiguration InfrastructureConfiguration { get; set; }
        /// <summary>
        /// The software configuration.
        /// Please note <see cref="SoftwareConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SapInstallWithoutOSConfigSoftwareConfiguration"/> and <see cref="ServiceInitiatedSoftwareConfiguration"/>.
        /// </summary>
        public SoftwareConfiguration SoftwareConfiguration { get; set; }
        /// <summary> The OS and SAP configuration. </summary>
        public OSSapConfiguration OSSapConfiguration { get; set; }
    }
}
