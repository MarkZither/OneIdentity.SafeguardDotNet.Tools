using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Configuration specific to ServiceNow
  /// </summary>
  [DataContract]
  public class ServiceNowProperties {
    /// <summary>
    /// Unique identifier of allowed client (will use BasicAuth if not specified)
    /// </summary>
    /// <value>Unique identifier of allowed client (will use BasicAuth if not specified)</value>
    [DataMember(Name="ClientIdentifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientIdentifier")]
    public string ClientIdentifier { get; set; }

    /// <summary>
    /// Passphrase corresponding to this client
    /// </summary>
    /// <value>Passphrase corresponding to this client</value>
    [DataMember(Name="ClientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ClientSecret")]
    public string ClientSecret { get; set; }

    /// <summary>
    /// Whether a password has been set (Read-only)
    /// </summary>
    /// <value>Whether a password has been set (Read-only)</value>
    [DataMember(Name="HasClientSecret", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasClientSecret")]
    public bool? HasClientSecret { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceNowProperties {\n");
      sb.Append("  ClientIdentifier: ").Append(ClientIdentifier).Append("\n");
      sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
      sb.Append("  HasClientSecret: ").Append(HasClientSecret).Append("\n");
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
