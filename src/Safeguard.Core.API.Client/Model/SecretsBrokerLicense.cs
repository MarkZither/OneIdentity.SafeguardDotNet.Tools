using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A license for the secrets broker module.
  /// </summary>
  [DataContract]
  public class SecretsBrokerLicense {
    /// <summary>
    /// The maximum number of secrets permitted under this license.
    /// </summary>
    /// <value>The maximum number of secrets permitted under this license.</value>
    [DataMember(Name="MaxSecrets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxSecrets")]
    public int? MaxSecrets { get; set; }

    /// <summary>
    /// The number of secrets currently utilized.
    /// </summary>
    /// <value>The number of secrets currently utilized.</value>
    [DataMember(Name="SecretsUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SecretsUsed")]
    public int? SecretsUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SecretsBrokerLicense {\n");
      sb.Append("  MaxSecrets: ").Append(MaxSecrets).Append("\n");
      sb.Append("  SecretsUsed: ").Append(SecretsUsed).Append("\n");
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
