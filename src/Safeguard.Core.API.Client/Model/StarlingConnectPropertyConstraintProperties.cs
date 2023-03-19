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
  public class StarlingConnectPropertyConstraintProperties {
    /// <summary>
    /// Filters accounts based on the name of the account (an ANR search is performed for Active Directory). Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filters accounts based on the name of the account (an ANR search is performed for Active Directory). Names can be specified as a regular expression.</value>
    [DataMember(Name="NameFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameFilter")]
    public string NameFilter { get; set; }

    /// <summary>
    /// Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.</value>
    [DataMember(Name="GroupFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupFilter")]
    public string GroupFilter { get; set; }

    /// <summary>
    /// Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.
    /// </summary>
    /// <value>Filter accounts based on the names of groups in the directory the account belongs to. Names can be specified as a regular expression.</value>
    [DataMember(Name="RoleFilter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleFilter")]
    public string RoleFilter { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StarlingConnectPropertyConstraintProperties {\n");
      sb.Append("  NameFilter: ").Append(NameFilter).Append("\n");
      sb.Append("  GroupFilter: ").Append(GroupFilter).Append("\n");
      sb.Append("  RoleFilter: ").Append(RoleFilter).Append("\n");
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
