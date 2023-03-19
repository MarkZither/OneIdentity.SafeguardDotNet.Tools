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
  public class ClusterConfiguration {
    /// <summary>
    /// A list of members to include in the cluster.
    /// </summary>
    /// <value>A list of members to include in the cluster.</value>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<ClusterMember> Members { get; set; }

    /// <summary>
    /// The ID of the primary appliance.
    /// </summary>
    /// <value>The ID of the primary appliance.</value>
    [DataMember(Name="PrimaryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrimaryId")]
    public string PrimaryId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterConfiguration {\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
      sb.Append("  PrimaryId: ").Append(PrimaryId).Append("\n");
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
