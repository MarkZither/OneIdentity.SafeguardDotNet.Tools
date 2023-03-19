using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information for approving a request
  /// </summary>
  [DataContract]
  public class ApproveRequest {
    /// <summary>
    /// Unique ID of the access request to approve
    /// </summary>
    /// <value>Unique ID of the access request to approve</value>
    [DataMember(Name="RequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RequestId")]
    public string RequestId { get; set; }

    /// <summary>
    /// Comment made by approver to describe approval
    /// </summary>
    /// <value>Comment made by approver to describe approval</value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApproveRequest {\n");
      sb.Append("  RequestId: ").Append(RequestId).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
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
