using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents asset requests that the current user can perform some action on
  /// </summary>
  [DataContract]
  public class ActionableAccessRequests {
    /// <summary>
    /// Requests the the Policy Admin my close if necessary
    /// </summary>
    /// <value>Requests the the Policy Admin my close if necessary</value>
    [DataMember(Name="Admin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Admin")]
    public List<AccessRequest> Admin { get; set; }

    /// <summary>
    /// Requests that are awaiting approval from the current user
    /// </summary>
    /// <value>Requests that are awaiting approval from the current user</value>
    [DataMember(Name="Approver", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Approver")]
    public List<AccessRequest> Approver { get; set; }

    /// <summary>
    /// Requests submitted by the current user that are either open or  have had activity needing acknowledgement
    /// </summary>
    /// <value>Requests submitted by the current user that are either open or  have had activity needing acknowledgement</value>
    [DataMember(Name="Requester", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Requester")]
    public List<AccessRequest> Requester { get; set; }

    /// <summary>
    /// Requests that are awaiting review from the current user
    /// </summary>
    /// <value>Requests that are awaiting review from the current user</value>
    [DataMember(Name="Reviewer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Reviewer")]
    public List<AccessRequest> Reviewer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ActionableAccessRequests {\n");
      sb.Append("  Admin: ").Append(Admin).Append("\n");
      sb.Append("  Approver: ").Append(Approver).Append("\n");
      sb.Append("  Requester: ").Append(Requester).Append("\n");
      sb.Append("  Reviewer: ").Append(Reviewer).Append("\n");
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
