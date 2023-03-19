using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A discovered group of an account
  /// </summary>
  [DataContract]
  public class DiscoveredGroupLog {
    /// <summary>
    /// Name of discovered group
    /// </summary>
    /// <value>Name of discovered group</value>
    [DataMember(Name="DiscoveredGroupName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroupName")]
    public string DiscoveredGroupName { get; set; }

    /// <summary>
    /// Discovered ID of group
    /// </summary>
    /// <value>Discovered ID of group</value>
    [DataMember(Name="DiscoveredGroupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroupId")]
    public string DiscoveredGroupId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredGroupLog {\n");
      sb.Append("  DiscoveredGroupName: ").Append(DiscoveredGroupName).Append("\n");
      sb.Append("  DiscoveredGroupId: ").Append(DiscoveredGroupId).Append("\n");
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
