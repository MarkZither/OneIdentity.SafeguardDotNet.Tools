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
  public class StaAcceptance {
    /// <summary>
    /// true if STA has been accepted, false otherwise
    /// </summary>
    /// <value>true if STA has been accepted, false otherwise</value>
    [DataMember(Name="Accepted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Accepted")]
    public bool? Accepted { get; set; }

    /// <summary>
    /// The date the user accepted the STA
    /// </summary>
    /// <value>The date the user accepted the STA</value>
    [DataMember(Name="TimeOfAcceptance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TimeOfAcceptance")]
    public DateTime? TimeOfAcceptance { get; set; }

    /// <summary>
    /// The ID of the User that accepted the STA
    /// </summary>
    /// <value>The ID of the User that accepted the STA</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// The Display Name of the user that accepted the STA
    /// </summary>
    /// <value>The Display Name of the user that accepted the STA</value>
    [DataMember(Name="UserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDisplayName")]
    public string UserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StaAcceptance {\n");
      sb.Append("  Accepted: ").Append(Accepted).Append("\n");
      sb.Append("  TimeOfAcceptance: ").Append(TimeOfAcceptance).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
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
