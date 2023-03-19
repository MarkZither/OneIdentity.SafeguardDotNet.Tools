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
  public class WindowsPropertyConstraintProperties {
    /// <summary>
    /// Filter applied to discriminate between Unix group identifiers. IDs can be specified as a single ID or a range, e.g. 1 or 3-5
    /// </summary>
    /// <value>Filter applied to discriminate between Unix group identifiers. IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>
    [DataMember(Name="GidFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GidFilter")]
    public List<string> GidFilter { get; set; }

    /// <summary>
    /// Filter applied to discriminate between account group names. Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filter applied to discriminate between account group names. Names can be specified as a regular expression.</value>
    [DataMember(Name="GroupFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupFilter")]
    public string GroupFilter { get; set; }

    /// <summary>
    /// Filter applied to discriminate between account names. Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filter applied to discriminate between account names. Names can be specified as a regular expression.</value>
    [DataMember(Name="NameFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameFilter")]
    public string NameFilter { get; set; }

    /// <summary>
    /// Filter applied to discriminate between Windows relative identifiers. IDs can be specified as a single ID or a range, e.g. 1 or 3-5
    /// </summary>
    /// <value>Filter applied to discriminate between Windows relative identifiers. IDs can be specified as a single ID or a range, e.g. 1 or 3-5</value>
    [DataMember(Name="RidFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RidFilter")]
    public List<string> RidFilter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WindowsPropertyConstraintProperties {\n");
      sb.Append("  GidFilter: ").Append(GidFilter).Append("\n");
      sb.Append("  GroupFilter: ").Append(GroupFilter).Append("\n");
      sb.Append("  NameFilter: ").Append(NameFilter).Append("\n");
      sb.Append("  RidFilter: ").Append(RidFilter).Append("\n");
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
