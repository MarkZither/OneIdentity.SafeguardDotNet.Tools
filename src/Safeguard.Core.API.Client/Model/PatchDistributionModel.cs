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
  public class PatchDistributionModel {
    /// <summary>
    /// Gets or Sets PatchInfo
    /// </summary>
    [DataMember(Name="PatchInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PatchInfo")]
    public PatchInfoModel PatchInfo { get; set; }

    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<ClusterPatchModel> Members { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PatchDistributionModel {\n");
      sb.Append("  PatchInfo: ").Append(PatchInfo).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
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
