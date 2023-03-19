using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Connection properties for archive server platform tasks
  /// </summary>
  [DataContract]
  public class ArchivePlatformConnectionProperties {
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
    /// Specific SSH key to use to login to machine. Only applies when ServiceAccountCredentialType is set to 'SshKey'. (Read-only) (Deprecated)
    /// </summary>
    /// <value>Specific SSH key to use to login to machine. Only applies when ServiceAccountCredentialType is set to 'SshKey'. (Read-only) (Deprecated)</value>
    [DataMember(Name="ServiceAccountSshKeyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSshKeyId")]
    public int? ServiceAccountSshKeyId { get; set; }

    /// <summary>
    /// Fingerprint of the SSH key being used by the service account to authenticate to the machine (Read-only) (Deprecated)
    /// </summary>
    /// <value>Fingerprint of the SSH key being used by the service account to authenticate to the machine (Read-only) (Deprecated)</value>
    [DataMember(Name="ServiceAccountSshKeyFingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSshKeyFingerprint")]
    public string ServiceAccountSshKeyFingerprint { get; set; }

    /// <summary>
    /// Comment for the SSH key being used by the service account to authenticate to the machine (Read-only) (Deprecated)
    /// </summary>
    /// <value>Comment for the SSH key being used by the service account to authenticate to the machine (Read-only) (Deprecated)</value>
    [DataMember(Name="ServiceAccountSshKeyComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceAccountSshKeyComment")]
    public string ServiceAccountSshKeyComment { get; set; }

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
      sb.Append("class ArchivePlatformConnectionProperties {\n");
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
      sb.Append("  ServiceAccountSshKeyId: ").Append(ServiceAccountSshKeyId).Append("\n");
      sb.Append("  ServiceAccountSshKeyFingerprint: ").Append(ServiceAccountSshKeyFingerprint).Append("\n");
      sb.Append("  ServiceAccountSshKeyComment: ").Append(ServiceAccountSshKeyComment).Append("\n");
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
