using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Directory attribute mappings for groups
  /// </summary>
  [DataContract]
  public class GroupAssetSchemaProperties {
    /// <summary>
    /// LDAP objects that have all of the specified objectClass types will be treated as groups.  These objectClass types will also be used to validate the attributes mapped to group properties.
    /// </summary>
    /// <value>LDAP objects that have all of the specified objectClass types will be treated as groups.  These objectClass types will also be used to validate the attributes mapped to group properties.</value>
    [DataMember(Name="GroupClassType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "GroupClassType")]
    public List<string> GroupClassType { get; set; }

    /// <summary>
    /// Name of group name schema attribute
    /// </summary>
    /// <value>Name of group name schema attribute</value>
    [DataMember(Name="MemberAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MemberAttribute")]
    public string MemberAttribute { get; set; }

    /// <summary>
    /// Name of group name schema attribute (
    /// </summary>
    /// <value>Name of group name schema attribute (</value>
    [DataMember(Name="NameAttribute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NameAttribute")]
    public string NameAttribute { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupAssetSchemaProperties {\n");
      sb.Append("  GroupClassType: ").Append(GroupClassType).Append("\n");
      sb.Append("  MemberAttribute: ").Append(MemberAttribute).Append("\n");
      sb.Append("  NameAttribute: ").Append(NameAttribute).Append("\n");
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
