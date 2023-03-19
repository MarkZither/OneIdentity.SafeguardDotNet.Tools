using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an SSH key assigned to an account
  /// </summary>
  [DataContract]
  public class AccountSshKey {
    /// <summary>
    /// Private key represented in base64 (write-only)
    /// </summary>
    /// <value>Private key represented in base64 (write-only)</value>
    [DataMember(Name="PrivateKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrivateKey")]
    public string PrivateKey { get; set; }

    /// <summary>
    /// Passphrase to decrypt PrivateKey (write-only)
    /// </summary>
    /// <value>Passphrase to decrypt PrivateKey (write-only)</value>
    [DataMember(Name="Passphrase", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Passphrase")]
    public string Passphrase { get; set; }

    /// <summary>
    /// Public key represented in base64
    /// </summary>
    /// <value>Public key represented in base64</value>
    [DataMember(Name="PublicKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PublicKey")]
    public string PublicKey { get; set; }

    /// <summary>
    /// Comment associated with key
    /// </summary>
    /// <value>Comment associated with key</value>
    [DataMember(Name="Comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Comment")]
    public string Comment { get; set; }

    /// <summary>
    /// The MD5 fingerprint hash of the SSH key (Read-only)
    /// </summary>
    /// <value>The MD5 fingerprint hash of the SSH key (Read-only)</value>
    [DataMember(Name="Fingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fingerprint")]
    public string Fingerprint { get; set; }

    /// <summary>
    /// The SHA256 fingerprint hash, Base64 encoded, of the SSH key
    /// </summary>
    /// <value>The SHA256 fingerprint hash, Base64 encoded, of the SSH key</value>
    [DataMember(Name="FingerprintSha256", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FingerprintSha256")]
    public string FingerprintSha256 { get; set; }

    /// <summary>
    /// Gets or Sets KeyType
    /// </summary>
    [DataMember(Name="KeyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyType")]
    public SshKeyType KeyType { get; set; }

    /// <summary>
    /// Length, in bits, of SSH key
    /// </summary>
    /// <value>Length, in bits, of SSH key</value>
    [DataMember(Name="KeyLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyLength")]
    public int? KeyLength { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountSshKey {\n");
      sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
      sb.Append("  Passphrase: ").Append(Passphrase).Append("\n");
      sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  Fingerprint: ").Append(Fingerprint).Append("\n");
      sb.Append("  FingerprintSha256: ").Append(FingerprintSha256).Append("\n");
      sb.Append("  KeyType: ").Append(KeyType).Append("\n");
      sb.Append("  KeyLength: ").Append(KeyLength).Append("\n");
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
