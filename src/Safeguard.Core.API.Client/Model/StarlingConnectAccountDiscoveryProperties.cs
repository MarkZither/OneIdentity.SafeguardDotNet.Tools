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
  public class StarlingConnectAccountDiscoveryProperties {
    /// <summary>
    /// Gets or Sets RuleType
    /// </summary>
    [DataMember(Name="RuleType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleType")]
    public StarlingConnectAccountDiscoveryRuleType RuleType { get; set; }

    /// <summary>
    /// Gets or Sets PropertyConstraintProperties
    /// </summary>
    [DataMember(Name="PropertyConstraintProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PropertyConstraintProperties")]
    public StarlingConnectPropertyConstraintProperties PropertyConstraintProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StarlingConnectAccountDiscoveryProperties {\n");
      sb.Append("  RuleType: ").Append(RuleType).Append("\n");
      sb.Append("  PropertyConstraintProperties: ").Append(PropertyConstraintProperties).Append("\n");
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
