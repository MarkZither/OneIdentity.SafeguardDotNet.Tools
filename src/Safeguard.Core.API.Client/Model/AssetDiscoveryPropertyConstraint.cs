using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Set of property constraints to match against discovered assets
  /// </summary>
  [DataContract]
  public class AssetDiscoveryPropertyConstraint {
    /// <summary>
    /// Gets or Sets PropertyName
    /// </summary>
    [DataMember(Name="PropertyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PropertyName")]
    public DiscoveredAssetProperty PropertyName { get; set; }

    /// <summary>
    /// Gets or Sets _Operator
    /// </summary>
    [DataMember(Name="Operator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Operator")]
    public DiscoveredAssetPropertyConstraintOperator _Operator { get; set; }

    /// <summary>
    /// Value to match against
    /// </summary>
    /// <value>Value to match against</value>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public string Value { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDiscoveryPropertyConstraint {\n");
      sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
      sb.Append("  _Operator: ").Append(_Operator).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
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
