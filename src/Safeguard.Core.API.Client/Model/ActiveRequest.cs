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
  public class ActiveRequest {
    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
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
    /// Gets or Sets IsEmergency
    /// </summary>
    [DataMember(Name="IsEmergency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsEmergency")]
    public bool? IsEmergency { get; set; }

    /// <summary>
    /// Gets or Sets RequestedFor
    /// </summary>
    [DataMember(Name="RequestedFor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestedFor")]
    public DateTime? RequestedFor { get; set; }

    /// <summary>
    /// Gets or Sets ExpiresOn
    /// </summary>
    [DataMember(Name="ExpiresOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpiresOn")]
    public DateTime? ExpiresOn { get; set; }

    /// <summary>
    /// Gets or Sets RequestAvailability
    /// </summary>
    [DataMember(Name="RequestAvailability", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestAvailability")]
    public List<DateTimeInterval> RequestAvailability { get; set; }

    /// <summary>
    /// Gets or Sets State
    /// </summary>
    [DataMember(Name="State", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "State")]
    public AccessRequestState State { get; set; }

    /// <summary>
    /// Gets or Sets StateChangedOn
    /// </summary>
    [DataMember(Name="StateChangedOn", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StateChangedOn")]
    public DateTime? StateChangedOn { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActiveRequest {\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  IsEmergency: ").Append(IsEmergency).Append("\n");
      sb.Append("  RequestedFor: ").Append(RequestedFor).Append("\n");
      sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
      sb.Append("  RequestAvailability: ").Append(RequestAvailability).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  StateChangedOn: ").Append(StateChangedOn).Append("\n");
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
