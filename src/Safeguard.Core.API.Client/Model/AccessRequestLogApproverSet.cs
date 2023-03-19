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
  public class AccessRequestLogApproverSet {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets RequiredApprovals
    /// </summary>
    [DataMember(Name="RequiredApprovals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredApprovals")]
    public int? RequiredApprovals { get; set; }

    /// <summary>
    /// Gets or Sets Approvers
    /// </summary>
    [DataMember(Name="Approvers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Approvers")]
    public List<AccessRequestLogIdentity> Approvers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequestLogApproverSet {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RequiredApprovals: ").Append(RequiredApprovals).Append("\n");
      sb.Append("  Approvers: ").Append(Approvers).Append("\n");
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
