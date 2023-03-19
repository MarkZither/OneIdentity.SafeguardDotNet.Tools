using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents settings for requesting asset/accounts
  /// </summary>
  [DataContract]
  public class PolicyRequesterProperties {
    /// <summary>
    /// The default duration (days) a request may be available. Only needed  when AllowCustomDuration is true. DefaultReleaseDuration must be less than 31 days.
    /// </summary>
    /// <value>The default duration (days) a request may be available. Only needed  when AllowCustomDuration is true. DefaultReleaseDuration must be less than 31 days.</value>
    [DataMember(Name="DefaultReleaseDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReleaseDurationDays")]
    public int? DefaultReleaseDurationDays { get; set; }

    /// <summary>
    /// The default duration (hours) a request may be available. Only needed  when AllowCustomDuration is true. DefaultReleaseDuration must be less than 31 days.
    /// </summary>
    /// <value>The default duration (hours) a request may be available. Only needed  when AllowCustomDuration is true. DefaultReleaseDuration must be less than 31 days.</value>
    [DataMember(Name="DefaultReleaseDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReleaseDurationHours")]
    public int? DefaultReleaseDurationHours { get; set; }

    /// <summary>
    /// The default duration (minutes) a request may be available. Only needed  when AllowCustomDuration is true. DefaultReleaseDuration must be less than 31 days.
    /// </summary>
    /// <value>The default duration (minutes) a request may be available. Only needed  when AllowCustomDuration is true. DefaultReleaseDuration must be less than 31 days.</value>
    [DataMember(Name="DefaultReleaseDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultReleaseDurationMinutes")]
    public int? DefaultReleaseDurationMinutes { get; set; }

    /// <summary>
    /// The maximum duration (days) a request may be available. Only needed  when AllowCustomDuration is true. MaximumReleaseDuration must be less than 31 days.
    /// </summary>
    /// <value>The maximum duration (days) a request may be available. Only needed  when AllowCustomDuration is true. MaximumReleaseDuration must be less than 31 days.</value>
    [DataMember(Name="MaximumReleaseDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumReleaseDurationDays")]
    public int? MaximumReleaseDurationDays { get; set; }

    /// <summary>
    /// The maximum duration (hours) a request may be available. Only needed  when AllowCustomDuration is true. MaximumReleaseDuration must be less than 31 days.
    /// </summary>
    /// <value>The maximum duration (hours) a request may be available. Only needed  when AllowCustomDuration is true. MaximumReleaseDuration must be less than 31 days.</value>
    [DataMember(Name="MaximumReleaseDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumReleaseDurationHours")]
    public int? MaximumReleaseDurationHours { get; set; }

    /// <summary>
    /// The maximum duration (minutes) a request may be available. Only needed  when AllowCustomDuration is true. MaximumReleaseDuration must be less than 31 days.
    /// </summary>
    /// <value>The maximum duration (minutes) a request may be available. Only needed  when AllowCustomDuration is true. MaximumReleaseDuration must be less than 31 days.</value>
    [DataMember(Name="MaximumReleaseDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaximumReleaseDurationMinutes")]
    public int? MaximumReleaseDurationMinutes { get; set; }

    /// <summary>
    /// Whether to allow the release duration to be modified during a   access request.
    /// </summary>
    /// <value>Whether to allow the release duration to be modified during a   access request.</value>
    [DataMember(Name="AllowCustomDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowCustomDuration")]
    public bool? AllowCustomDuration { get; set; }

    /// <summary>
    /// A reason code is required before a access request can be made.
    /// </summary>
    /// <value>A reason code is required before a access request can be made.</value>
    [DataMember(Name="RequireReasonCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireReasonCode")]
    public bool? RequireReasonCode { get; set; }

    /// <summary>
    /// A reason comment is required before a access request can be made.
    /// </summary>
    /// <value>A reason comment is required before a access request can be made.</value>
    [DataMember(Name="RequireReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireReasonComment")]
    public bool? RequireReasonComment { get; set; }

    /// <summary>
    /// Whether a service ticket is required for access requests
    /// </summary>
    /// <value>Whether a service ticket is required for access requests</value>
    [DataMember(Name="RequireServiceTicket", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequireServiceTicket")]
    public bool? RequireServiceTicket { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyRequesterProperties {\n");
      sb.Append("  DefaultReleaseDurationDays: ").Append(DefaultReleaseDurationDays).Append("\n");
      sb.Append("  DefaultReleaseDurationHours: ").Append(DefaultReleaseDurationHours).Append("\n");
      sb.Append("  DefaultReleaseDurationMinutes: ").Append(DefaultReleaseDurationMinutes).Append("\n");
      sb.Append("  MaximumReleaseDurationDays: ").Append(MaximumReleaseDurationDays).Append("\n");
      sb.Append("  MaximumReleaseDurationHours: ").Append(MaximumReleaseDurationHours).Append("\n");
      sb.Append("  MaximumReleaseDurationMinutes: ").Append(MaximumReleaseDurationMinutes).Append("\n");
      sb.Append("  AllowCustomDuration: ").Append(AllowCustomDuration).Append("\n");
      sb.Append("  RequireReasonCode: ").Append(RequireReasonCode).Append("\n");
      sb.Append("  RequireReasonComment: ").Append(RequireReasonComment).Append("\n");
      sb.Append("  RequireServiceTicket: ").Append(RequireServiceTicket).Append("\n");
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
