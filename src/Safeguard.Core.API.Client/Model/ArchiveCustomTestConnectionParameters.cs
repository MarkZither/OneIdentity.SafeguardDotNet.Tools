using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Custom archive server test connection parameters
  /// </summary>
  [DataContract]
  public class ArchiveCustomTestConnectionParameters {
    /// <summary>
    /// Name of the asset to test the connection with
    /// </summary>
    /// <value>Name of the asset to test the connection with</value>
    [DataMember(Name="ArchiveServerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ArchiveServerName")]
    public string ArchiveServerName { get; set; }

    /// <summary>
    /// Network address to connect to.
    /// </summary>
    /// <value>Network address to connect to.</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

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
    /// The file path where backups, etc. should be stored
    /// </summary>
    /// <value>The file path where backups, etc. should be stored</value>
    [DataMember(Name="StoragePath", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StoragePath")]
    public string StoragePath { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionProperties
    /// </summary>
    [DataMember(Name="ConnectionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionProperties")]
    public ArchiveServerConnectionProperties ConnectionProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArchiveCustomTestConnectionParameters {\n");
      sb.Append("  ArchiveServerName: ").Append(ArchiveServerName).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  AutoAcceptSshHostKey: ").Append(AutoAcceptSshHostKey).Append("\n");
      sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
      sb.Append("  StoragePath: ").Append(StoragePath).Append("\n");
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
