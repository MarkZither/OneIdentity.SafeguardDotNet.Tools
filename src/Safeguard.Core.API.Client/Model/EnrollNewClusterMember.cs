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
  public class EnrollNewClusterMember {
    /// <summary>
    /// The hostname of the target appliance to enroll
    /// </summary>
    /// <value>The hostname of the target appliance to enroll</value>
    [DataMember(Name="Hostname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hostname")]
    public string Hostname { get; set; }

    /// <summary>
    /// OAuth Token representing the user that is performing enrollment
    /// </summary>
    /// <value>OAuth Token representing the user that is performing enrollment</value>
    [DataMember(Name="AuthenticationToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationToken")]
    public string AuthenticationToken { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EnrollNewClusterMember {\n");
      sb.Append("  Hostname: ").Append(Hostname).Append("\n");
      sb.Append("  AuthenticationToken: ").Append(AuthenticationToken).Append("\n");
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
