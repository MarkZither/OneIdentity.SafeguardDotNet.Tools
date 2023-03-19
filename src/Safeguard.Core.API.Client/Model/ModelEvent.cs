using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An appliance or application event definition
  /// </summary>
  [DataContract]
  public class ModelEvent {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public EventName Name { get; set; }

    /// <summary>
    /// Display name of the event (Read-only)
    /// </summary>
    /// <value>Display name of the event (Read-only)</value>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Category display name of the event (Read-only)
    /// </summary>
    /// <value>Category display name of the event (Read-only)</value>
    [DataMember(Name="CategoryDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CategoryDisplayName")]
    public string CategoryDisplayName { get; set; }

    /// <summary>
    /// Does the event support the ActivityLog? (Read-only)
    /// </summary>
    /// <value>Does the event support the ActivityLog? (Read-only)</value>
    [DataMember(Name="ActivityLogFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ActivityLogFlag")]
    public bool? ActivityLogFlag { get; set; }

    /// <summary>
    /// Does the event support async broadcast notification to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncMcastFlag
    /// </summary>
    /// <value>Does the event support async broadcast notification to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncMcastFlag</value>
    [DataMember(Name="AsyncBroadcastFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AsyncBroadcastFlag")]
    public bool? AsyncBroadcastFlag { get; set; }

    /// <summary>
    /// Does the event support async multicast notifications to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncBcastFlag
    /// </summary>
    /// <value>Does the event support async multicast notifications to connected users? (Read-only) Mutually exclusive with  AsyncUcastFlag and AsyncBcastFlag</value>
    [DataMember(Name="AsyncMulticastFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AsyncMulticastFlag")]
    public bool? AsyncMulticastFlag { get; set; }

    /// <summary>
    /// Does the event support async unicast notification to connected users? (Read-only) Mutually exclusive with  AsyncBcastFlag and AsyncMcastFlag
    /// </summary>
    /// <value>Does the event support async unicast notification to connected users? (Read-only) Mutually exclusive with  AsyncBcastFlag and AsyncMcastFlag</value>
    [DataMember(Name="AsyncUnicastFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AsyncUnicastFlag")]
    public bool? AsyncUnicastFlag { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="Category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Category")]
    public EventCategory Category { get; set; }

    /// <summary>
    /// Brief description of the event (Read-only)
    /// </summary>
    /// <value>Brief description of the event (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Does the event support email notification? (Read-only)
    /// </summary>
    /// <value>Does the event support email notification? (Read-only)</value>
    [DataMember(Name="EmailFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EmailFlag")]
    public bool? EmailFlag { get; set; }

    /// <summary>
    /// Gets or Sets Level
    /// </summary>
    [DataMember(Name="Level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Level")]
    public EventLevel Level { get; set; }

    /// <summary>
    /// Whether this event supports object specific subscriptions (Read-only)
    /// </summary>
    /// <value>Whether this event supports object specific subscriptions (Read-only)</value>
    [DataMember(Name="IsObjectAware", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsObjectAware")]
    public bool? IsObjectAware { get; set; }

    /// <summary>
    /// Gets or Sets ObjectType
    /// </summary>
    [DataMember(Name="ObjectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectType")]
    public EventObjectType ObjectType { get; set; }

    /// <summary>
    /// Is this event obsolete? (Read-only)
    /// </summary>
    /// <value>Is this event obsolete? (Read-only)</value>
    [DataMember(Name="Obsolete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Obsolete")]
    public bool? Obsolete { get; set; }

    /// <summary>
    /// Does the event support SNMP trap notification? (Read-only)
    /// </summary>
    /// <value>Does the event support SNMP trap notification? (Read-only)</value>
    [DataMember(Name="SnmpFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SnmpFlag")]
    public bool? SnmpFlag { get; set; }

    /// <summary>
    /// Does the event support syslog logging? (Read-only)
    /// </summary>
    /// <value>Does the event support syslog logging? (Read-only)</value>
    [DataMember(Name="SyslogFlag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyslogFlag")]
    public bool? SyslogFlag { get; set; }

    /// <summary>
    /// Which admin roles can subscribe to this event (Read-only)
    /// </summary>
    /// <value>Which admin roles can subscribe to this event (Read-only)</value>
    [DataMember(Name="AllowedAdminRoles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedAdminRoles")]
    public List<AdminRoleName> AllowedAdminRoles { get; set; }

    /// <summary>
    /// Whether a partition owner can subscribe to this event (Read-only)
    /// </summary>
    /// <value>Whether a partition owner can subscribe to this event (Read-only)</value>
    [DataMember(Name="AllowPartitionOwner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPartitionOwner")]
    public bool? AllowPartitionOwner { get; set; }

    /// <summary>
    /// List of event data properties (Read-only)
    /// </summary>
    /// <value>List of event data properties (Read-only)</value>
    [DataMember(Name="Properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Properties")]
    public List<EventProperty> Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModelEvent {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  CategoryDisplayName: ").Append(CategoryDisplayName).Append("\n");
      sb.Append("  ActivityLogFlag: ").Append(ActivityLogFlag).Append("\n");
      sb.Append("  AsyncBroadcastFlag: ").Append(AsyncBroadcastFlag).Append("\n");
      sb.Append("  AsyncMulticastFlag: ").Append(AsyncMulticastFlag).Append("\n");
      sb.Append("  AsyncUnicastFlag: ").Append(AsyncUnicastFlag).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  EmailFlag: ").Append(EmailFlag).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  IsObjectAware: ").Append(IsObjectAware).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
      sb.Append("  Obsolete: ").Append(Obsolete).Append("\n");
      sb.Append("  SnmpFlag: ").Append(SnmpFlag).Append("\n");
      sb.Append("  SyslogFlag: ").Append(SyslogFlag).Append("\n");
      sb.Append("  AllowedAdminRoles: ").Append(AllowedAdminRoles).Append("\n");
      sb.Append("  AllowPartitionOwner: ").Append(AllowPartitionOwner).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
