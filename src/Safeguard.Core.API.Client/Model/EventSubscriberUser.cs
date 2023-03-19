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
  public class EventSubscriberUser {
    /// <summary>
    /// Whether this event subscriber is disabled for the current user
    /// </summary>
    /// <value>Whether this event subscriber is disabled for the current user</value>
    [DataMember(Name="Disabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Disabled")]
    public bool? Disabled { get; set; }

    /// <summary>
    /// Unique key of the subscriber.
    /// </summary>
    /// <value>Unique key of the subscriber.</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Subscriber description
    /// </summary>
    /// <value>Subscriber description</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public EventSubscriberType Type { get; set; }

    /// <summary>
    /// Database ID of user to send notification to (defaults to calling user). Required for EventSubscriberType of Signalr. Supported by EventSubscriberType of Email.
    /// </summary>
    /// <value>Database ID of user to send notification to (defaults to calling user). Required for EventSubscriberType of Signalr. Supported by EventSubscriberType of Email.</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// DisplayName of user to send notification to (Read-only)
    /// </summary>
    /// <value>DisplayName of user to send notification to (Read-only)</value>
    [DataMember(Name="UserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDisplayName")]
    public string UserDisplayName { get; set; }

    /// <summary>
    /// Email address user to send notification to (Read-only)
    /// </summary>
    /// <value>Email address user to send notification to (Read-only)</value>
    [DataMember(Name="UserEmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserEmailAddress")]
    public string UserEmailAddress { get; set; }

    /// <summary>
    /// Subscriber email address. Supported by EventSubscriberType of Email. Cannot be specified with UserId.
    /// </summary>
    /// <value>Subscriber email address. Supported by EventSubscriberType of Email. Cannot be specified with UserId.</value>
    [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailAddress")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or Sets SyslogProperties
    /// </summary>
    [DataMember(Name="SyslogProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyslogProperties")]
    public SyslogSubscriberProperties SyslogProperties { get; set; }

    /// <summary>
    /// Gets or Sets SnmpProperties
    /// </summary>
    [DataMember(Name="SnmpProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SnmpProperties")]
    public SnmpSubscriberProperties SnmpProperties { get; set; }

    /// <summary>
    /// Gets or Sets ObjectType
    /// </summary>
    [DataMember(Name="ObjectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectType")]
    public EventObjectType ObjectType { get; set; }

    /// <summary>
    /// Id of the object to subscribe to
    /// </summary>
    /// <value>Id of the object to subscribe to</value>
    [DataMember(Name="ObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectId")]
    public int? ObjectId { get; set; }

    /// <summary>
    /// Whether this event subscriber is manageable by all appliance admins.  The property is read-only for all users except the user that originally created the subscriber.
    /// </summary>
    /// <value>Whether this event subscriber is manageable by all appliance admins.  The property is read-only for all users except the user that originally created the subscriber.</value>
    [DataMember(Name="IsApplianceShared", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsApplianceShared")]
    public bool? IsApplianceShared { get; set; }

    /// <summary>
    /// Will automatically subscribe to all events allowed by the user's permissions
    /// </summary>
    /// <value>Will automatically subscribe to all events allowed by the user's permissions</value>
    [DataMember(Name="SubscribeToAllEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscribeToAllEvents")]
    public bool? SubscribeToAllEvents { get; set; }

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
    /// Whether this is a built-in event subscriber that cannot be modified (Read-only)
    /// </summary>
    /// <value>Whether this is a built-in event subscriber that cannot be modified (Read-only)</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

    /// <summary>
    /// Whether partition owners are subscribed. If there are no explicit partition owners then users with the AssetAdmin role will be notified. (Read-only)
    /// </summary>
    /// <value>Whether partition owners are subscribed. If there are no explicit partition owners then users with the AssetAdmin role will be notified. (Read-only)</value>
    [DataMember(Name="PartitionOwnerIsSubscribed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PartitionOwnerIsSubscribed")]
    public bool? PartitionOwnerIsSubscribed { get; set; }

    /// <summary>
    /// Users with these administrative roles are subscribed. e.g. GlobalAdmin, Auditor, ApplicationAuditor, SystemAuditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin (Read-Only)
    /// </summary>
    /// <value>Users with these administrative roles are subscribed. e.g. GlobalAdmin, Auditor, ApplicationAuditor, SystemAuditor, AssetAdmin, ApplianceAdmin, PolicyAdmin, UserAdmin, HelpdeskAdmin, OperationsAdmin (Read-Only)</value>
    [DataMember(Name="AdminRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdminRoles")]
    public List<AdminRoleName> AdminRoles { get; set; }

    /// <summary>
    /// Whether workflow users are subscribed (Read-only)
    /// </summary>
    /// <value>Whether workflow users are subscribed (Read-only)</value>
    [DataMember(Name="WorkflowUserIsSubscribed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "WorkflowUserIsSubscribed")]
    public bool? WorkflowUserIsSubscribed { get; set; }

    /// <summary>
    /// Events that are subscribed to
    /// </summary>
    /// <value>Events that are subscribed to</value>
    [DataMember(Name="Subscriptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subscriptions")]
    public List<EventSubscription> Subscriptions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventSubscriberUser {\n");
      sb.Append("  Disabled: ").Append(Disabled).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
      sb.Append("  UserEmailAddress: ").Append(UserEmailAddress).Append("\n");
      sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
      sb.Append("  SyslogProperties: ").Append(SyslogProperties).Append("\n");
      sb.Append("  SnmpProperties: ").Append(SnmpProperties).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  IsApplianceShared: ").Append(IsApplianceShared).Append("\n");
      sb.Append("  SubscribeToAllEvents: ").Append(SubscribeToAllEvents).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  PartitionOwnerIsSubscribed: ").Append(PartitionOwnerIsSubscribed).Append("\n");
      sb.Append("  AdminRoles: ").Append(AdminRoles).Append("\n");
      sb.Append("  WorkflowUserIsSubscribed: ").Append(WorkflowUserIsSubscribed).Append("\n");
      sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
