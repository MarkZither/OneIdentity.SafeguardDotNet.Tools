using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings related to approving a access request
  /// </summary>
  [DataContract]
  public class PolicyApproverProperties {
    /// <summary>
    /// Password requests must be approved before the password may be released
    /// </summary>
    /// <value>Password requests must be approved before the password may be released</value>
    [DataMember(Name="RequireApproval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireApproval")]
    public bool? RequireApproval { get; set; }

    /// <summary>
    /// Whether email notifications should be sent for approval escalation
    /// </summary>
    /// <value>Whether email notifications should be sent for approval escalation</value>
    [DataMember(Name="PendingApprovalEscalationEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalEscalationEnabled")]
    public bool? PendingApprovalEscalationEnabled { get; set; }

    /// <summary>
    /// The maximum duration (days) a access request may be pending approval before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (days) a access request may be pending approval before notifying escalation contacts</value>
    [DataMember(Name="PendingApprovalDurationBeforeEscalationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalDurationBeforeEscalationDays")]
    public int? PendingApprovalDurationBeforeEscalationDays { get; set; }

    /// <summary>
    /// The maximum duration (hours) a access request may be pending approval before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (hours) a access request may be pending approval before notifying escalation contacts</value>
    [DataMember(Name="PendingApprovalDurationBeforeEscalationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalDurationBeforeEscalationHours")]
    public int? PendingApprovalDurationBeforeEscalationHours { get; set; }

    /// <summary>
    /// The maximum duration (minutes) a access request may be pending approval before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (minutes) a access request may be pending approval before notifying escalation contacts</value>
    [DataMember(Name="PendingApprovalDurationBeforeEscalationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingApprovalDurationBeforeEscalationMinutes")]
    public int? PendingApprovalDurationBeforeEscalationMinutes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyApproverProperties {\n");
      sb.Append("  RequireApproval: ").Append(RequireApproval).Append("\n");
      sb.Append("  PendingApprovalEscalationEnabled: ").Append(PendingApprovalEscalationEnabled).Append("\n");
      sb.Append("  PendingApprovalDurationBeforeEscalationDays: ").Append(PendingApprovalDurationBeforeEscalationDays).Append("\n");
      sb.Append("  PendingApprovalDurationBeforeEscalationHours: ").Append(PendingApprovalDurationBeforeEscalationHours).Append("\n");
      sb.Append("  PendingApprovalDurationBeforeEscalationMinutes: ").Append(PendingApprovalDurationBeforeEscalationMinutes).Append("\n");
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
