using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents platform task information for an asset or directory account
  /// </summary>
  [DataContract]
  public class AccountTaskData {
    /// <summary>
    /// The database key of the account (Read-only)
    /// </summary>
    /// <value>The database key of the account (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the account (Read-only)
    /// </summary>
    /// <value>The name of the account (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The domain name that the account belongs to. (Read-only)
    /// </summary>
    /// <value>The domain name that the account belongs to. (Read-only)</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// The netbios name of the domain the account is from. (Read-only)
    /// </summary>
    /// <value>The netbios name of the domain the account is from. (Read-only)</value>
    [DataMember(Name="NetBiosName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetBiosName")]
    public string NetBiosName { get; set; }

    /// <summary>
    /// The distinguished name of the object (Read-only)
    /// </summary>
    /// <value>The distinguished name of the object (Read-only)</value>
    [DataMember(Name="DistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DistinguishedName")]
    public string DistinguishedName { get; set; }

    /// <summary>
    /// A short description of the account. (Read-only)
    /// </summary>
    /// <value>A short description of the account. (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// The system ID for use with platform tasks (Read-only)
    /// </summary>
    /// <value>The system ID for use with platform tasks (Read-only)</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// The name of the asset or directory this account is associated with (Read-only)
    /// </summary>
    /// <value>The name of the asset or directory this account is associated with (Read-only)</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// The network address of the system of the account
    /// </summary>
    /// <value>The network address of the system of the account</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// Database ID of partition asset belongs to
    /// </summary>
    /// <value>Database ID of partition asset belongs to</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of partition asset belongs to
    /// </summary>
    /// <value>Name of partition asset belongs to</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Unique identifier of sync group this account belongs to if applicable (Read-only)
    /// </summary>
    /// <value>Unique identifier of sync group this account belongs to if applicable (Read-only)</value>
    [DataMember(Name="SyncGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupId")]
    public int? SyncGroupId { get; set; }

    /// <summary>
    /// Name of SSH key sync group this account belongs to if applicable (Read-only)
    /// </summary>
    /// <value>Name of SSH key sync group this account belongs to if applicable (Read-only)</value>
    [DataMember(Name="SyncGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupName")]
    public string SyncGroupName { get; set; }

    /// <summary>
    /// Unique identifier of sync group this account belongs to if applicable (Read-only)
    /// </summary>
    /// <value>Unique identifier of sync group this account belongs to if applicable (Read-only)</value>
    [DataMember(Name="SshKeySyncGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeySyncGroupId")]
    public int? SshKeySyncGroupId { get; set; }

    /// <summary>
    /// Name of SSH key sync group this account belongs to if applicable (Read-only)
    /// </summary>
    /// <value>Name of SSH key sync group this account belongs to if applicable (Read-only)</value>
    [DataMember(Name="SshKeySyncGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeySyncGroupName")]
    public string SshKeySyncGroupName { get; set; }

    /// <summary>
    /// The database ID of the type of platform (Read-only)
    /// </summary>
    /// <value>The database ID of the type of platform (Read-only)</value>
    [DataMember(Name="PlatformId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformId")]
    public int? PlatformId { get; set; }

    /// <summary>
    /// Gets or Sets PlatformType
    /// </summary>
    [DataMember(Name="PlatformType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformType")]
    public PlatformType PlatformType { get; set; }

    /// <summary>
    /// The display name of the type of platform (Read-only)
    /// </summary>
    /// <value>The display name of the type of platform (Read-only)</value>
    [DataMember(Name="PlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformDisplayName")]
    public string PlatformDisplayName { get; set; }

    /// <summary>
    /// Whether the account has a password set or not (Read-only)
    /// </summary>
    /// <value>Whether the account has a password set or not (Read-only)</value>
    [DataMember(Name="HasPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasPassword")]
    public bool? HasPassword { get; set; }

    /// <summary>
    /// Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)
    /// </summary>
    /// <value>Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="AccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountType")]
    public AccountType AccountType { get; set; }

    /// <summary>
    /// Whether this account is being used as a service account (Read-only)
    /// </summary>
    /// <value>Whether this account is being used as a service account (Read-only)</value>
    [DataMember(Name="IsServiceAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsServiceAccount")]
    public bool? IsServiceAccount { get; set; }

    /// <summary>
    /// Database ID of the effective profile assigned to this account or to the asset or partition it belongs to (Read-only)
    /// </summary>
    /// <value>Database ID of the effective profile assigned to this account or to the asset or partition it belongs to (Read-only)</value>
    [DataMember(Name="EffectiveProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveProfileId")]
    public int? EffectiveProfileId { get; set; }

    /// <summary>
    /// Name of the effective profile assigned to this account or to the asset or partition it belongs to (Read-only)
    /// </summary>
    /// <value>Name of the effective profile assigned to this account or to the asset or partition it belongs to (Read-only)</value>
    [DataMember(Name="EffectiveProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveProfileName")]
    public string EffectiveProfileName { get; set; }

    /// <summary>
    /// Database ID of the effective SSH key profile assigned to this account or to the asset or partition it belongs to (Read-only)
    /// </summary>
    /// <value>Database ID of the effective SSH key profile assigned to this account or to the asset or partition it belongs to (Read-only)</value>
    [DataMember(Name="EffectiveSshKeyProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveSshKeyProfileId")]
    public int? EffectiveSshKeyProfileId { get; set; }

    /// <summary>
    /// Name of the effective SSH key profile assigned to this account or to the asset or partition it belongs to (Read-only)
    /// </summary>
    /// <value>Name of the effective SSH key profile assigned to this account or to the asset or partition it belongs to (Read-only)</value>
    [DataMember(Name="EffectiveSshKeyProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EffectiveSshKeyProfileName")]
    public string EffectiveSshKeyProfileName { get; set; }

    /// <summary>
    /// Gets or Sets PlatformTaskInformation
    /// </summary>
    [DataMember(Name="PlatformTaskInformation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformTaskInformation")]
    public PlatformTaskInformation PlatformTaskInformation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountTaskData {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  NetBiosName: ").Append(NetBiosName).Append("\n");
      sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  SyncGroupId: ").Append(SyncGroupId).Append("\n");
      sb.Append("  SyncGroupName: ").Append(SyncGroupName).Append("\n");
      sb.Append("  SshKeySyncGroupId: ").Append(SshKeySyncGroupId).Append("\n");
      sb.Append("  SshKeySyncGroupName: ").Append(SshKeySyncGroupName).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
      sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  IsServiceAccount: ").Append(IsServiceAccount).Append("\n");
      sb.Append("  EffectiveProfileId: ").Append(EffectiveProfileId).Append("\n");
      sb.Append("  EffectiveProfileName: ").Append(EffectiveProfileName).Append("\n");
      sb.Append("  EffectiveSshKeyProfileId: ").Append(EffectiveSshKeyProfileId).Append("\n");
      sb.Append("  EffectiveSshKeyProfileName: ").Append(EffectiveSshKeyProfileName).Append("\n");
      sb.Append("  PlatformTaskInformation: ").Append(PlatformTaskInformation).Append("\n");
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
