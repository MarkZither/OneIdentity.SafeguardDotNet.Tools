using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an asynchronous task on the appliance that is running
  /// </summary>
  [DataContract]
  public class RunningTask {
    /// <summary>
    /// Unique ID of the task
    /// </summary>
    /// <value>Unique ID of the task</value>
    [DataMember(Name="TaskId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaskId")]
    public string TaskId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public TaskNames Name { get; set; }

    /// <summary>
    /// Appliance that task is running on
    /// </summary>
    /// <value>Appliance that task is running on</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Gets or Sets RequestStatus
    /// </summary>
    [DataMember(Name="RequestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestStatus")]
    public RequestStatus RequestStatus { get; set; }

    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// Name of the asset discovery job (Read-only)
    /// </summary>
    /// <value>Name of the asset discovery job (Read-only)</value>
    [DataMember(Name="AssetDiscoveryJobName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDiscoveryJobName")]
    public string AssetDiscoveryJobName { get; set; }

    /// <summary>
    /// Gets or Sets AssetDiscoveryType
    /// </summary>
    [DataMember(Name="AssetDiscoveryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDiscoveryType")]
    public AssetDiscoveryType AssetDiscoveryType { get; set; }

    /// <summary>
    /// The asset partition this job belongs to (Read-only)
    /// </summary>
    /// <value>The asset partition this job belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition this job belongs to (Read-only)
    /// </summary>
    /// <value>Name of the asset partition this job belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Database ID of the asset or directory to execute this task on
    /// </summary>
    /// <value>Database ID of the asset or directory to execute this task on</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset or directory name the task was executed against (Read-only)
    /// </summary>
    /// <value>Name of the asset or directory name the task was executed against (Read-only)</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Account to run this task for
    /// </summary>
    /// <value>Account to run this task for</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account this task is for (Read-only)
    /// </summary>
    /// <value>Name of the account this task is for (Read-only)</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// ID of the profile to run this task for
    /// </summary>
    /// <value>ID of the profile to run this task for</value>
    [DataMember(Name="ProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileId")]
    public int? ProfileId { get; set; }

    /// <summary>
    /// Name of the profile this task is for (Read-only)
    /// </summary>
    /// <value>Name of the profile this task is for (Read-only)</value>
    [DataMember(Name="ProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProfileName")]
    public string ProfileName { get; set; }

    /// <summary>
    /// ID of the sync group to run this task for
    /// </summary>
    /// <value>ID of the sync group to run this task for</value>
    [DataMember(Name="SyncGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupId")]
    public int? SyncGroupId { get; set; }

    /// <summary>
    /// Name of the sync group this task is for (Read-only)
    /// </summary>
    /// <value>Name of the sync group this task is for (Read-only)</value>
    [DataMember(Name="SyncGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupName")]
    public string SyncGroupName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RunningTask {\n");
      sb.Append("  TaskId: ").Append(TaskId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  AssetDiscoveryJobName: ").Append(AssetDiscoveryJobName).Append("\n");
      sb.Append("  AssetDiscoveryType: ").Append(AssetDiscoveryType).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
      sb.Append("  ProfileName: ").Append(ProfileName).Append("\n");
      sb.Append("  SyncGroupId: ").Append(SyncGroupId).Append("\n");
      sb.Append("  SyncGroupName: ").Append(SyncGroupName).Append("\n");
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
