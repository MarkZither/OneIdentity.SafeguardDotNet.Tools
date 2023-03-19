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
  public class HardwareSecurityModuleClientCertificate {
    /// <summary>
    /// Gets or Sets ClientPem
    /// </summary>
    [DataMember(Name="ClientPem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientPem")]
    public string ClientPem { get; set; }

    /// <summary>
    /// Gets or Sets ClientKey
    /// </summary>
    [DataMember(Name="ClientKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientKey")]
    public string ClientKey { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HardwareSecurityModuleClientCertificate {\n");
      sb.Append("  ClientPem: ").Append(ClientPem).Append("\n");
      sb.Append("  ClientKey: ").Append(ClientKey).Append("\n");
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
