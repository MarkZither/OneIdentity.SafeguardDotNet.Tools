using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Account access request properties
  /// </summary>
  [DataContract]
  public class AccountRequestProperties {
    /// <summary>
    /// When set to {true}, an end user may submit a new Password Access Request for the account.  When set to {false}, an end user will receive an error when trying to submit a new Password Access Request.
    /// </summary>
    /// <value>When set to {true}, an end user may submit a new Password Access Request for the account.  When set to {false}, an end user will receive an error when trying to submit a new Password Access Request.</value>
    [DataMember(Name="AllowPasswordRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowPasswordRequest")]
    public bool? AllowPasswordRequest { get; set; }

    /// <summary>
    /// When set to {true}, an end user may submit a new session based Access Request for the account.  When set to {false}, an end user will receive an error when trying to submit a new session based Access Request.
    /// </summary>
    /// <value>When set to {true}, an end user may submit a new session based Access Request for the account.  When set to {false}, an end user will receive an error when trying to submit a new session based Access Request.</value>
    [DataMember(Name="AllowSessionRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionRequest")]
    public bool? AllowSessionRequest { get; set; }

    /// <summary>
    /// When set to {true}, an end user may submit a new SSH Key Access Request for the account.  When set to {false}, an end user will receive an error when trying to submit a new SSH Key Access Request.
    /// </summary>
    /// <value>When set to {true}, an end user may submit a new SSH Key Access Request for the account.  When set to {false}, an end user will receive an error when trying to submit a new SSH Key Access Request.</value>
    [DataMember(Name="AllowSshKeyRequest", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSshKeyRequest")]
    public bool? AllowSshKeyRequest { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountRequestProperties {\n");
      sb.Append("  AllowPasswordRequest: ").Append(AllowPasswordRequest).Append("\n");
      sb.Append("  AllowSessionRequest: ").Append(AllowSessionRequest).Append("\n");
      sb.Append("  AllowSshKeyRequest: ").Append(AllowSshKeyRequest).Append("\n");
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
