using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration for connecting to a directory system
  /// </summary>
  [DataContract]
  public class DirectoryConnectionProperties {
    /// <summary>
    /// Whether to encrypt the connection with SSL
    /// </summary>
    /// <value>Whether to encrypt the connection with SSL</value>
    [DataMember(Name="UseSslEncryption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseSslEncryption")]
    public bool? UseSslEncryption { get; set; }

    /// <summary>
    /// Verify SSL certificate if using SSL. For an LDAP Identity Provider, if SSL is being used, then this  property will automatically be set to true.
    /// </summary>
    /// <value>Verify SSL certificate if using SSL. For an LDAP Identity Provider, if SSL is being used, then this  property will automatically be set to true.</value>
    [DataMember(Name="VerifySslCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VerifySslCertificate")]
    public bool? VerifySslCertificate { get; set; }

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
      sb.Append("class DirectoryConnectionProperties {\n");
      sb.Append("  UseSslEncryption: ").Append(UseSslEncryption).Append("\n");
      sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
      sb.Append("  ServiceAccountUniqueObjectId: ").Append(ServiceAccountUniqueObjectId).Append("\n");
      sb.Append("  ServiceAccountSecurityId: ").Append(ServiceAccountSecurityId).Append("\n");
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
