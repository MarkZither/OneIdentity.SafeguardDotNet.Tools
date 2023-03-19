using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// When a client application makes a request to the &lt;i&gt;/service/core/v2/Token/LoginResponse&lt;/i&gt; end point, they              should post this object.  Currently, we have only one property, so it could be a single parameter, but this will allow for              future updates without necessarily breaking the clients.
  /// </summary>
  [DataContract]
  public class LoginResponseRequestData {
    /// <summary>
    /// The access token obtained from the STS that the client application intends to exchange for a Safeguard token.
    /// </summary>
    /// <value>The access token obtained from the STS that the client application intends to exchange for a Safeguard token.</value>
    [DataMember(Name="StsAccessToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StsAccessToken")]
    public string StsAccessToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginResponseRequestData {\n");
      sb.Append("  StsAccessToken: ").Append(StsAccessToken).Append("\n");
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
