using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class DiscoveredSshKey {
    /// <summary>
    /// The date the ssh key was discovered
    /// </summary>
    /// <value>The date the ssh key was discovered</value>
    [DataMember(Name="DiscoveredDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredDate")]
    public DateTime? DiscoveredDate { get; set; }

    /// <summary>
    /// Name of the account for which this ssh key was discovered
    /// </summary>
    /// <value>Name of the account for which this ssh key was discovered</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name of the account for which this ssh key was discovered
    /// </summary>
    /// <value>Domain name of the account for which this ssh key was discovered</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Database ID of the account for which this ssh key was discovered
    /// </summary>
    /// <value>Database ID of the account for which this ssh key was discovered</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the asset on which this ssh key was discovered
    /// </summary>
    /// <value>Name of the asset on which this ssh key was discovered</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Database ID of the asset on which this ssh key was discovered
    /// </summary>
    /// <value>Database ID of the asset on which this ssh key was discovered</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Database identifier for the asset partition on which this ssh key was discovered
    /// </summary>
    /// <value>Database identifier for the asset partition on which this ssh key was discovered</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition on which this ssh key was discovered
    /// </summary>
    /// <value>Name of the asset partition on which this ssh key was discovered</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Database Id of the profile used to discover the ssh key
    /// </summary>
    /// <value>Database Id of the profile used to discover the ssh key</value>
    [DataMember(Name="SshKeyProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfileId")]
    public int? SshKeyProfileId { get; set; }

    /// <summary>
    /// Name of profile used to discover the ssh key
    /// </summary>
    /// <value>Name of profile used to discover the ssh key</value>
    [DataMember(Name="SshKeyProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfileName")]
    public string SshKeyProfileName { get; set; }

    /// <summary>
    /// Database Id of the ssh key discovery schedule used to discover the ssh key
    /// </summary>
    /// <value>Database Id of the ssh key discovery schedule used to discover the ssh key</value>
    [DataMember(Name="SshKeyDiscoveryScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyDiscoveryScheduleId")]
    public int? SshKeyDiscoveryScheduleId { get; set; }

    /// <summary>
    /// Name of ssh key discovery schedule used to discover the ssh key
    /// </summary>
    /// <value>Name of ssh key discovery schedule used to discover the ssh key</value>
    [DataMember(Name="SshKeyDiscoveryScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyDiscoveryScheduleName")]
    public string SshKeyDiscoveryScheduleName { get; set; }

    /// <summary>
    /// Public key represented in base64
    /// </summary>
    /// <value>Public key represented in base64</value>
    [DataMember(Name="PublicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PublicKey")]
    public string PublicKey { get; set; }

    /// <summary>
    /// Comment associated with key
    /// </summary>
    /// <value>Comment associated with key</value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// The MD5 fingerprint hash of the SSH key (Read-only)
    /// </summary>
    /// <value>The MD5 fingerprint hash of the SSH key (Read-only)</value>
    [DataMember(Name="Fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fingerprint")]
    public string Fingerprint { get; set; }

    /// <summary>
    /// The SHA256 fingerprint hash, Base64 encoded, of the SSH key. (Read-only)
    /// </summary>
    /// <value>The SHA256 fingerprint hash, Base64 encoded, of the SSH key. (Read-only)</value>
    [DataMember(Name="FingerprintSha256", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FingerprintSha256")]
    public string FingerprintSha256 { get; set; }

    /// <summary>
    /// Gets or Sets KeyType
    /// </summary>
    [DataMember(Name="KeyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyType")]
    public SshKeyType KeyType { get; set; }

    /// <summary>
    /// Options associated with key
    /// </summary>
    /// <value>Options associated with key</value>
    [DataMember(Name="Options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Options")]
    public string Options { get; set; }

    /// <summary>
    /// Length of SSH key
    /// </summary>
    /// <value>Length of SSH key</value>
    [DataMember(Name="KeyLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyLength")]
    public int? KeyLength { get; set; }

    /// <summary>
    /// Gets or Sets AccountStatus
    /// </summary>
    [DataMember(Name="AccountStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountStatus")]
    public DiscoveredAccountStatus AccountStatus { get; set; }

    /// <summary>
    /// Whether the private key is managed by Safeguard
    /// </summary>
    /// <value>Whether the private key is managed by Safeguard</value>
    [DataMember(Name="IsManaged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsManaged")]
    public bool? IsManaged { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredSshKey {\n");
      sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  SshKeyProfileId: ").Append(SshKeyProfileId).Append("\n");
      sb.Append("  SshKeyProfileName: ").Append(SshKeyProfileName).Append("\n");
      sb.Append("  SshKeyDiscoveryScheduleId: ").Append(SshKeyDiscoveryScheduleId).Append("\n");
      sb.Append("  SshKeyDiscoveryScheduleName: ").Append(SshKeyDiscoveryScheduleName).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
      sb.Append("  FingerprintSha256: ").Append(FingerprintSha256).Append("\n");
      sb.Append("  KeyType: ").Append(KeyType).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  KeyLength: ").Append(KeyLength).Append("\n");
      sb.Append("  AccountStatus: ").Append(AccountStatus).Append("\n");
      sb.Append("  IsManaged: ").Append(IsManaged).Append("\n");
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
