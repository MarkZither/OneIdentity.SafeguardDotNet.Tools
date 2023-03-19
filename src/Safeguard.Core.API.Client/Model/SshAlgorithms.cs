using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents the available algorithms when establishing an SSH connection through the sessions module, or to an archive server. The list order determines the priority in which the algorithms are negotiated with the SSHD server.
  /// </summary>
  [DataContract]
  public class SshAlgorithms {
    /// <summary>
    /// Public Key Algorithms.
    /// </summary>
    /// <value>Public Key Algorithms.</value>
    [DataMember(Name="PublicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PublicKey")]
    public List<string> PublicKey { get; set; }

    /// <summary>
    /// Cipher Algorithms.
    /// </summary>
    /// <value>Cipher Algorithms.</value>
    [DataMember(Name="Cipher", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Cipher")]
    public List<string> Cipher { get; set; }

    /// <summary>
    /// KEX Algorithms.
    /// </summary>
    /// <value>KEX Algorithms.</value>
    [DataMember(Name="Kex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Kex")]
    public List<string> Kex { get; set; }

    /// <summary>
    /// MAC Algorithms.
    /// </summary>
    /// <value>MAC Algorithms.</value>
    [DataMember(Name="Mac", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Mac")]
    public List<string> Mac { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SshAlgorithms {\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Cipher: ").Append(Cipher).Append("\n");
      sb.Append("  Kex: ").Append(Kex).Append("\n");
      sb.Append("  Mac: ").Append(Mac).Append("\n");
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
