using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The &lt;i&gt;/service/core/v2/Token/LoginResponse&lt;/i&gt; end point will return a Pangaea.Data.Transfer.V2.Users.LoginResponse object with              a Pangaea.Data.Transfer.V2.Users.LoginResponse.Status of one of these values indicating to the client application what it should do next.
  /// </summary>
  [DataContract]
  public class LoginResponseStatus {

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LoginResponseStatus {\n");
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
