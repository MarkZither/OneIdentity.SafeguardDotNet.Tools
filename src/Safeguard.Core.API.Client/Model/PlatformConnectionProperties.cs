using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Default session feature settings for this platform
  /// </summary>
  [DataContract]
  public class PlatformConnectionProperties {
    /// <summary>
    /// The default port to use for connections (Read-only)
    /// </summary>
    /// <value>The default port to use for connections (Read-only)</value>
    [DataMember(Name="DefaultPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultPort")]
    public int? DefaultPort { get; set; }

    /// <summary>
    /// The default port to use for connections when UseSslEncryption is enabled (Read-only)
    /// </summary>
    /// <value>The default port to use for connections when UseSslEncryption is enabled (Read-only)</value>
    [DataMember(Name="DefaultSslPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSslPort")]
    public int? DefaultSslPort { get; set; }

    /// <summary>
    /// Can the end user specify a port other than the default?  Valid for all but Windows, Windows Active Directory, Windows Desktop, and SAP (Read-only)
    /// </summary>
    /// <value>Can the end user specify a port other than the default?  Valid for all but Windows, Windows Active Directory, Windows Desktop, and SAP (Read-only)</value>
    [DataMember(Name="AllowCustomPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowCustomPort")]
    public bool? AllowCustomPort { get; set; }

    /// <summary>
    /// Whether platform supports standard connection timeout parameter (Read-only)
    /// </summary>
    /// <value>Whether platform supports standard connection timeout parameter (Read-only)</value>
    [DataMember(Name="SupportsTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsTimeout")]
    public bool? SupportsTimeout { get; set; }

    /// <summary>
    /// Whether a service account can login using a password on this platform (Read-only)
    /// </summary>
    /// <value>Whether a service account can login using a password on this platform (Read-only)</value>
    [DataMember(Name="SupportsPasswordAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsPasswordAuthentication")]
    public bool? SupportsPasswordAuthentication { get; set; }

    /// <summary>
    /// Whether a service account can login using an SSH key (Read-only)
    /// </summary>
    /// <value>Whether a service account can login using an SSH key (Read-only)</value>
    [DataMember(Name="SupportsSshKeyAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSshKeyAuthentication")]
    public bool? SupportsSshKeyAuthentication { get; set; }

    /// <summary>
    /// Whether a service account can login using an account on the hosted server with a password (Read-only)
    /// </summary>
    /// <value>Whether a service account can login using an account on the hosted server with a password (Read-only)</value>
    [DataMember(Name="SupportsLocalhostPasswordAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsLocalhostPasswordAuthentication")]
    public bool? SupportsLocalhostPasswordAuthentication { get; set; }

    /// <summary>
    /// Whether a service account can login using an account from a directory server with a password (Read-only)
    /// </summary>
    /// <value>Whether a service account can login using an account from a directory server with a password (Read-only)</value>
    [DataMember(Name="SupportsDirectoryPasswordAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsDirectoryPasswordAuthentication")]
    public bool? SupportsDirectoryPasswordAuthentication { get; set; }

    /// <summary>
    /// Whether this platform requires access key credentials
    /// </summary>
    /// <value>Whether this platform requires access key credentials</value>
    [DataMember(Name="SupportsAccessKeyAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsAccessKeyAuthentication")]
    public bool? SupportsAccessKeyAuthentication { get; set; }

    /// <summary>
    /// Whether this platform requires the current account password for check/change
    /// </summary>
    /// <value>Whether this platform requires the current account password for check/change</value>
    [DataMember(Name="SupportsAccountPasswordAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsAccountPasswordAuthentication")]
    public bool? SupportsAccountPasswordAuthentication { get; set; }

    /// <summary>
    /// Whether this platform can use the starling join credential for authentication
    /// </summary>
    /// <value>Whether this platform can use the starling join credential for authentication</value>
    [DataMember(Name="SupportsStarlingConnectAuthentication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsStarlingConnectAuthentication")]
    public bool? SupportsStarlingConnectAuthentication { get; set; }

    /// <summary>
    /// Whether or not the platform supports delegation of commands (e.g. sudo.) The command is used to preface  commands requiring privileged access on the asset. Note that this must be non-interactive.  Valid for most unix-compatible platforms (Read-only)
    /// </summary>
    /// <value>Whether or not the platform supports delegation of commands (e.g. sudo.) The command is used to preface  commands requiring privileged access on the asset. Note that this must be non-interactive.  Valid for most unix-compatible platforms (Read-only)</value>
    [DataMember(Name="SupportsPrivilegeElevationCommand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsPrivilegeElevationCommand")]
    public bool? SupportsPrivilegeElevationCommand { get; set; }

    /// <summary>
    /// Whether the platform supports encryption of telnet data
    /// </summary>
    /// <value>Whether the platform supports encryption of telnet data</value>
    [DataMember(Name="SupportsSslEncryption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSslEncryption")]
    public bool? SupportsSslEncryption { get; set; }

    /// <summary>
    /// Whether the platform supports assigning a workstation ID to the telnet session  Valid for AS/400 platforms (Read-only)
    /// </summary>
    /// <value>Whether the platform supports assigning a workstation ID to the telnet session  Valid for AS/400 platforms (Read-only)</value>
    [DataMember(Name="SupportsWorkstationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsWorkstationId")]
    public bool? SupportsWorkstationId { get; set; }

    /// <summary>
    /// Whether this platform uses SSH to connect to the target machine
    /// </summary>
    /// <value>Whether this platform uses SSH to connect to the target machine</value>
    [DataMember(Name="SupportsSshTransport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSshTransport")]
    public bool? SupportsSshTransport { get; set; }

    /// <summary>
    /// Cisco routers support an extra password to enable password changes
    /// </summary>
    /// <value>Cisco routers support an extra password to enable password changes</value>
    [DataMember(Name="SupportsEnablePassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsEnablePassword")]
    public bool? SupportsEnablePassword { get; set; }

    /// <summary>
    /// Whether this ODBC platform supports an Instance name to identify the target
    /// </summary>
    /// <value>Whether this ODBC platform supports an Instance name to identify the target</value>
    [DataMember(Name="SupportsInstance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsInstance")]
    public bool? SupportsInstance { get; set; }

    /// <summary>
    /// Whether this ODBC platform supports a Service name to identify the target
    /// </summary>
    /// <value>Whether this ODBC platform supports a Service name to identify the target</value>
    [DataMember(Name="SupportsServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsServiceName")]
    public bool? SupportsServiceName { get; set; }

    /// <summary>
    /// Whether this platform supports verification of the SSL certificate
    /// </summary>
    /// <value>Whether this platform supports verification of the SSL certificate</value>
    [DataMember(Name="SupportsSslCertificateVerification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSslCertificateVerification")]
    public bool? SupportsSslCertificateVerification { get; set; }

    /// <summary>
    /// Whether this platform uses a nominated SSL CA certificate
    /// </summary>
    /// <value>Whether this platform uses a nominated SSL CA certificate</value>
    [DataMember(Name="SupportsSslThumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSslThumbprint")]
    public bool? SupportsSslThumbprint { get; set; }

    /// <summary>
    /// Whether the platform requires a client ID to be specified  Valid for SAP platforms (Read-only)
    /// </summary>
    /// <value>Whether the platform requires a client ID to be specified  Valid for SAP platforms (Read-only)</value>
    [DataMember(Name="SupportsClientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsClientId")]
    public bool? SupportsClientId { get; set; }

    /// <summary>
    /// Whether a distinguished name is required for accounts  Valid for LDAP-based platforms (Read-only)
    /// </summary>
    /// <value>Whether a distinguished name is required for accounts  Valid for LDAP-based platforms (Read-only)</value>
    [DataMember(Name="RequiresDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiresDistinguishedName")]
    public bool? RequiresDistinguishedName { get; set; }

    /// <summary>
    /// Whether this platform supports 'as privileges' property (Oracle only)
    /// </summary>
    /// <value>Whether this platform supports 'as privileges' property (Oracle only)</value>
    [DataMember(Name="SupportsOraclePrivileges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsOraclePrivileges")]
    public bool? SupportsOraclePrivileges { get; set; }

    /// <summary>
    /// Whether this platform supports Tacacs Secret (Cisco ISE only)
    /// </summary>
    /// <value>Whether this platform supports Tacacs Secret (Cisco ISE only)</value>
    [DataMember(Name="SupportsTacacsSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsTacacsSecret")]
    public bool? SupportsTacacsSecret { get; set; }

    /// <summary>
    /// Set to true if this platform is a directory that supports LDAP (read-only)
    /// </summary>
    /// <value>Set to true if this platform is a directory that supports LDAP (read-only)</value>
    [DataMember(Name="SupportsLdap", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsLdap")]
    public bool? SupportsLdap { get; set; }

    /// <summary>
    /// Set to true if this platform is a directory that supports directory synchronization (read-only)
    /// </summary>
    /// <value>Set to true if this platform is a directory that supports directory synchronization (read-only)</value>
    [DataMember(Name="SupportsDirectorySync", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsDirectorySync")]
    public bool? SupportsDirectorySync { get; set; }

    /// <summary>
    /// Set to true if this platform is a directory that supports asset discovery (read-only)
    /// </summary>
    /// <value>Set to true if this platform is a directory that supports asset discovery (read-only)</value>
    [DataMember(Name="SupportsDirectoryAssetDiscovery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsDirectoryAssetDiscovery")]
    public bool? SupportsDirectoryAssetDiscovery { get; set; }

    /// <summary>
    /// Whether named pipes or TcpIp is used for service account connection to the platform  Valid for Sql Server platforms
    /// </summary>
    /// <value>Whether named pipes or TcpIp is used for service account connection to the platform  Valid for Sql Server platforms</value>
    [DataMember(Name="SupportsNamedPipeForServiceAccountConnection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsNamedPipeForServiceAccountConnection")]
    public bool? SupportsNamedPipeForServiceAccountConnection { get; set; }

    /// <summary>
    /// Whether to use the profile's next change date as the interval on a Top Secret mainframe
    /// </summary>
    /// <value>Whether to use the profile's next change date as the interval on a Top Secret mainframe</value>
    [DataMember(Name="SupportsTopSecretInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsTopSecretInterval")]
    public bool? SupportsTopSecretInterval { get; set; }

    /// <summary>
    /// Whether this platform supports a privileged account that can be managed, but cannot be used as a service account  Valid for Checkpoint platforms
    /// </summary>
    /// <value>Whether this platform supports a privileged account that can be managed, but cannot be used as a service account  Valid for Checkpoint platforms</value>
    [DataMember(Name="SupportsPrivilegedAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsPrivilegedAccount")]
    public bool? SupportsPrivilegedAccount { get; set; }

    /// <summary>
    /// WThe name of the privileged account, if supported  Valid for Checkpoint platforms
    /// </summary>
    /// <value>WThe name of the privileged account, if supported  Valid for Checkpoint platforms</value>
    [DataMember(Name="PrivilegedAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrivilegedAccountName")]
    public string PrivilegedAccountName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformConnectionProperties {\n");
      sb.Append("  DefaultPort: ").Append(DefaultPort).Append("\n");
      sb.Append("  DefaultSslPort: ").Append(DefaultSslPort).Append("\n");
      sb.Append("  AllowCustomPort: ").Append(AllowCustomPort).Append("\n");
      sb.Append("  SupportsTimeout: ").Append(SupportsTimeout).Append("\n");
      sb.Append("  SupportsPasswordAuthentication: ").Append(SupportsPasswordAuthentication).Append("\n");
      sb.Append("  SupportsSshKeyAuthentication: ").Append(SupportsSshKeyAuthentication).Append("\n");
      sb.Append("  SupportsLocalhostPasswordAuthentication: ").Append(SupportsLocalhostPasswordAuthentication).Append("\n");
      sb.Append("  SupportsDirectoryPasswordAuthentication: ").Append(SupportsDirectoryPasswordAuthentication).Append("\n");
      sb.Append("  SupportsAccessKeyAuthentication: ").Append(SupportsAccessKeyAuthentication).Append("\n");
      sb.Append("  SupportsAccountPasswordAuthentication: ").Append(SupportsAccountPasswordAuthentication).Append("\n");
      sb.Append("  SupportsStarlingConnectAuthentication: ").Append(SupportsStarlingConnectAuthentication).Append("\n");
      sb.Append("  SupportsPrivilegeElevationCommand: ").Append(SupportsPrivilegeElevationCommand).Append("\n");
      sb.Append("  SupportsSslEncryption: ").Append(SupportsSslEncryption).Append("\n");
      sb.Append("  SupportsWorkstationId: ").Append(SupportsWorkstationId).Append("\n");
      sb.Append("  SupportsSshTransport: ").Append(SupportsSshTransport).Append("\n");
      sb.Append("  SupportsEnablePassword: ").Append(SupportsEnablePassword).Append("\n");
      sb.Append("  SupportsInstance: ").Append(SupportsInstance).Append("\n");
      sb.Append("  SupportsServiceName: ").Append(SupportsServiceName).Append("\n");
      sb.Append("  SupportsSslCertificateVerification: ").Append(SupportsSslCertificateVerification).Append("\n");
      sb.Append("  SupportsSslThumbprint: ").Append(SupportsSslThumbprint).Append("\n");
      sb.Append("  SupportsClientId: ").Append(SupportsClientId).Append("\n");
      sb.Append("  RequiresDistinguishedName: ").Append(RequiresDistinguishedName).Append("\n");
      sb.Append("  SupportsOraclePrivileges: ").Append(SupportsOraclePrivileges).Append("\n");
      sb.Append("  SupportsTacacsSecret: ").Append(SupportsTacacsSecret).Append("\n");
      sb.Append("  SupportsLdap: ").Append(SupportsLdap).Append("\n");
      sb.Append("  SupportsDirectorySync: ").Append(SupportsDirectorySync).Append("\n");
      sb.Append("  SupportsDirectoryAssetDiscovery: ").Append(SupportsDirectoryAssetDiscovery).Append("\n");
      sb.Append("  SupportsNamedPipeForServiceAccountConnection: ").Append(SupportsNamedPipeForServiceAccountConnection).Append("\n");
      sb.Append("  SupportsTopSecretInterval: ").Append(SupportsTopSecretInterval).Append("\n");
      sb.Append("  SupportsPrivilegedAccount: ").Append(SupportsPrivilegedAccount).Append("\n");
      sb.Append("  PrivilegedAccountName: ").Append(PrivilegedAccountName).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
