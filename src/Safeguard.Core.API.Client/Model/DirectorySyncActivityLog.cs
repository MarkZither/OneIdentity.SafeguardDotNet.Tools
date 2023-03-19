using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a directory sync task
  /// </summary>
  [DataContract]
  public class DirectorySyncActivityLog {
    /// <summary>
    /// ID of the task (Read-only)
    /// </summary>
    /// <value>ID of the task (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The date the task was created
    /// </summary>
    /// <value>The date the task was created</value>
    [DataMember(Name="LogTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogTime")]
    public DateTime? LogTime { get; set; }

    /// <summary>
    /// The database ID of the user that performed the activity
    /// </summary>
    /// <value>The database ID of the user that performed the activity</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// Id of appliance
    /// </summary>
    /// <value>Id of appliance</value>
    [DataMember(Name="ApplianceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceId")]
    public string ApplianceId { get; set; }

    /// <summary>
    /// Name of appliance
    /// </summary>
    /// <value>Name of appliance</value>
    [DataMember(Name="ApplianceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ApplianceName")]
    public string ApplianceName { get; set; }

    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name="EventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventName")]
    public EventName EventName { get; set; }

    /// <summary>
    /// Name of the event
    /// </summary>
    /// <value>Name of the event</value>
    [DataMember(Name="EventDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventDisplayName")]
    public string EventDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public TaskNames Name { get; set; }

    /// <summary>
    /// Database ID of the asset or directory to execute this task on
    /// </summary>
    /// <value>Database ID of the asset or directory to execute this task on</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset or directory the task was executed against (Read-only)
    /// </summary>
    /// <value>Name of the asset or directory the task was executed against (Read-only)</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// The database ID of the platform of the asset.
    /// </summary>
    /// <value>The database ID of the platform of the asset.</value>
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
    /// Display Name of the platform of the asset (Read-only)
    /// </summary>
    /// <value>Display Name of the platform of the asset (Read-only)</value>
    [DataMember(Name="PlatformDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PlatformDisplayName")]
    public string PlatformDisplayName { get; set; }

    /// <summary>
    /// Network DNS name or IP address used to connect to the machine over the network.
    /// </summary>
    /// <value>Network DNS name or IP address used to connect to the machine over the network.</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// The database ID of the asset partition this asset belongs to (Read-only)
    /// </summary>
    /// <value>The database ID of the asset partition this asset belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition this asset belongs to (Read-only)
    /// </summary>
    /// <value>Name of the asset partition this asset belongs to (Read-only)</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Gets or Sets RequestStatus
    /// </summary>
    [DataMember(Name="RequestStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestStatus")]
    public RequestStatus RequestStatus { get; set; }

    /// <summary>
    /// Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)
    /// </summary>
    /// <value>Detailed log of task execution. Only populated in results from the Tasks resource (Read-only)</value>
    [DataMember(Name="Log", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Log")]
    public List<TaskLog> Log { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public AssetConnectionProperties ConnectionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DirectorySyncActivityLog {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  PlatformId: ").Append(PlatformId).Append("\n");
      sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
      sb.Append("  PlatformDisplayName: ").Append(PlatformDisplayName).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  RequestStatus: ").Append(RequestStatus).Append("\n");
      sb.Append("  Log: ").Append(Log).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
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
