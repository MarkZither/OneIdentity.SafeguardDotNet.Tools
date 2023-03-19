using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a scheduled platform task
  /// </summary>
  [DataContract]
  public class ScheduledTask {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public ScheduledTaskNames Name { get; set; }

    /// <summary>
    /// Unique ID of account associated with task
    /// </summary>
    /// <value>Unique ID of account associated with task</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of account associated with task
    /// </summary>
    /// <value>Name of account associated with task</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name of account associated with task
    /// </summary>
    /// <value>Domain name of account associated with task</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Unique ID of asset associated with task
    /// </summary>
    /// <value>Unique ID of asset associated with task</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of asset associated with task
    /// </summary>
    /// <value>Name of asset associated with task</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Unique ID of sync group associated with task
    /// </summary>
    /// <value>Unique ID of sync group associated with task</value>
    [DataMember(Name="SyncGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupId")]
    public int? SyncGroupId { get; set; }

    /// <summary>
    /// Name of sync group associated with task
    /// </summary>
    /// <value>Name of sync group associated with task</value>
    [DataMember(Name="SyncGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyncGroupName")]
    public string SyncGroupName { get; set; }

    /// <summary>
    /// Unique ID of schedule associated with task
    /// </summary>
    /// <value>Unique ID of schedule associated with task</value>
    [DataMember(Name="ScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduleId")]
    public int? ScheduleId { get; set; }

    /// <summary>
    /// Name of schedule associated with task
    /// </summary>
    /// <value>Name of schedule associated with task</value>
    [DataMember(Name="ScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScheduleName")]
    public string ScheduleName { get; set; }

    /// <summary>
    /// Unique ID of asset partition associated with task
    /// </summary>
    /// <value>Unique ID of asset partition associated with task</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of asset partition associated with task
    /// </summary>
    /// <value>Name of asset partition associated with task</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Date task is scheduled for
    /// </summary>
    /// <value>Date task is scheduled for</value>
    [DataMember(Name="DueDateTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DueDateTime")]
    public DateTime? DueDateTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ScheduledTask {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  SyncGroupId: ").Append(SyncGroupId).Append("\n");
      sb.Append("  SyncGroupName: ").Append(SyncGroupName).Append("\n");
      sb.Append("  ScheduleId: ").Append(ScheduleId).Append("\n");
      sb.Append("  ScheduleName: ").Append(ScheduleName).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  DueDateTime: ").Append(DueDateTime).Append("\n");
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
