using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a group of accounts in a profile whose SSH keys must be the same. All accounts will be updated in priority order  when a SSH key change is requested.
  /// </summary>
  [DataContract]
  public class SshKeySyncGroup {
    /// <summary>
    /// Unique ID of the sync group (Read-Only)
    /// </summary>
    /// <value>Unique ID of the sync group (Read-Only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the sync group
    /// </summary>
    /// <value>Name of the sync group</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the sync group
    /// </summary>
    /// <value>Description of the sync group</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Unique ID of the profile this sync group belongs to
    /// </summary>
    /// <value>Unique ID of the profile this sync group belongs to</value>
    [DataMember(Name="ProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileId")]
    public int? ProfileId { get; set; }

    /// <summary>
    /// Name of the profile this sync group belongs to
    /// </summary>
    /// <value>Name of the profile this sync group belongs to</value>
    [DataMember(Name="ProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileName")]
    public string ProfileName { get; set; }

    /// <summary>
    /// Whether platform tasks can run against this sync group
    /// </summary>
    /// <value>Whether platform tasks can run against this sync group</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Unique ID of the asset partition this sync group belongs to
    /// </summary>
    /// <value>Unique ID of the asset partition this sync group belongs to</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the partition this sync group belongs to
    /// </summary>
    /// <value>Name of the partition this sync group belongs to</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

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
    /// The date/time of the last SshKey change (Read-only)
    /// </summary>
    /// <value>The date/time of the last SshKey change (Read-only)</value>
    [DataMember(Name="LastSyncAccountsDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSyncAccountsDate")]
    public DateTime? LastSyncAccountsDate { get; set; }

    /// <summary>
    /// The date/time of the last successful SshKey change (Read-only)
    /// </summary>
    /// <value>The date/time of the last successful SshKey change (Read-only)</value>
    [DataMember(Name="LastSuccessSyncAccountsDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSuccessSyncAccountsDate")]
    public DateTime? LastSuccessSyncAccountsDate { get; set; }

    /// <summary>
    /// The date/time of the last failed SshKey change (Read-only)
    /// </summary>
    /// <value>The date/time of the last failed SshKey change (Read-only)</value>
    [DataMember(Name="LastFailureSyncAccountsDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastFailureSyncAccountsDate")]
    public DateTime? LastFailureSyncAccountsDate { get; set; }

    /// <summary>
    /// The task audit log ID of the last SshKey change (Read-only)
    /// </summary>
    /// <value>The task audit log ID of the last SshKey change (Read-only)</value>
    [DataMember(Name="LastSyncAccountsTaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LastSyncAccountsTaskId")]
    public string LastSyncAccountsTaskId { get; set; }

    /// <summary>
    /// Number of subsequent failed SshKey change attempts since last success (Read-only)
    /// </summary>
    /// <value>Number of subsequent failed SshKey change attempts since last success (Read-only)</value>
    [DataMember(Name="FailedSyncAccountsAttempts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FailedSyncAccountsAttempts")]
    public int? FailedSyncAccountsAttempts { get; set; }

    /// <summary>
    /// The date/time of the next SshKey change, if this account is enabled for automatic SshKey management (Read-only)
    /// </summary>
    /// <value>The date/time of the next SshKey change, if this account is enabled for automatic SshKey management (Read-only)</value>
    [DataMember(Name="NextSyncAccountsDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NextSyncAccountsDate")]
    public DateTime? NextSyncAccountsDate { get; set; }

    /// <summary>
    /// Whether all of the accounts for this sync group are currently synchronized
    /// </summary>
    /// <value>Whether all of the accounts for this sync group are currently synchronized</value>
    [DataMember(Name="IsSynchronized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSynchronized")]
    public bool? IsSynchronized { get; set; }

    /// <summary>
    /// Set of accounts that are assigned to this sync group
    /// </summary>
    /// <value>Set of accounts that are assigned to this sync group</value>
    [DataMember(Name="Accounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Accounts")]
    public List<SshKeySyncGroupAccount> Accounts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SshKeySyncGroup {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
      sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  LastSyncAccountsDate: ").Append(LastSyncAccountsDate).Append("\n");
      sb.Append("  LastSuccessSyncAccountsDate: ").Append(LastSuccessSyncAccountsDate).Append("\n");
      sb.Append("  LastFailureSyncAccountsDate: ").Append(LastFailureSyncAccountsDate).Append("\n");
      sb.Append("  LastSyncAccountsTaskId: ").Append(LastSyncAccountsTaskId).Append("\n");
      sb.Append("  FailedSyncAccountsAttempts: ").Append(FailedSyncAccountsAttempts).Append("\n");
      sb.Append("  NextSyncAccountsDate: ").Append(NextSyncAccountsDate).Append("\n");
      sb.Append("  IsSynchronized: ").Append(IsSynchronized).Append("\n");
      sb.Append("  Accounts: ").Append(Accounts).Append("\n");
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
