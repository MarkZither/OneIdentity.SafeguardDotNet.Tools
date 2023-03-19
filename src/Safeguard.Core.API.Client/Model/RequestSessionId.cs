using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// List of sessions to terminate
  /// </summary>
  [DataContract]
  public class RequestSessionId {
    /// <summary>
    /// Unique access request ID
    /// </summary>
    /// <value>Unique access request ID</value>
    [DataMember(Name="AccessRequestId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestId")]
    public string AccessRequestId { get; set; }

    /// <summary>
    /// ID of session for request
    /// </summary>
    /// <value>ID of session for request</value>
    [DataMember(Name="SessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionId")]
    public int? SessionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RequestSessionId {\n");
      sb.Append("  AccessRequestId: ").Append(AccessRequestId).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
