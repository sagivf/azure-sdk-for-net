// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The type of IoT Security recommendation. </summary>
    public readonly partial struct RecommendationType : IEquatable<RecommendationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RecommendationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RecommendationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string IotAcrAuthenticationValue = "IoT_ACRAuthentication";
        private const string IotAgentSendsUnutilizedMessagesValue = "IoT_AgentSendsUnutilizedMessages";
        private const string IotBaselineValue = "IoT_Baseline";
        private const string IotEdgeHubMemOptimizeValue = "IoT_EdgeHubMemOptimize";
        private const string IotEdgeLoggingOptionsValue = "IoT_EdgeLoggingOptions";
        private const string IotInconsistentModuleSettingsValue = "IoT_InconsistentModuleSettings";
        private const string IotInstallAgentValue = "IoT_InstallAgent";
        private const string IotIPFilterDenyAllValue = "IoT_IPFilter_DenyAll";
        private const string IotIPFilterPermissiveRuleValue = "IoT_IPFilter_PermissiveRule";
        private const string IotOpenPortsValue = "IoT_OpenPorts";
        private const string IotPermissiveFirewallPolicyValue = "IoT_PermissiveFirewallPolicy";
        private const string IotPermissiveInputFirewallRulesValue = "IoT_PermissiveInputFirewallRules";
        private const string IotPermissiveOutputFirewallRulesValue = "IoT_PermissiveOutputFirewallRules";
        private const string IotPrivilegedDockerOptionsValue = "IoT_PrivilegedDockerOptions";
        private const string IotSharedCredentialsValue = "IoT_SharedCredentials";
        private const string IotVulnerableTlsCipherSuiteValue = "IoT_VulnerableTLSCipherSuite";

        /// <summary> Authentication schema used for pull an edge module from an ACR repository does not use Service Principal Authentication. </summary>
        public static RecommendationType IotAcrAuthentication { get; } = new RecommendationType(IotAcrAuthenticationValue);
        /// <summary> IoT agent message size capacity is currently underutilized, causing an increase in the number of sent messages. Adjust message intervals for better utilization. </summary>
        public static RecommendationType IotAgentSendsUnutilizedMessages { get; } = new RecommendationType(IotAgentSendsUnutilizedMessagesValue);
        /// <summary> Identified security related system configuration issues. </summary>
        public static RecommendationType IotBaseline { get; } = new RecommendationType(IotBaselineValue);
        /// <summary> You can optimize Edge Hub memory usage by turning off protocol heads for any protocols not used by Edge modules in your solution. </summary>
        public static RecommendationType IotEdgeHubMemOptimize { get; } = new RecommendationType(IotEdgeHubMemOptimizeValue);
        /// <summary> Logging is disabled for this edge module. </summary>
        public static RecommendationType IotEdgeLoggingOptions { get; } = new RecommendationType(IotEdgeLoggingOptionsValue);
        /// <summary> A minority within a device security group has inconsistent Edge Module settings with the rest of their group. </summary>
        public static RecommendationType IotInconsistentModuleSettings { get; } = new RecommendationType(IotInconsistentModuleSettingsValue);
        /// <summary> Install the Azure Security of Things Agent. </summary>
        public static RecommendationType IotInstallAgent { get; } = new RecommendationType(IotInstallAgentValue);
        /// <summary> IP Filter Configuration should have rules defined for allowed traffic and should deny all other traffic by default. </summary>
        public static RecommendationType IotIPFilterDenyAll { get; } = new RecommendationType(IotIPFilterDenyAllValue);
        /// <summary> An Allow IP Filter rules source IP range is too large. Overly permissive rules might expose your IoT hub to malicious intenders. </summary>
        public static RecommendationType IotIPFilterPermissiveRule { get; } = new RecommendationType(IotIPFilterPermissiveRuleValue);
        /// <summary> A listening endpoint was found on the device. </summary>
        public static RecommendationType IotOpenPorts { get; } = new RecommendationType(IotOpenPortsValue);
        /// <summary> An Allowed firewall policy was found (INPUT/OUTPUT). The policy should Deny all traffic by default and define rules to allow necessary communication to/from the device. </summary>
        public static RecommendationType IotPermissiveFirewallPolicy { get; } = new RecommendationType(IotPermissiveFirewallPolicyValue);
        /// <summary> A rule in the firewall has been found that contains a permissive pattern for a wide range of IP addresses or Ports. </summary>
        public static RecommendationType IotPermissiveInputFirewallRules { get; } = new RecommendationType(IotPermissiveInputFirewallRulesValue);
        /// <summary> A rule in the firewall has been found that contains a permissive pattern for a wide range of IP addresses or Ports. </summary>
        public static RecommendationType IotPermissiveOutputFirewallRules { get; } = new RecommendationType(IotPermissiveOutputFirewallRulesValue);
        /// <summary> Edge module is configured to run in privileged mode, with extensive Linux capabilities or with host-level network access (send/receive data to host machine). </summary>
        public static RecommendationType IotPrivilegedDockerOptions { get; } = new RecommendationType(IotPrivilegedDockerOptionsValue);
        /// <summary> Same authentication credentials to the IoT Hub used by multiple devices. This could indicate an illegitimate device impersonating a legitimate device. It also exposes the risk of device impersonation by an attacker. </summary>
        public static RecommendationType IotSharedCredentials { get; } = new RecommendationType(IotSharedCredentialsValue);
        /// <summary> Insecure TLS configurations detected. Immediate upgrade recommended. </summary>
        public static RecommendationType IotVulnerableTlsCipherSuite { get; } = new RecommendationType(IotVulnerableTlsCipherSuiteValue);
        /// <summary> Determines if two <see cref="RecommendationType"/> values are the same. </summary>
        public static bool operator ==(RecommendationType left, RecommendationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RecommendationType"/> values are not the same. </summary>
        public static bool operator !=(RecommendationType left, RecommendationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RecommendationType"/>. </summary>
        public static implicit operator RecommendationType(string value) => new RecommendationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RecommendationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RecommendationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
