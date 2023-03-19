using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a set of identities required to approve a access request for a policy
  /// </summary>
  [DataContract]
  public class ApproverSet {
    /// <summary>
    /// The minimum number of approvers required by this approver set
    /// </summary>
    /// <value>The minimum number of approvers required by this approver set</value>
    [DataMember(Name="RequiredApprovers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequiredApprovers")]
    public int? RequiredApprovers { get; set; }

    /// <summary>
    /// List of users that may approve to meet the required approver count
    /// </summary>
    /// <value>List of users that may approve to meet the required approver count</value>
    [DataMember(Name="Approvers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Approvers")]
    public List<Approver> Approvers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApproverSet {\n");
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
