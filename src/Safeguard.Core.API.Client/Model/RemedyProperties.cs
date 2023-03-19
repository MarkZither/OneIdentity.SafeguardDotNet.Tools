using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration specific to Remedy
  /// </summary>
  [DataContract]
  public class RemedyProperties {
    /// <summary>
    /// Authentication string used to connect to the api
    /// </summary>
    /// <value>Authentication string used to connect to the api</value>
    [DataMember(Name="AuthenticationString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationString")]
    public string AuthenticationString { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RemedyProperties {\n");
      sb.Append("  AuthenticationString: ").Append(AuthenticationString).Append("\n");
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
