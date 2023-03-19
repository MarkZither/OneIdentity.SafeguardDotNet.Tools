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
  public class TaggingGroupingConditionGroup {
    /// <summary>
    /// Gets or Sets LogicalJoinType
    /// </summary>
    [DataMember(Name="LogicalJoinType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogicalJoinType")]
    public ConditionJoinType LogicalJoinType { get; set; }

    /// <summary>
    /// The children of this group.
    /// </summary>
    /// <value>The children of this group.</value>
    [DataMember(Name="Children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Children")]
    public List<TaggingGroupingConditionOrConditionGroup> Children { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaggingGroupingConditionGroup {\n");
      sb.Append("  LogicalJoinType: ").Append(LogicalJoinType).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
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
