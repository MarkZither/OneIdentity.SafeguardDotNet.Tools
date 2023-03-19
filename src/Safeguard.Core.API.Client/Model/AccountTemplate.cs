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
  public class AccountTemplate {
    /// <summary>
    /// Description of the account
    /// </summary>
    /// <value>Description of the account</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Id of a profile to be assigned to the newly managed account. If null then profile used to discover account will be used.
    /// </summary>
    /// <value>Id of a profile to be assigned to the newly managed account. If null then profile used to discover account will be used.</value>
    [DataMember(Name="ProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileId")]
    public int? ProfileId { get; set; }

    /// <summary>
    /// The name of the profile to be assigned to the newly managed account (Read-only)
    /// </summary>
    /// <value>The name of the profile to be assigned to the newly managed account (Read-only)</value>
    [DataMember(Name="ProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileName")]
    public string ProfileName { get; set; }

    /// <summary>
    /// Id of a SSH key profile to be assigned to the newly managed account. If null then profile used to discover account will be used.
    /// </summary>
    /// <value>Id of a SSH key profile to be assigned to the newly managed account. If null then profile used to discover account will be used.</value>
    [DataMember(Name="SshKeyProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfileId")]
    public int? SshKeyProfileId { get; set; }

    /// <summary>
    /// The name of the SSH key profile to be assigned to the newly managed account (Read-only)
    /// </summary>
    /// <value>The name of the SSH key profile to be assigned to the newly managed account (Read-only)</value>
    [DataMember(Name="SshKeyProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyProfileName")]
    public string SshKeyProfileName { get; set; }

    /// <summary>
    /// Allow password requests on the newly managed asset account to be released
    /// </summary>
    /// <value>Allow password requests on the newly managed asset account to be released</value>
    [DataMember(Name="AllowPasswordRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPasswordRelease")]
    public bool? AllowPasswordRelease { get; set; }

    /// <summary>
    /// Allow session requests on the newly managed asset account to be released
    /// </summary>
    /// <value>Allow session requests on the newly managed asset account to be released</value>
    [DataMember(Name="AllowSessionRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionRelease")]
    public bool? AllowSessionRelease { get; set; }

    /// <summary>
    /// Allow SSH key requests on the newly managed asset account to be released
    /// </summary>
    /// <value>Allow SSH key requests on the newly managed asset account to be released</value>
    [DataMember(Name="AllowSshKeyRelease", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSshKeyRelease")]
    public bool? AllowSshKeyRelease { get; set; }

    /// <summary>
    /// Whether this account can be used as a service account for other assets (only valid for directory accounts)
    /// </summary>
    /// <value>Whether this account can be used as a service account for other assets (only valid for directory accounts)</value>
    [DataMember(Name="SharedServiceAccount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SharedServiceAccount")]
    public bool? SharedServiceAccount { get; set; }

    /// <summary>
    /// ID of the sync group to assign this account to. (Read-only)  NOTE: Sync group takes precedence over profile setting above. Profile will be explicitly set.  NOTE: Sync priority will be set to 0.
    /// </summary>
    /// <value>ID of the sync group to assign this account to. (Read-only)  NOTE: Sync group takes precedence over profile setting above. Profile will be explicitly set.  NOTE: Sync priority will be set to 0.</value>
    [DataMember(Name="SyncGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupId")]
    public int? SyncGroupId { get; set; }

    /// <summary>
    /// The name of the sync group to be assigned to the newly managed account (Read-only)
    /// </summary>
    /// <value>The name of the sync group to be assigned to the newly managed account (Read-only)</value>
    [DataMember(Name="SyncGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupName")]
    public string SyncGroupName { get; set; }

    /// <summary>
    /// The priority to assign to discovered accounts in the sync group
    /// </summary>
    /// <value>The priority to assign to discovered accounts in the sync group</value>
    [DataMember(Name="SyncGroupPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupPriority")]
    public int? SyncGroupPriority { get; set; }

    /// <summary>
    /// ID of the SSH key sync group to assign this account to. (Read-only)  NOTE: SSH key Sync group takes precedence over SSH key profile setting above. Profile will be explicitly set.  NOTE: SSH key Sync priority will be set to 0.
    /// </summary>
    /// <value>ID of the SSH key sync group to assign this account to. (Read-only)  NOTE: SSH key Sync group takes precedence over SSH key profile setting above. Profile will be explicitly set.  NOTE: SSH key Sync priority will be set to 0.</value>
    [DataMember(Name="SshKeySyncGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeySyncGroupId")]
    public int? SshKeySyncGroupId { get; set; }

    /// <summary>
    /// The name of the SSH key sync group to be assigned to the newly managed account (Read-only)
    /// </summary>
    /// <value>The name of the SSH key sync group to be assigned to the newly managed account (Read-only)</value>
    [DataMember(Name="SshKeySyncGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeySyncGroupName")]
    public string SshKeySyncGroupName { get; set; }

    /// <summary>
    /// The priority to assign to discovered accounts in the SSH key sync group
    /// </summary>
    /// <value>The priority to assign to discovered accounts in the SSH key sync group</value>
    [DataMember(Name="SshKeySyncGroupPriority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeySyncGroupPriority")]
    public int? SshKeySyncGroupPriority { get; set; }

    /// <summary>
    /// Whether the initial password of the account should be set
    /// </summary>
    /// <value>Whether the initial password of the account should be set</value>
    [DataMember(Name="SetInitialPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SetInitialPassword")]
    public bool? SetInitialPassword { get; set; }

    /// <summary>
    /// The initial password to store for this account (Write-only)
    /// </summary>
    /// <value>The initial password to store for this account (Write-only)</value>
    [DataMember(Name="InitialPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InitialPassword")]
    public string InitialPassword { get; set; }

    /// <summary>
    /// Whether an initial password value is set (Read-only)
    /// </summary>
    /// <value>Whether an initial password value is set (Read-only)</value>
    [DataMember(Name="HasInitialPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasInitialPassword")]
    public bool? HasInitialPassword { get; set; }

    /// <summary>
    /// Whether the initial SSH key of the account should be set
    /// </summary>
    /// <value>Whether the initial SSH key of the account should be set</value>
    [DataMember(Name="SetInitialSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SetInitialSshKey")]
    public bool? SetInitialSshKey { get; set; }

    /// <summary>
    /// Gets or Sets InitialSshKey
    /// </summary>
    [DataMember(Name="InitialSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "InitialSshKey")]
    public SystemSshKey InitialSshKey { get; set; }

    /// <summary>
    /// Whether an initial SSH key value is set (Read-only)
    /// </summary>
    /// <value>Whether an initial SSH key value is set (Read-only)</value>
    [DataMember(Name="HasInitialSshKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasInitialSshKey")]
    public bool? HasInitialSshKey { get; set; }

    /// <summary>
    /// The tags to be associated with the newly managed account
    /// </summary>
    /// <value>The tags to be associated with the newly managed account</value>
    [DataMember(Name="Tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Tags")]
    public List<Tag> Tags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountTemplate {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
      sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
      sb.Append("  SshKeyProfileId: ").Append(SshKeyProfileId).Append("\n");
      sb.Append("  SshKeyProfileName: ").Append(SshKeyProfileName).Append("\n");
      sb.Append("  AllowPasswordRelease: ").Append(AllowPasswordRelease).Append("\n");
      sb.Append("  AllowSessionRelease: ").Append(AllowSessionRelease).Append("\n");
      sb.Append("  AllowSshKeyRelease: ").Append(AllowSshKeyRelease).Append("\n");
      sb.Append("  SharedServiceAccount: ").Append(SharedServiceAccount).Append("\n");
      sb.Append("  SyncGroupId: ").Append(SyncGroupId).Append("\n");
      sb.Append("  SyncGroupName: ").Append(SyncGroupName).Append("\n");
      sb.Append("  SyncGroupPriority: ").Append(SyncGroupPriority).Append("\n");
      sb.Append("  SshKeySyncGroupId: ").Append(SshKeySyncGroupId).Append("\n");
      sb.Append("  SshKeySyncGroupName: ").Append(SshKeySyncGroupName).Append("\n");
      sb.Append("  SshKeySyncGroupPriority: ").Append(SshKeySyncGroupPriority).Append("\n");
      sb.Append("  SetInitialPassword: ").Append(SetInitialPassword).Append("\n");
      sb.Append("  InitialPassword: ").Append(InitialPassword).Append("\n");
      sb.Append("  HasInitialPassword: ").Append(HasInitialPassword).Append("\n");
      sb.Append("  SetInitialSshKey: ").Append(SetInitialSshKey).Append("\n");
      sb.Append("  InitialSshKey: ").Append(InitialSshKey).Append("\n");
      sb.Append("  HasInitialSshKey: ").Append(HasInitialSshKey).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
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
