using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an SSH Host Key used to identify archive servers
  /// </summary>
  [DataContract]
  public class ArchiveServerSshHostKey {
    /// <summary>
    /// Public key of the asset
    /// </summary>
    /// <value>Public key of the asset</value>
    [DataMember(Name="SshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKey")]
    public string SshHostKey { get; set; }

    /// <summary>
    /// The MD5 fingerprint hash of the SSH host key (Read-only)
    /// </summary>
    /// <value>The MD5 fingerprint hash of the SSH host key (Read-only)</value>
    [DataMember(Name="Fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fingerprint")]
    public string Fingerprint { get; set; }

    /// <summary>
    /// The SHA256 fingerprint hash, Base64 encoded, of the SSH host key (Read-only)
    /// </summary>
    /// <value>The SHA256 fingerprint hash, Base64 encoded, of the SSH host key (Read-only)</value>
    [DataMember(Name="FingerprintSha256", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FingerprintSha256")]
    public string FingerprintSha256 { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArchiveServerSshHostKey {\n");
      sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
      sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
      sb.Append("  FingerprintSha256: ").Append(FingerprintSha256).Append("\n");
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
