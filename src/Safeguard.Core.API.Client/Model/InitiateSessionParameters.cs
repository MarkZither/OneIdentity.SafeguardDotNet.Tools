using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters for initiating a session for an access request
  /// </summary>
  [DataContract]
  public class InitiateSessionParameters {
    /// <summary>
    /// Name of session access account if using user-supplied credentials
    /// </summary>
    /// <value>Name of session access account if using user-supplied credentials</value>
    [DataMember(Name="SessionAccessAccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessAccountName")]
    public string SessionAccessAccountName { get; set; }

    /// <summary>
    /// DomainName of session access account if using user-supplied credentials
    /// </summary>
    /// <value>DomainName of session access account if using user-supplied credentials</value>
    [DataMember(Name="SessionAccessAccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessAccountDomainName")]
    public string SessionAccessAccountDomainName { get; set; }

    /// <summary>
    /// Password of session access account if using user-supplied credentials
    /// </summary>
    /// <value>Password of session access account if using user-supplied credentials</value>
    [DataMember(Name="SessionAccessAccountPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionAccessAccountPassword")]
    public string SessionAccessAccountPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InitiateSessionParameters {\n");
      sb.Append("  SessionAccessAccountName: ").Append(SessionAccessAccountName).Append("\n");
      sb.Append("  SessionAccessAccountDomainName: ").Append(SessionAccessAccountDomainName).Append("\n");
      sb.Append("  SessionAccessAccountPassword: ").Append(SessionAccessAccountPassword).Append("\n");
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
