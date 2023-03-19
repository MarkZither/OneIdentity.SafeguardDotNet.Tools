using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Contains the Pangaea.Data.Transfer.V3.Patch.PatchPreconditionResult for each member in the cluster.
  /// </summary>
  [DataContract]
  public class ClusterPatchPreconditionResult {
    /// <summary>
    /// Gets or Sets ClusterResults
    /// </summary>
    [DataMember(Name="ClusterResults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClusterResults")]
    public List<PatchPreconditionResult> ClusterResults { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClusterPatchPreconditionResult {\n");
      sb.Append("  ClusterResults: ").Append(ClusterResults).Append("\n");
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
