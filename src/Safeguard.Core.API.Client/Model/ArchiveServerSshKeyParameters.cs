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
  public class ArchiveServerSshKeyParameters {
    /// <summary>
    /// Whether to auto-accept the ssh host key
    /// </summary>
    /// <value>Whether to auto-accept the ssh host key</value>
    [DataMember(Name="AutoAcceptSshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AutoAcceptSshHostKey")]
    public bool? AutoAcceptSshHostKey { get; set; }

    /// <summary>
    /// Public key of the asset
    /// </summary>
    /// <value>Public key of the asset</value>
    [DataMember(Name="SshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKey")]
    public string SshHostKey { get; set; }

    /// <summary>
    /// Gets or Sets SshKeyToInstall
    /// </summary>
    [DataMember(Name="SshKeyToInstall", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshKeyToInstall")]
    public AccountSshKey SshKeyToInstall { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public ArchivePlatformConnectionProperties ConnectionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArchiveServerSshKeyParameters {\n");
      sb.Append("  AutoAcceptSshHostKey: ").Append(AutoAcceptSshHostKey).Append("\n");
      sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
      sb.Append("  SshKeyToInstall: ").Append(SshKeyToInstall).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
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
