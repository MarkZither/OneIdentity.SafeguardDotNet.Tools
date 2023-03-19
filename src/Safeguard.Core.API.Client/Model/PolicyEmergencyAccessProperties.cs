using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings related to emergency access to a password
  /// </summary>
  [DataContract]
  public class PolicyEmergencyAccessProperties {
    /// <summary>
    /// Whether the members of this role can request emergency access
    /// </summary>
    /// <value>Whether the members of this role can request emergency access</value>
    [DataMember(Name="AllowEmergencyAccess", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowEmergencyAccess")]
    public bool? AllowEmergencyAccess { get; set; }

    /// <summary>
    /// Ignore hourly restrictions when requesting emergency access
    /// </summary>
    /// <value>Ignore hourly restrictions when requesting emergency access</value>
    [DataMember(Name="IgnoreHourlyRestrictions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IgnoreHourlyRestrictions")]
    public bool? IgnoreHourlyRestrictions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyEmergencyAccessProperties {\n");
      sb.Append("  AllowEmergencyAccess: ").Append(AllowEmergencyAccess).Append("\n");
      sb.Append("  IgnoreHourlyRestrictions: ").Append(IgnoreHourlyRestrictions).Append("\n");
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
