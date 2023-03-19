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
  public class TaggingGroupingRule {
    /// <summary>
    /// Description of the rule
    /// </summary>
    /// <value>Description of the rule</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// If true, entities will be evaluated against this rule
    /// </summary>
    /// <value>If true, entities will be evaluated against this rule</value>
    [DataMember(Name="Enabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Gets or Sets RuleConditionGroup
    /// </summary>
    [DataMember(Name="RuleConditionGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleConditionGroup")]
    public TaggingGroupingConditionGroup RuleConditionGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaggingGroupingRule {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Enabled: ").Append(Enabled).Append("\n");
      sb.Append("  RuleConditionGroup: ").Append(RuleConditionGroup).Append("\n");
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
