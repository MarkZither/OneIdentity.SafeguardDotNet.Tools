using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An action/activity performed by a user
  /// </summary>
  [DataContract]
  public class AuditSearchLog {
    /// <summary>
    /// Database ID of this log entry
    /// </summary>
    /// <value>Database ID of this log entry</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// The date the activity occurred
    /// </summary>
    /// <value>The date the activity occurred</value>
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
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public AuditLogCategory Category { get; set; }

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
    /// Gets or Sets ErrorType
    /// </summary>
    [DataMember(Name="ErrorType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorType")]
    public AuthenticationErrorType ErrorType { get; set; }

    /// <summary>
    /// Gets or Sets ObjectType
    /// </summary>
    [DataMember(Name="ObjectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectType")]
    public ObjectType ObjectType { get; set; }

    /// <summary>
    /// ID of object
    /// </summary>
    /// <value>ID of object</value>
    [DataMember(Name="ObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectId")]
    public string ObjectId { get; set; }

    /// <summary>
    /// Name of object
    /// </summary>
    /// <value>Name of object</value>
    [DataMember(Name="ObjectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectName")]
    public string ObjectName { get; set; }

    /// <summary>
    /// Access request ID
    /// </summary>
    /// <value>Access request ID</value>
    [DataMember(Name="RequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestId")]
    public string RequestId { get; set; }

    /// <summary>
    /// Access request session ID
    /// </summary>
    /// <value>Access request session ID</value>
    [DataMember(Name="SessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionId")]
    public int? SessionId { get; set; }

    /// <summary>
    /// Gets or Sets RecordingProperties
    /// </summary>
    [DataMember(Name="RecordingProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingProperties")]
    public SessionRecordingProperties RecordingProperties { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Requester ID
    /// </summary>
    /// <value>Requester ID</value>
    [DataMember(Name="RequesterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterId")]
    public int? RequesterId { get; set; }

    /// <summary>
    /// Requester name
    /// </summary>
    /// <value>Requester name</value>
    [DataMember(Name="RequesterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterName")]
    public string RequesterName { get; set; }

    /// <summary>
    /// Account ID
    /// </summary>
    /// <value>Account ID</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Account name
    /// </summary>
    /// <value>Account name</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Account domain name
    /// </summary>
    /// <value>Account domain name</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// Asset ID
    /// </summary>
    /// <value>Asset ID</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Asset name
    /// </summary>
    /// <value>Asset name</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Asset network address
    /// </summary>
    /// <value>Asset network address</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// Asset Partition ID
    /// </summary>
    /// <value>Asset Partition ID</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Asset Partition name
    /// </summary>
    /// <value>Asset Partition name</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Gets or Sets TaskName
    /// </summary>
    [DataMember(Name="TaskName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaskName")]
    public TaskNames TaskName { get; set; }

    /// <summary>
    /// Gets or Sets LicenseType
    /// </summary>
    [DataMember(Name="LicenseType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LicenseType")]
    public LicensableModule LicenseType { get; set; }

    /// <summary>
    /// Request submission date
    /// </summary>
    /// <value>Request submission date</value>
    [DataMember(Name="SubmittedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubmittedDate")]
    public DateTime? SubmittedDate { get; set; }

    /// <summary>
    /// Supplemental data associated with the event, e.g., session commands
    /// </summary>
    /// <value>Supplemental data associated with the event, e.g., session commands</value>
    [DataMember(Name="Data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Data")]
    public string Data { get; set; }

    /// <summary>
    /// Session node IpAddress that serves the session request.
    /// </summary>
    /// <value>Session node IpAddress that serves the session request.</value>
    [DataMember(Name="SessionSpsNodeIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionSpsNodeIpAddress")]
    public string SessionSpsNodeIpAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuditSearchLog {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  RecordingProperties: ").Append(RecordingProperties).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
      sb.Append("  RequesterName: ").Append(RequesterName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  TaskName: ").Append(TaskName).Append("\n");
      sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
      sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  SessionSpsNodeIpAddress: ").Append(SessionSpsNodeIpAddress).Append("\n");
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
