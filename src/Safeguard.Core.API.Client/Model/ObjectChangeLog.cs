using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a single event change on the server
  /// </summary>
  [DataContract]
  public class ObjectChangeLog {
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
    /// Gets or Sets OperationType
    /// </summary>
    [DataMember(Name="OperationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OperationType")]
    public OperationType OperationType { get; set; }

    /// <summary>
    /// Gets or Sets EventName
    /// </summary>
    [DataMember(Name="EventName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventName")]
    public EventName EventName { get; set; }

    /// <summary>
    /// The event display name that caused the change (Read-only)
    /// </summary>
    /// <value>The event display name that caused the change (Read-only)</value>
    [DataMember(Name="EventDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EventDisplayName")]
    public string EventDisplayName { get; set; }

    /// <summary>
    /// Extra info clarifying the event (Read-only)
    /// </summary>
    /// <value>Extra info clarifying the event (Read-only)</value>
    [DataMember(Name="Message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Message")]
    public string Message { get; set; }

    /// <summary>
    /// The database ID of the object that was changed (Read-only).
    /// </summary>
    /// <value>The database ID of the object that was changed (Read-only).</value>
    [DataMember(Name="ObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectId")]
    public string ObjectId { get; set; }

    /// <summary>
    /// Gets or Sets ObjectType
    /// </summary>
    [DataMember(Name="ObjectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectType")]
    public ObjectType ObjectType { get; set; }

    /// <summary>
    /// The name of the object that was changed (Read-only).
    /// </summary>
    /// <value>The name of the object that was changed (Read-only).</value>
    [DataMember(Name="ObjectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectName")]
    public string ObjectName { get; set; }

    /// <summary>
    /// Gets or Sets ParentObjectType
    /// </summary>
    [DataMember(Name="ParentObjectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentObjectType")]
    public ObjectType ParentObjectType { get; set; }

    /// <summary>
    /// The database ID of the parent of the object that was changed (Read-only).
    /// </summary>
    /// <value>The database ID of the parent of the object that was changed (Read-only).</value>
    [DataMember(Name="ParentObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentObjectId")]
    public string ParentObjectId { get; set; }

    /// <summary>
    /// The name of the parent of the object that was changed (Read-only).
    /// </summary>
    /// <value>The name of the parent of the object that was changed (Read-only).</value>
    [DataMember(Name="ParentObjectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ParentObjectName")]
    public string ParentObjectName { get; set; }

    /// <summary>
    /// Gets or Sets RelatedObjectType
    /// </summary>
    [DataMember(Name="RelatedObjectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RelatedObjectType")]
    public ObjectType RelatedObjectType { get; set; }

    /// <summary>
    /// The database ID of the object relating to this change (Read-only).
    /// </summary>
    /// <value>The database ID of the object relating to this change (Read-only).</value>
    [DataMember(Name="RelatedObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RelatedObjectId")]
    public string RelatedObjectId { get; set; }

    /// <summary>
    /// The name of the object relating to this change (Read-only).
    /// </summary>
    /// <value>The name of the object relating to this change (Read-only).</value>
    [DataMember(Name="RelatedObjectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RelatedObjectName")]
    public string RelatedObjectName { get; set; }

    /// <summary>
    /// The original JSON-encoded entity values (Read-only).
    /// </summary>
    /// <value>The original JSON-encoded entity values (Read-only).</value>
    [DataMember(Name="OldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OldValue")]
    public string OldValue { get; set; }

    /// <summary>
    /// The new JSON-encoded entity values (Read-only).
    /// </summary>
    /// <value>The new JSON-encoded entity values (Read-only).</value>
    [DataMember(Name="NewValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NewValue")]
    public string NewValue { get; set; }

    /// <summary>
    /// The database ID of the related asset partition (Read-only).
    /// </summary>
    /// <value>The database ID of the related asset partition (Read-only).</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// The name of the related asset partition (Read-only).
    /// </summary>
    /// <value>The name of the related asset partition (Read-only).</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// The network address of the related asset (Read-only).
    /// </summary>
    /// <value>The network address of the related asset (Read-only).</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// Gets or Sets UserProperties
    /// </summary>
    [DataMember(Name="UserProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserProperties")]
    public UserLogProperties UserProperties { get; set; }

    /// <summary>
    /// Changes made to the object for this entry
    /// </summary>
    /// <value>Changes made to the object for this entry</value>
    [DataMember(Name="Changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Changes")]
    public List<PropertyChange> Changes { get; set; }

    /// <summary>
    /// Gets or Sets SessionSpsNodeIpAddress
    /// </summary>
    [DataMember(Name="SessionSpsNodeIpAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionSpsNodeIpAddress")]
    public string SessionSpsNodeIpAddress { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ObjectChangeLog {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  LogTime: ").Append(LogTime).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  ApplianceId: ").Append(ApplianceId).Append("\n");
      sb.Append("  ApplianceName: ").Append(ApplianceName).Append("\n");
      sb.Append("  OperationType: ").Append(OperationType).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDisplayName: ").Append(EventDisplayName).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
      sb.Append("  ParentObjectType: ").Append(ParentObjectType).Append("\n");
      sb.Append("  ParentObjectId: ").Append(ParentObjectId).Append("\n");
      sb.Append("  ParentObjectName: ").Append(ParentObjectName).Append("\n");
      sb.Append("  RelatedObjectType: ").Append(RelatedObjectType).Append("\n");
      sb.Append("  RelatedObjectId: ").Append(RelatedObjectId).Append("\n");
      sb.Append("  RelatedObjectName: ").Append(RelatedObjectName).Append("\n");
      sb.Append("  OldValue: ").Append(OldValue).Append("\n");
      sb.Append("  NewValue: ").Append(NewValue).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
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
