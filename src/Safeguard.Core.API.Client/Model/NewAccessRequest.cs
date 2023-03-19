using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a request for the password of an account
  /// </summary>
  [DataContract]
  public class NewAccessRequest {
    /// <summary>
    /// Database ID of the account to request password for (or access account for sessions)
    /// </summary>
    /// <value>Database ID of the account to request password for (or access account for sessions)</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Database ID of asset to request access to
    /// </summary>
    /// <value>Database ID of asset to request access to</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

    /// <summary>
    /// Whether emergency access is being requested
    /// </summary>
    /// <value>Whether emergency access is being requested</value>
    [DataMember(Name="IsEmergency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmergency")]
    public bool? IsEmergency { get; set; }

    /// <summary>
    /// Database ID of the pre-defined reason code for why the password access is needed
    /// </summary>
    /// <value>Database ID of the pre-defined reason code for why the password access is needed</value>
    [DataMember(Name="ReasonCodeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonCodeId")]
    public int? ReasonCodeId { get; set; }

    /// <summary>
    /// Requester's reason of why the password access is needed
    /// </summary>
    /// <value>Requester's reason of why the password access is needed</value>
    [DataMember(Name="ReasonComment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ReasonComment")]
    public string ReasonComment { get; set; }

    /// <summary>
    /// The number of days requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 31 days.
    /// </summary>
    /// <value>The number of days requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 31 days.</value>
    [DataMember(Name="RequestedDurationDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationDays")]
    public int? RequestedDurationDays { get; set; }

    /// <summary>
    /// The number of hours requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 31 days.
    /// </summary>
    /// <value>The number of hours requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 31 days.</value>
    [DataMember(Name="RequestedDurationHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationHours")]
    public int? RequestedDurationHours { get; set; }

    /// <summary>
    /// The number of minutes requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 31 days.
    /// </summary>
    /// <value>The number of minutes requested for password access. The sum of Requested Days/Hours/Minutes must not exceed 31 days.</value>
    [DataMember(Name="RequestedDurationMinutes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedDurationMinutes")]
    public int? RequestedDurationMinutes { get; set; }

    /// <summary>
    /// The UTC date-time requested for password access. {null} means \"Right Now!\"
    /// </summary>
    /// <value>The UTC date-time requested for password access. {null} means \"Right Now!\"</value>
    [DataMember(Name="RequestedFor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedFor")]
    public DateTime? RequestedFor { get; set; }

    /// <summary>
    /// The help desk ticket number as required by policy
    /// </summary>
    /// <value>The help desk ticket number as required by policy</value>
    [DataMember(Name="TicketNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TicketNumber")]
    public string TicketNumber { get; set; }

    /// <summary>
    /// Whether SPP can launch an SRA session
    /// </summary>
    /// <value>Whether SPP can launch an SRA session</value>
    [DataMember(Name="AllowSraSessionLaunch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSraSessionLaunch")]
    public bool? AllowSraSessionLaunch { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NewAccessRequest {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  IsEmergency: ").Append(IsEmergency).Append("\n");
      sb.Append("  ReasonCodeId: ").Append(ReasonCodeId).Append("\n");
      sb.Append("  ReasonComment: ").Append(ReasonComment).Append("\n");
      sb.Append("  RequestedDurationDays: ").Append(RequestedDurationDays).Append("\n");
      sb.Append("  RequestedDurationHours: ").Append(RequestedDurationHours).Append("\n");
      sb.Append("  RequestedDurationMinutes: ").Append(RequestedDurationMinutes).Append("\n");
      sb.Append("  RequestedFor: ").Append(RequestedFor).Append("\n");
      sb.Append("  TicketNumber: ").Append(TicketNumber).Append("\n");
      sb.Append("  AllowSraSessionLaunch: ").Append(AllowSraSessionLaunch).Append("\n");
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
