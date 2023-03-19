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
  public class DeletedAsset {
    /// <summary>
    /// Database ID of system (Read-only)
    /// </summary>
    /// <value>Database ID of system (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Description of the system
    /// </summary>
    /// <value>Description of the system</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Database ID of platform type / version
    /// </summary>
    /// <value>Database ID of platform type / version</value>
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
    /// Display name platform (Read-only)
    /// </summary>
    /// <value>Display name platform (Read-only)</value>
    [DataMember(Name="PlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformDisplayName")]
    public string PlatformDisplayName { get; set; }

    /// <summary>
    /// Whether this asset is a directory platform (Read-only)
    /// </summary>
    /// <value>Whether this asset is a directory platform (Read-only)</value>
    [DataMember(Name="IsDirectory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDirectory")]
    public bool? IsDirectory { get; set; }

    /// <summary>
    /// Database ID of the managed network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.
    /// </summary>
    /// <value>Database ID of the managed network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.</value>
    [DataMember(Name="ManagedNetworkId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedNetworkId")]
    public int? ManagedNetworkId { get; set; }

    /// <summary>
    /// Name of the managed network (Read-only)
    /// </summary>
    /// <value>Name of the managed network (Read-only)</value>
    [DataMember(Name="ManagedNetworkName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedNetworkName")]
    public string ManagedNetworkName { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }

    /// <summary>
    /// Date this entity was deleted (Read-only)
    /// </summary>
    /// <value>Date this entity was deleted (Read-only)</value>
    [DataMember(Name="DeletedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedDate")]
    public DateTime? DeletedDate { get; set; }

    /// <summary>
    /// The database ID of the user that deleted this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that deleted this entity (Read-only)</value>
    [DataMember(Name="DeletedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedByUserId")]
    public int? DeletedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that deleted this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that deleted this entity (Read-only)</value>
    [DataMember(Name="DeletedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DeletedByUserDisplayName")]
    public string DeletedByUserDisplayName { get; set; }

    /// <summary>
    /// The name of the system. (Read-only for directories)
    /// </summary>
    /// <value>The name of the system. (Read-only for directories)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets NetworkAddress
    /// </summary>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Database ID of of the asset partition this asset belongs to
    /// </summary>
    /// <value>Database ID of of the asset partition this asset belongs to</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition this asset belongs to
    /// </summary>
    /// <value>Name of the asset partition this asset belongs to</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Gets or Sets LicenseClass
    /// </summary>
    [DataMember(Name="LicenseClass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LicenseClass")]
    public LicenseClass LicenseClass { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryProperties
    /// </summary>
    [DataMember(Name="DirectoryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryProperties")]
    public DirectoryObjectProperties DirectoryProperties { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryAssetProperties
    /// </summary>
    [DataMember(Name="DirectoryAssetProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryAssetProperties")]
    public DirectoryAssetProperties DirectoryAssetProperties { get; set; }

    /// <summary>
    /// Gets or Sets SessionAccessProperties
    /// </summary>
    [DataMember(Name="SessionAccessProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessProperties")]
    public AssetSessionAccessProperties SessionAccessProperties { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="Platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Platform")]
    public AssetPlatform Platform { get; set; }

    /// <summary>
    /// Whether this asset and its accounts are disabled and prevented from running platform tasks
    /// </summary>
    /// <value>Whether this asset and its accounts are disabled and prevented from running platform tasks</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Database ID of asset discovery job that added this asset (Read-only)
    /// </summary>
    /// <value>Database ID of asset discovery job that added this asset (Read-only)</value>
    [DataMember(Name="AssetDiscoveryJobId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDiscoveryJobId")]
    public int? AssetDiscoveryJobId { get; set; }

    /// <summary>
    /// Name of asset discovery job that added this asset (Read-only)
    /// </summary>
    /// <value>Name of asset discovery job that added this asset (Read-only)</value>
    [DataMember(Name="AssetDiscoveryJobName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDiscoveryJobName")]
    public string AssetDiscoveryJobName { get; set; }

    /// <summary>
    /// Database ID of account discovery schedule assigned to this asset
    /// </summary>
    /// <value>Database ID of account discovery schedule assigned to this asset</value>
    [DataMember(Name="AccountDiscoveryScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleId")]
    public int? AccountDiscoveryScheduleId { get; set; }

    /// <summary>
    /// Name of account discovery schedule assigned to this asset (Read-only)
    /// </summary>
    /// <value>Name of account discovery schedule assigned to this asset (Read-only)</value>
    [DataMember(Name="AccountDiscoveryScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleName")]
    public string AccountDiscoveryScheduleName { get; set; }

    /// <summary>
    /// Whether to allow session requests to be made to this asset using linked or policy-specific accounts
    /// </summary>
    /// <value>Whether to allow session requests to be made to this asset using linked or policy-specific accounts</value>
    [DataMember(Name="AllowSessionRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionRequests")]
    public bool? AllowSessionRequests { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public AssetConnectionProperties ConnectionProperties { get; set; }

    /// <summary>
    /// Gets or Sets PasswordProfile
    /// </summary>
    [DataMember(Name="PasswordProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordProfile")]
    public AssetPasswordProfileProperties PasswordProfile { get; set; }

    /// <summary>
    /// Gets or Sets SshKeyProfile
    /// </summary>
    [DataMember(Name="SshKeyProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfile")]
    public AssetSshKeyProfileProperties SshKeyProfile { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeletedAsset {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
      sb.Append("  IsDirectory: ").Append(IsDirectory).Append("\n");
      sb.Append("  ManagedNetworkId: ").Append(ManagedNetworkId).Append("\n");
      sb.Append("  ManagedNetworkName: ").Append(ManagedNetworkName).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  DeletedDate: ").Append(DeletedDate).Append("\n");
      sb.Append("  DeletedByUserId: ").Append(DeletedByUserId).Append("\n");
      sb.Append("  DeletedByUserDisplayName: ").Append(DeletedByUserDisplayName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  LicenseClass: ").Append(LicenseClass).Append("\n");
      sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
      sb.Append("  DirectoryAssetProperties: ").Append(DirectoryAssetProperties).Append("\n");
      sb.Append("  SessionAccessProperties: ").Append(SessionAccessProperties).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  AssetDiscoveryJobId: ").Append(AssetDiscoveryJobId).Append("\n");
      sb.Append("  AssetDiscoveryJobName: ").Append(AssetDiscoveryJobName).Append("\n");
      sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
      sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
      sb.Append("  AllowSessionRequests: ").Append(AllowSessionRequests).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
      sb.Append("  SshKeyProfile: ").Append(SshKeyProfile).Append("\n");
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
