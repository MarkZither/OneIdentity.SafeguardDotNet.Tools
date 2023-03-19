using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings detailing how the console connects to the asset
  /// </summary>
  [DataContract]
  public class AssetConnectionProperties {
    /// <summary>
    /// Unique object ID of service account. Directory accounts only. (Read-only)
    /// </summary>
    /// <value>Unique object ID of service account. Directory accounts only. (Read-only)</value>
    [DataMember(Name="ServiceAccountUniqueObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountUniqueObjectId")]
    public string ServiceAccountUniqueObjectId { get; set; }

    /// <summary>
    /// Security ID of service account. Directory accounts only. (Read-only)
    /// </summary>
    /// <value>Security ID of service account. Directory accounts only. (Read-only)</value>
    [DataMember(Name="ServiceAccountSecurityId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSecurityId")]
    public string ServiceAccountSecurityId { get; set; }

    /// <summary>
    /// Cisco routers require an extra password to enable password management. (write-only)
    /// </summary>
    /// <value>Cisco routers require an extra password to enable password management. (write-only)</value>
    [DataMember(Name="EnablePassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnablePassword")]
    public string EnablePassword { get; set; }

    /// <summary>
    /// Whether the asset has an enable password set (Read-only)
    /// </summary>
    /// <value>Whether the asset has an enable password set (Read-only)</value>
    [DataMember(Name="EnableHasPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnableHasPassword")]
    public bool? EnableHasPassword { get; set; }

    /// <summary>
    /// How long to wait (in seconds) for both the connect and command timeout
    /// </summary>
    /// <value>How long to wait (in seconds) for both the connect and command timeout</value>
    [DataMember(Name="CommandTimeout", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CommandTimeout")]
    public int? CommandTimeout { get; set; }

    /// <summary>
    /// Workstation ID to assign to telnet session  Valid on AS/400 only
    /// </summary>
    /// <value>Workstation ID to assign to telnet session  Valid on AS/400 only</value>
    [DataMember(Name="WorkstationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WorkstationId")]
    public string WorkstationId { get; set; }

    /// <summary>
    /// Client ID used for SAP sessions
    /// </summary>
    /// <value>Client ID used for SAP sessions</value>
    [DataMember(Name="ClientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientId")]
    public int? ClientId { get; set; }

    /// <summary>
    /// ID of profile explicitly explicitly assigned to the service account. During asset creation this profile will be assigned to the service account.  Use null to inherit profile from the asset.
    /// </summary>
    /// <value>ID of profile explicitly explicitly assigned to the service account. During asset creation this profile will be assigned to the service account.  Use null to inherit profile from the asset.</value>
    [DataMember(Name="ServiceAccountProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountProfileId")]
    public int? ServiceAccountProfileId { get; set; }

    /// <summary>
    /// Name of profile explicitly explicitly assigned to the service account.
    /// </summary>
    /// <value>Name of profile explicitly explicitly assigned to the service account.</value>
    [DataMember(Name="ServiceAccountProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountProfileName")]
    public string ServiceAccountProfileName { get; set; }

    /// <summary>
    /// ID of SSH key profile explicitly explicitly assigned to the service account. During asset creation this profile will be assigned to the service account.  Use null to inherit profile from the asset.
    /// </summary>
    /// <value>ID of SSH key profile explicitly explicitly assigned to the service account. During asset creation this profile will be assigned to the service account.  Use null to inherit profile from the asset.</value>
    [DataMember(Name="ServiceAccountSshKeyProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSshKeyProfileId")]
    public int? ServiceAccountSshKeyProfileId { get; set; }

    /// <summary>
    /// Name of SSH key profile explicitly explicitly assigned to the service account.
    /// </summary>
    /// <value>Name of SSH key profile explicitly explicitly assigned to the service account.</value>
    [DataMember(Name="ServiceAccountSshKeyProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSshKeyProfileName")]
    public string ServiceAccountSshKeyProfileName { get; set; }

    /// <summary>
    /// Whether to encrypt data with SSL. Default to true where supported except for ActiveDirectory
    /// </summary>
    /// <value>Whether to encrypt data with SSL. Default to true where supported except for ActiveDirectory</value>
    [DataMember(Name="UseSslEncryption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseSslEncryption")]
    public bool? UseSslEncryption { get; set; }

    /// <summary>
    /// Verify SSL certificate if using SSL
    /// </summary>
    /// <value>Verify SSL certificate if using SSL</value>
    [DataMember(Name="VerifySslCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VerifySslCertificate")]
    public bool? VerifySslCertificate { get; set; }

    /// <summary>
    /// database instance name to specify for odbc transports
    /// </summary>
    /// <value>database instance name to specify for odbc transports</value>
    [DataMember(Name="Instance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Instance")]
    public string Instance { get; set; }

    /// <summary>
    /// service name to specify for odbc transports
    /// </summary>
    /// <value>service name to specify for odbc transports</value>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Thumbprint of nominated Ssl Certificate to use
    /// </summary>
    /// <value>Thumbprint of nominated Ssl Certificate to use</value>
    [DataMember(Name="SslThumbprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SslThumbprint")]
    public string SslThumbprint { get; set; }

    /// <summary>
    /// Whether or not to use delegation of commands (e.g. sudo.) The prefix is used to preface  commands requiring privileged access on the asset. Note that this must be non-interactive.  Valid for most unix-compatible platforms (Read-only)
    /// </summary>
    /// <value>Whether or not to use delegation of commands (e.g. sudo.) The prefix is used to preface  commands requiring privileged access on the asset. Note that this must be non-interactive.  Valid for most unix-compatible platforms (Read-only)</value>
    [DataMember(Name="PrivilegeElevationCommand", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrivilegeElevationCommand")]
    public string PrivilegeElevationCommand { get; set; }

    /// <summary>
    /// AWS requires an access key id for password management.
    /// </summary>
    /// <value>AWS requires an access key id for password management.</value>
    [DataMember(Name="AccessKeyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessKeyId")]
    public string AccessKeyId { get; set; }

    /// <summary>
    /// AWS requires a secret key for password management. (write-only)
    /// </summary>
    /// <value>AWS requires a secret key for password management. (write-only)</value>
    [DataMember(Name="SecretKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecretKey")]
    public string SecretKey { get; set; }

    /// <summary>
    /// Whether the asset has secret key
    /// </summary>
    /// <value>Whether the asset has secret key</value>
    [DataMember(Name="HasSecretKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasSecretKey")]
    public bool? HasSecretKey { get; set; }

    /// <summary>
    /// Oracle platforms may support a means of specifying what privileges are needed when logging in (Oracle-only)
    /// </summary>
    /// <value>Oracle platforms may support a means of specifying what privileges are needed when logging in (Oracle-only)</value>
    [DataMember(Name="OraclePrivileges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OraclePrivileges")]
    public string OraclePrivileges { get; set; }

    /// <summary>
    /// Identifies whether Named Pipe or TCP/IP is used for Windows/AD service account connections to the asset.
    /// </summary>
    /// <value>Identifies whether Named Pipe or TCP/IP is used for Windows/AD service account connections to the asset.</value>
    [DataMember(Name="UseNamedPipeForServiceAccountConnection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseNamedPipeForServiceAccountConnection")]
    public bool? UseNamedPipeForServiceAccountConnection { get; set; }

    /// <summary>
    /// Database ID of the starling registered connector
    /// </summary>
    /// <value>Database ID of the starling registered connector</value>
    [DataMember(Name="RegisteredConnectorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegisteredConnectorId")]
    public int? RegisteredConnectorId { get; set; }

    /// <summary>
    /// Cisco ISE requires a Tacacs Secret to Check password (write-only)
    /// </summary>
    /// <value>Cisco ISE requires a Tacacs Secret to Check password (write-only)</value>
    [DataMember(Name="TacacsSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TacacsSecret")]
    public string TacacsSecret { get; set; }

    /// <summary>
    /// Whether the asset has a Tacacs secret (Read-only)
    /// </summary>
    /// <value>Whether the asset has a Tacacs secret (Read-only)</value>
    [DataMember(Name="HasTacacsSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasTacacsSecret")]
    public bool? HasTacacsSecret { get; set; }

    /// <summary>
    /// Whether to use the profile's next change date as the interval on a Top Secret mainframe
    /// </summary>
    /// <value>Whether to use the profile's next change date as the interval on a Top Secret mainframe</value>
    [DataMember(Name="UseTopSecretInterval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseTopSecretInterval")]
    public bool? UseTopSecretInterval { get; set; }

    /// <summary>
    /// Database ID of an asset account for connecting to the asset. Cannot be specified simultaneously with ServiceAccountName.
    /// </summary>
    /// <value>Database ID of an asset account for connecting to the asset. Cannot be specified simultaneously with ServiceAccountName.</value>
    [DataMember(Name="ServiceAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountId")]
    public int? ServiceAccountId { get; set; }

    /// <summary>
    /// The name of an account that is not being managed for connecting to the asset. Cannot be specified simultaneously with ServiceAccountId.
    /// </summary>
    /// <value>The name of an account that is not being managed for connecting to the asset. Cannot be specified simultaneously with ServiceAccountId.</value>
    [DataMember(Name="ServiceAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountName")]
    public string ServiceAccountName { get; set; }

    /// <summary>
    /// The name of the account for connecting to the asset whether the account is managed or not (Read-only)
    /// </summary>
    /// <value>The name of the account for connecting to the asset whether the account is managed or not (Read-only)</value>
    [DataMember(Name="EffectiveServiceAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveServiceAccountName")]
    public string EffectiveServiceAccountName { get; set; }

    /// <summary>
    /// The domain name of the service account if the task uses a Directory  or DirectoryAccount (Read-only)
    /// </summary>
    /// <value>The domain name of the service account if the task uses a Directory  or DirectoryAccount (Read-only)</value>
    [DataMember(Name="ServiceAccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountDomainName")]
    public string ServiceAccountDomainName { get; set; }

    /// <summary>
    /// Distinguished name of service account (required for OpenLdap)
    /// </summary>
    /// <value>Distinguished name of service account (required for OpenLdap)</value>
    [DataMember(Name="ServiceAccountDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountDistinguishedName")]
    public string ServiceAccountDistinguishedName { get; set; }

    /// <summary>
    /// Effective distinguished name of service account (required for OpenLdap)
    /// </summary>
    /// <value>Effective distinguished name of service account (required for OpenLdap)</value>
    [DataMember(Name="EffectiveServiceAccountDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveServiceAccountDistinguishedName")]
    public string EffectiveServiceAccountDistinguishedName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAccountCredentialType
    /// </summary>
    [DataMember(Name="ServiceAccountCredentialType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountCredentialType")]
    public ServiceAccountCredentialType ServiceAccountCredentialType { get; set; }

    /// <summary>
    /// If ServiceAccountId is not specified then the service account password may be set via this property. (write-only)
    /// </summary>
    /// <value>If ServiceAccountId is not specified then the service account password may be set via this property. (write-only)</value>
    [DataMember(Name="ServiceAccountPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountPassword")]
    public string ServiceAccountPassword { get; set; }

    /// <summary>
    /// Whether the service account has a password set or not (Read-only)
    /// </summary>
    /// <value>Whether the service account has a password set or not (Read-only)</value>
    [DataMember(Name="ServiceAccountHasPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountHasPassword")]
    public bool? ServiceAccountHasPassword { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAccountSshKey
    /// </summary>
    [DataMember(Name="ServiceAccountSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSshKey")]
    public SystemSshKey ServiceAccountSshKey { get; set; }

    /// <summary>
    /// Whether the service account has an SSH key set or not (Read-only)
    /// </summary>
    /// <value>Whether the service account has an SSH key set or not (Read-only)</value>
    [DataMember(Name="ServiceAccountHasSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountHasSshKey")]
    public bool? ServiceAccountHasSshKey { get; set; }

    /// <summary>
    /// Port used to connect to the system
    /// </summary>
    /// <value>Port used to connect to the system</value>
    [DataMember(Name="Port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Port")]
    public int? Port { get; set; }

    /// <summary>
    /// The database ID of the asset the service account belongs to (Read-only)
    /// </summary>
    /// <value>The database ID of the asset the service account belongs to (Read-only)</value>
    [DataMember(Name="ServiceAccountAssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountAssetId")]
    public int? ServiceAccountAssetId { get; set; }

    /// <summary>
    /// The name of the asset the service account belongs to (Read-only)
    /// </summary>
    /// <value>The name of the asset the service account belongs to (Read-only)</value>
    [DataMember(Name="ServiceAccountAssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountAssetName")]
    public string ServiceAccountAssetName { get; set; }

    /// <summary>
    /// The database ID of the platform of the asset the service account belongs to (Read-only)
    /// </summary>
    /// <value>The database ID of the platform of the asset the service account belongs to (Read-only)</value>
    [DataMember(Name="ServiceAccountAssetPlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountAssetPlatformId")]
    public int? ServiceAccountAssetPlatformId { get; set; }

    /// <summary>
    /// Gets or Sets ServiceAccountAssetPlatformType
    /// </summary>
    [DataMember(Name="ServiceAccountAssetPlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountAssetPlatformType")]
    public PlatformType ServiceAccountAssetPlatformType { get; set; }

    /// <summary>
    /// The platform display name of the asset the service account belongs to (Read-only)
    /// </summary>
    /// <value>The platform display name of the asset the service account belongs to (Read-only)</value>
    [DataMember(Name="ServiceAccountAssetPlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountAssetPlatformDisplayName")]
    public string ServiceAccountAssetPlatformDisplayName { get; set; }

    /// <summary>
    /// The netbios name of the service account (Read-only)
    /// </summary>
    /// <value>The netbios name of the service account (Read-only)</value>
    [DataMember(Name="ServiceAccountNetbiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountNetbiosName")]
    public string ServiceAccountNetbiosName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetConnectionProperties {\n");
      sb.Append("  ServiceAccountUniqueObjectId: ").Append(ServiceAccountUniqueObjectId).Append("\n");
      sb.Append("  ServiceAccountSecurityId: ").Append(ServiceAccountSecurityId).Append("\n");
      sb.Append("  EnablePassword: ").Append(EnablePassword).Append("\n");
      sb.Append("  EnableHasPassword: ").Append(EnableHasPassword).Append("\n");
      sb.Append("  CommandTimeout: ").Append(CommandTimeout).Append("\n");
      sb.Append("  WorkstationId: ").Append(WorkstationId).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  ServiceAccountProfileId: ").Append(ServiceAccountProfileId).Append("\n");
      sb.Append("  ServiceAccountProfileName: ").Append(ServiceAccountProfileName).Append("\n");
      sb.Append("  ServiceAccountSshKeyProfileId: ").Append(ServiceAccountSshKeyProfileId).Append("\n");
      sb.Append("  ServiceAccountSshKeyProfileName: ").Append(ServiceAccountSshKeyProfileName).Append("\n");
      sb.Append("  UseSslEncryption: ").Append(UseSslEncryption).Append("\n");
      sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
      sb.Append("  Instance: ").Append(Instance).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
      sb.Append("  SslThumbprint: ").Append(SslThumbprint).Append("\n");
      sb.Append("  PrivilegeElevationCommand: ").Append(PrivilegeElevationCommand).Append("\n");
      sb.Append("  AccessKeyId: ").Append(AccessKeyId).Append("\n");
      sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
      sb.Append("  HasSecretKey: ").Append(HasSecretKey).Append("\n");
      sb.Append("  OraclePrivileges: ").Append(OraclePrivileges).Append("\n");
      sb.Append("  UseNamedPipeForServiceAccountConnection: ").Append(UseNamedPipeForServiceAccountConnection).Append("\n");
      sb.Append("  RegisteredConnectorId: ").Append(RegisteredConnectorId).Append("\n");
      sb.Append("  TacacsSecret: ").Append(TacacsSecret).Append("\n");
      sb.Append("  HasTacacsSecret: ").Append(HasTacacsSecret).Append("\n");
      sb.Append("  UseTopSecretInterval: ").Append(UseTopSecretInterval).Append("\n");
      sb.Append("  ServiceAccountId: ").Append(ServiceAccountId).Append("\n");
      sb.Append("  ServiceAccountName: ").Append(ServiceAccountName).Append("\n");
      sb.Append("  EffectiveServiceAccountName: ").Append(EffectiveServiceAccountName).Append("\n");
      sb.Append("  ServiceAccountDomainName: ").Append(ServiceAccountDomainName).Append("\n");
      sb.Append("  ServiceAccountDistinguishedName: ").Append(ServiceAccountDistinguishedName).Append("\n");
      sb.Append("  EffectiveServiceAccountDistinguishedName: ").Append(EffectiveServiceAccountDistinguishedName).Append("\n");
      sb.Append("  ServiceAccountCredentialType: ").Append(ServiceAccountCredentialType).Append("\n");
      sb.Append("  ServiceAccountPassword: ").Append(ServiceAccountPassword).Append("\n");
      sb.Append("  ServiceAccountHasPassword: ").Append(ServiceAccountHasPassword).Append("\n");
      sb.Append("  ServiceAccountSshKey: ").Append(ServiceAccountSshKey).Append("\n");
      sb.Append("  ServiceAccountHasSshKey: ").Append(ServiceAccountHasSshKey).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  ServiceAccountAssetId: ").Append(ServiceAccountAssetId).Append("\n");
      sb.Append("  ServiceAccountAssetName: ").Append(ServiceAccountAssetName).Append("\n");
      sb.Append("  ServiceAccountAssetPlatformId: ").Append(ServiceAccountAssetPlatformId).Append("\n");
      sb.Append("  ServiceAccountAssetPlatformType: ").Append(ServiceAccountAssetPlatformType).Append("\n");
      sb.Append("  ServiceAccountAssetPlatformDisplayName: ").Append(ServiceAccountAssetPlatformDisplayName).Append("\n");
      sb.Append("  ServiceAccountNetbiosName: ").Append(ServiceAccountNetbiosName).Append("\n");
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
