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
  public class AccessRequestApproverSet {
    /// <summary>
    /// Minimum required number of approvers from this approver set
    /// </summary>
    /// <value>Minimum required number of approvers from this approver set</value>
    [DataMember(Name="RequiredApprovers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredApprovers")]
    public int? RequiredApprovers { get; set; }

    /// <summary>
    /// List of approvers
    /// </summary>
    /// <value>List of approvers</value>
    [DataMember(Name="Approvers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Approvers")]
    public List<AccessRequestApprover> Approvers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccessRequestApproverSet {\n");
      sb.Append("  RequiredApprovers: ").Append(RequiredApprovers).Append("\n");
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
