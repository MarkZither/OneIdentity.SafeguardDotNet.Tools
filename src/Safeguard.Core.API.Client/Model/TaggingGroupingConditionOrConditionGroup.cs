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
  public class TaggingGroupingConditionOrConditionGroup {
    /// <summary>
    /// Gets or Sets TaggingGroupingCondition
    /// </summary>
    [DataMember(Name="TaggingGroupingCondition", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaggingGroupingCondition")]
    public TaggingGroupingCondition TaggingGroupingCondition { get; set; }

    /// <summary>
    /// Gets or Sets TaggingGroupingConditionGroup
    /// </summary>
    [DataMember(Name="TaggingGroupingConditionGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaggingGroupingConditionGroup")]
    public TaggingGroupingConditionGroup TaggingGroupingConditionGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaggingGroupingConditionOrConditionGroup {\n");
      sb.Append("  TaggingGroupingCondition: ").Append(TaggingGroupingCondition).Append("\n");
      sb.Append("  TaggingGroupingConditionGroup: ").Append(TaggingGroupingConditionGroup).Append("\n");
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
