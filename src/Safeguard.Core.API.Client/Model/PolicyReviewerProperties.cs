using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings related to reviewing a password request
  /// </summary>
  [DataContract]
  public class PolicyReviewerProperties {
    /// <summary>
    /// The minimum number of reviews required before a password request is closed
    /// </summary>
    /// <value>The minimum number of reviews required before a password request is closed</value>
    [DataMember(Name="RequiredReviewers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredReviewers")]
    public int? RequiredReviewers { get; set; }

    /// <summary>
    /// Whether a reviewer is required to supply a comment
    /// </summary>
    /// <value>Whether a reviewer is required to supply a comment</value>
    [DataMember(Name="RequireReviewerComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireReviewerComment")]
    public bool? RequireReviewerComment { get; set; }

    /// <summary>
    /// Whether this policy will allow bypassing any pending reviews in order to create new requests.
    /// </summary>
    /// <value>Whether this policy will allow bypassing any pending reviews in order to create new requests.</value>
    [DataMember(Name="AllowSubsequentAccessRequestsWithoutReview", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSubsequentAccessRequestsWithoutReview")]
    public bool? AllowSubsequentAccessRequestsWithoutReview { get; set; }

    /// <summary>
    /// Whether email notifications should be sent for approval escalation
    /// </summary>
    /// <value>Whether email notifications should be sent for approval escalation</value>
    [DataMember(Name="PendingReviewEscalationEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewEscalationEnabled")]
    public bool? PendingReviewEscalationEnabled { get; set; }

    /// <summary>
    /// The maximum duration (days) an expired password release may be pending review before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (days) an expired password release may be pending review before notifying escalation contacts</value>
    [DataMember(Name="PendingReviewDurationBeforeEscalationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewDurationBeforeEscalationDays")]
    public int? PendingReviewDurationBeforeEscalationDays { get; set; }

    /// <summary>
    /// The maximum duration (hours) a expired password release may be pending review before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (hours) a expired password release may be pending review before notifying escalation contacts</value>
    [DataMember(Name="PendingReviewDurationBeforeEscalationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewDurationBeforeEscalationHours")]
    public int? PendingReviewDurationBeforeEscalationHours { get; set; }

    /// <summary>
    /// The maximum duration (minutes) a expired password release may be pending review before notifying escalation contacts
    /// </summary>
    /// <value>The maximum duration (minutes) a expired password release may be pending review before notifying escalation contacts</value>
    [DataMember(Name="PendingReviewDurationBeforeEscalationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PendingReviewDurationBeforeEscalationMinutes")]
    public int? PendingReviewDurationBeforeEscalationMinutes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyReviewerProperties {\n");
      sb.Append("  RequiredReviewers: ").Append(RequiredReviewers).Append("\n");
      sb.Append("  RequireReviewerComment: ").Append(RequireReviewerComment).Append("\n");
      sb.Append("  AllowSubsequentAccessRequestsWithoutReview: ").Append(AllowSubsequentAccessRequestsWithoutReview).Append("\n");
      sb.Append("  PendingReviewEscalationEnabled: ").Append(PendingReviewEscalationEnabled).Append("\n");
      sb.Append("  PendingReviewDurationBeforeEscalationDays: ").Append(PendingReviewDurationBeforeEscalationDays).Append("\n");
      sb.Append("  PendingReviewDurationBeforeEscalationHours: ").Append(PendingReviewDurationBeforeEscalationHours).Append("\n");
      sb.Append("  PendingReviewDurationBeforeEscalationMinutes: ").Append(PendingReviewDurationBeforeEscalationMinutes).Append("\n");
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
