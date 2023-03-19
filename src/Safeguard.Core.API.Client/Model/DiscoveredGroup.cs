using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The groups on the target system the user is a member of
  /// </summary>
  [DataContract]
  public class DiscoveredGroup {
    /// <summary>
    /// The Group ID discovered on the target system
    /// </summary>
    /// <value>The Group ID discovered on the target system</value>
    [DataMember(Name="DiscoveredGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroupId")]
    public string DiscoveredGroupId { get; set; }

    /// <summary>
    /// The name of the group on the target system
    /// </summary>
    /// <value>The name of the group on the target system</value>
    [DataMember(Name="DiscoveredGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroupName")]
    public string DiscoveredGroupName { get; set; }

    /// <summary>
    /// The distinguished name of the group on the target system
    /// </summary>
    /// <value>The distinguished name of the group on the target system</value>
    [DataMember(Name="DiscoveredGroupDistinguishedName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroupDistinguishedName")]
    public string DiscoveredGroupDistinguishedName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredGroup {\n");
      sb.Append("  DiscoveredGroupId: ").Append(DiscoveredGroupId).Append("\n");
      sb.Append("  DiscoveredGroupName: ").Append(DiscoveredGroupName).Append("\n");
      sb.Append("  DiscoveredGroupDistinguishedName: ").Append(DiscoveredGroupDistinguishedName).Append("\n");
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
