using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an remote asset account
  /// </summary>
  [DataContract]
  public class AssetAccount {
    /// <summary>
    /// The database ID of the account (Read-only)
    /// </summary>
    /// <value>The database ID of the account (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the account
    /// </summary>
    /// <value>The name of the account</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The distinguished name of the account (required for ACF2-Ldap)
    /// </summary>
    /// <value>The distinguished name of the account (required for ACF2-Ldap)</value>
    [DataMember(Name="DistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DistinguishedName")]
    public string DistinguishedName { get; set; }

    /// <summary>
    /// Name of the domain this object is from. Required if this is an object to import from a directory.
    /// </summary>
    /// <value>Name of the domain this object is from. Required if this is an object to import from a directory.</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// A short description of the account.
    /// </summary>
    /// <value>A short description of the account.</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// The alternate login name (Read-only)
    /// </summary>
    /// <value>The alternate login name (Read-only)</value>
    [DataMember(Name="AltLoginName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AltLoginName")]
    public string AltLoginName { get; set; }

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
    /// List of Identities that manage this asset
    /// </summary>
    /// <value>List of Identities that manage this asset</value>
    [DataMember(Name="ManagedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedBy")]
    public List<Identity> ManagedBy { get; set; }

    /// <summary>
    /// Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)
    /// </summary>
    /// <value>Whether this account has been disabled. Prevent it from being used for access requests and automated password tasks (Read-only)</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Whether this account is a service account or not (Read-only)
    /// </summary>
    /// <value>Whether this account is a service account or not (Read-only)</value>
    [DataMember(Name="IsServiceAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsServiceAccount")]
    public bool? IsServiceAccount { get; set; }

    /// <summary>
    /// Whether this account can be used as a service account for other assets (only valid for directory accounts)
    /// </summary>
    /// <value>Whether this account can be used as a service account for other assets (only valid for directory accounts)</value>
    [DataMember(Name="SharedServiceAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharedServiceAccount")]
    public bool? SharedServiceAccount { get; set; }

    /// <summary>
    /// The tags associated with this account
    /// </summary>
    /// <value>The tags associated with this account</value>
    [DataMember(Name="Tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tags")]
    public List<Tag> Tags { get; set; }

    /// <summary>
    /// Gets or Sets Asset
    /// </summary>
    [DataMember(Name="Asset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Asset")]
    public AccountAssetProperties Asset { get; set; }

    /// <summary>
    /// Gets or Sets PasswordProfile
    /// </summary>
    [DataMember(Name="PasswordProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PasswordProfile")]
    public AccountProfileProperties PasswordProfile { get; set; }

    /// <summary>
    /// Gets or Sets SshKeyProfile
    /// </summary>
    [DataMember(Name="SshKeyProfile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfile")]
    public AccountSshKeyProfileProperties SshKeyProfile { get; set; }

    /// <summary>
    /// Gets or Sets RequestProperties
    /// </summary>
    [DataMember(Name="RequestProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestProperties")]
    public AccountRequestProperties RequestProperties { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="Platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Platform")]
    public AccountPlatformProperties Platform { get; set; }

    /// <summary>
    /// Gets or Sets DiscoveredProperties
    /// </summary>
    [DataMember(Name="DiscoveredProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredProperties")]
    public DiscoveredAccountProperties DiscoveredProperties { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryProperties
    /// </summary>
    [DataMember(Name="DirectoryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryProperties")]
    public DirectoryAccountProperties DirectoryProperties { get; set; }

    /// <summary>
    /// Gets or Sets SyncGroup
    /// </summary>
    [DataMember(Name="SyncGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroup")]
    public AccountSyncGroupProperties SyncGroup { get; set; }

    /// <summary>
    /// Gets or Sets SshKeySyncGroup
    /// </summary>
    [DataMember(Name="SshKeySyncGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeySyncGroup")]
    public AccountSshKeySyncGroupProperties SshKeySyncGroup { get; set; }

    /// <summary>
    /// Whether the account has a password set or not (Read-only)
    /// </summary>
    /// <value>Whether the account has a password set or not (Read-only)</value>
    [DataMember(Name="HasPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasPassword")]
    public bool? HasPassword { get; set; }

    /// <summary>
    /// Whether the account has an SSH key assigned or not (Read-only)
    /// </summary>
    /// <value>Whether the account has an SSH key assigned or not (Read-only)</value>
    [DataMember(Name="HasSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasSshKey")]
    public bool? HasSshKey { get; set; }

    /// <summary>
    /// Gets or Sets TaskProperties
    /// </summary>
    [DataMember(Name="TaskProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaskProperties")]
    public AccountTaskProperties TaskProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetAccount {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DistinguishedName: ").Append(DistinguishedName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  AltLoginName: ").Append(AltLoginName).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  ManagedBy: ").Append(ManagedBy).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  IsServiceAccount: ").Append(IsServiceAccount).Append("\n");
      sb.Append("  SharedServiceAccount: ").Append(SharedServiceAccount).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  Asset: ").Append(Asset).Append("\n");
      sb.Append("  PasswordProfile: ").Append(PasswordProfile).Append("\n");
      sb.Append("  SshKeyProfile: ").Append(SshKeyProfile).Append("\n");
      sb.Append("  RequestProperties: ").Append(RequestProperties).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  DiscoveredProperties: ").Append(DiscoveredProperties).Append("\n");
      sb.Append("  DirectoryProperties: ").Append(DirectoryProperties).Append("\n");
      sb.Append("  SyncGroup: ").Append(SyncGroup).Append("\n");
      sb.Append("  SshKeySyncGroup: ").Append(SshKeySyncGroup).Append("\n");
      sb.Append("  HasPassword: ").Append(HasPassword).Append("\n");
      sb.Append("  HasSshKey: ").Append(HasSshKey).Append("\n");
      sb.Append("  TaskProperties: ").Append(TaskProperties).Append("\n");
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
