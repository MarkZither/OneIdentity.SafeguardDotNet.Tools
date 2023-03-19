using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Access Request Activity Log
  /// </summary>
  [DataContract]
  public class AccessRequestActivityLog {
    /// <summary>
    /// Database ID of this log entry
    /// </summary>
    /// <value>Database ID of this log entry</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Time the change occurred (Read-only)
    /// </summary>
    /// <value>Time the change occurred (Read-only)</value>
    [DataMember(Name="LogTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogTime")]
    public DateTime? LogTime { get; set; }

    /// <summary>
    /// Unique id of the user that caused the change (Read-only).
    /// </summary>
    /// <value>Unique id of the user that caused the change (Read-only).</value>
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
    /// ID of the access request
    /// </summary>
    /// <value>ID of the access request</value>
    [DataMember(Name="RequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestId")]
    public string RequestId { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// ID of the requester
    /// </summary>
    /// <value>ID of the requester</value>
    [DataMember(Name="RequesterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterId")]
    public int? RequesterId { get; set; }

    /// <summary>
    /// Name of the requester
    /// </summary>
    /// <value>Name of the requester</value>
    [DataMember(Name="RequesterName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequesterName")]
    public string RequesterName { get; set; }

    /// <summary>
    /// ID of the broker
    /// </summary>
    /// <value>ID of the broker</value>
    [DataMember(Name="BrokerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrokerId")]
    public int? BrokerId { get; set; }

    /// <summary>
    /// Name of the broker
    /// </summary>
    /// <value>Name of the broker</value>
    [DataMember(Name="BrokerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BrokerName")]
    public string BrokerName { get; set; }

    /// <summary>
    /// ID of the account being requested
    /// </summary>
    /// <value>ID of the account being requested</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account being requested
    /// </summary>
    /// <value>Name of the account being requested</value>
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
    /// Id of the asset that has been requested access to
    /// </summary>
    /// <value>Id of the asset that has been requested access to</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset that has been requested access to
    /// </summary>
    /// <value>Name of the asset that has been requested access to</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Network address of the asset that has been requested access to
    /// </summary>
    /// <value>Network address of the asset that has been requested access to</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// Database ID of the partition the asset belongs to
    /// </summary>
    /// <value>Database ID of the partition the asset belongs to</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name  of the partition the asset belongs to
    /// </summary>
    /// <value>Name  of the partition the asset belongs to</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Id of the session that was initialized (if applicable)
    /// </summary>
    /// <value>Id of the session that was initialized (if applicable)</value>
    [DataMember(Name="SessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionId")]
    public int? SessionId { get; set; }

    /// <summary>
    /// Time when request was submitted
    /// </summary>
    /// <value>Time when request was submitted</value>
    [DataMember(Name="SubmittedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubmittedDate")]
    public DateTime? SubmittedDate { get; set; }

    /// <summary>
    /// Gets or Sets OldState
    /// </summary>
    [DataMember(Name="OldState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldState")]
    public AccessRequestState OldState { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name="Action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Action")]
    public AccessRequestStateAction Action { get; set; }

    /// <summary>
    /// Gets or Sets NewState
    /// </summary>
    [DataMember(Name="NewState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NewState")]
    public AccessRequestState NewState { get; set; }

    /// <summary>
    /// Comment supplied with action
    /// </summary>
    /// <value>Comment supplied with action</value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Gets or Sets RecordingProperties
    /// </summary>
    [DataMember(Name="RecordingProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RecordingProperties")]
    public SessionRecordingProperties RecordingProperties { get; set; }

    /// <summary>
    /// True if the appliance was in offline workflow mode at the time of the log
    /// </summary>
    /// <value>True if the appliance was in offline workflow mode at the time of the log</value>
    [DataMember(Name="OfflineWorkflow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OfflineWorkflow")]
    public bool? OfflineWorkflow { get; set; }

    /// <summary>
    /// Request reason code
    /// </summary>
    /// <value>Request reason code</value>
    [DataMember(Name="ReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCode")]
    public int? ReasonCode { get; set; }

    /// <summary>
    /// Request reason name
    /// </summary>
    /// <value>Request reason name</value>
    [DataMember(Name="ReasonName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonName")]
    public string ReasonName { get; set; }

    /// <summary>
    /// Request reason comment
    /// </summary>
    /// <value>Request reason comment</value>
    [DataMember(Name="ReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonComment")]
    public string ReasonComment { get; set; }

    /// <summary>
    /// Request ticket number
    /// </summary>
    /// <value>Request ticket number</value>
    [DataMember(Name="TicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TicketNumber")]
    public string TicketNumber { get; set; }

    /// <summary>
    /// If request was for emergency
    /// </summary>
    /// <value>If request was for emergency</value>
    [DataMember(Name="IsEmergency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmergency")]
    public bool? IsEmergency { get; set; }

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
      sb.Append("class AccessRequestActivityLog {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  RequesterId: ").Append(RequesterId).Append("\n");
      sb.Append("  RequesterName: ").Append(RequesterName).Append("\n");
      sb.Append("  BrokerId: ").Append(BrokerId).Append("\n");
      sb.Append("  BrokerName: ").Append(BrokerName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
      sb.Append("  OldState: ").Append(OldState).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  NewState: ").Append(NewState).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  RecordingProperties: ").Append(RecordingProperties).Append("\n");
      sb.Append("  OfflineWorkflow: ").Append(OfflineWorkflow).Append("\n");
      sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
      sb.Append("  ReasonName: ").Append(ReasonName).Append("\n");
      sb.Append("  ReasonComment: ").Append(ReasonComment).Append("\n");
      sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
      sb.Append("  IsEmergency: ").Append(IsEmergency).Append("\n");
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
