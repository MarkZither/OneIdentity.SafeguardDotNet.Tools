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
  public class TaggingGroupingCondition {
    /// <summary>
    /// Gets or Sets ObjectAttribute
    /// </summary>
    [DataMember(Name="ObjectAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectAttribute")]
    public TaggingGroupingObjectAttributes ObjectAttribute { get; set; }

    /// <summary>
    /// Gets or Sets CompareType
    /// </summary>
    [DataMember(Name="CompareType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompareType")]
    public ComparisonOperator CompareType { get; set; }

    /// <summary>
    /// The value to compare the ObjectAttribute value against. Always stored/transferred as a string, converted as needed.
    /// </summary>
    /// <value>The value to compare the ObjectAttribute value against. Always stored/transferred as a string, converted as needed.</value>
    [DataMember(Name="CompareValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CompareValue")]
    public string CompareValue { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaggingGroupingCondition {\n");
      sb.Append("  ObjectAttribute: ").Append(ObjectAttribute).Append("\n");
      sb.Append("  CompareType: ").Append(CompareType).Append("\n");
      sb.Append("  CompareValue: ").Append(CompareValue).Append("\n");
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
