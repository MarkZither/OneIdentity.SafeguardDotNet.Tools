using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a physical server where backups, etc. may be stored
  /// </summary>
  [DataContract]
  public class ArchiveServer {
    /// <summary>
    /// Unique ID of this archive server configuration
    /// </summary>
    /// <value>Unique ID of this archive server configuration</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Display name of the server
    /// </summary>
    /// <value>Display name of the server</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the server
    /// </summary>
    /// <value>Description of the server</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Network address to connect to.
    /// </summary>
    /// <value>Network address to connect to.</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Database ID of the manage network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.
    /// </summary>
    /// <value>Database ID of the manage network this asset is explicitly assigned to. If null then   managed network will be calculated dynamically.</value>
    [DataMember(Name="ManagedNetworkId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedNetworkId")]
    public int? ManagedNetworkId { get; set; }

    /// <summary>
    /// Display name managed network (Read-only)
    /// </summary>
    /// <value>Display name managed network (Read-only)</value>
    [DataMember(Name="ManagedNetworkName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedNetworkName")]
    public string ManagedNetworkName { get; set; }

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
    /// SSH Public Host Key
    /// </summary>
    /// <value>SSH Public Host Key</value>
    [DataMember(Name="SshHostKey", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKey")]
    public string SshHostKey { get; set; }

    /// <summary>
    /// The MD5 fingerprint hash of the SSH host key (Read-only)
    /// </summary>
    /// <value>The MD5 fingerprint hash of the SSH host key (Read-only)</value>
    [DataMember(Name="SshHostKeyFingerprint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKeyFingerprint")]
    public string SshHostKeyFingerprint { get; set; }

    /// <summary>
    /// The SHA256 fingerprint hash, Base64 encoded, of the SSH host key (Read-only)
    /// </summary>
    /// <value>The SHA256 fingerprint hash, Base64 encoded, of the SSH host key (Read-only)</value>
    [DataMember(Name="SshHostKeyFingerprintSha256", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshHostKeyFingerprintSha256")]
    public string SshHostKeyFingerprintSha256 { get; set; }

    /// <summary>
    /// Gets or Sets TransferProtocol
    /// </summary>
    [DataMember(Name="TransferProtocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TransferProtocol")]
    public TransferProtocol TransferProtocol { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ArchiveServer {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  ManagedNetworkId: ").Append(ManagedNetworkId).Append("\n");
      sb.Append("  ManagedNetworkName: ").Append(ManagedNetworkName).Append("\n");
      sb.Append("  StoragePath: ").Append(StoragePath).Append("\n");
      sb.Append("  ConnectionProperties: ").Append(ConnectionProperties).Append("\n");
      sb.Append("  SshHostKey: ").Append(SshHostKey).Append("\n");
      sb.Append("  SshHostKeyFingerprint: ").Append(SshHostKeyFingerprint).Append("\n");
      sb.Append("  SshHostKeyFingerprintSha256: ").Append(SshHostKeyFingerprintSha256).Append("\n");
      sb.Append("  TransferProtocol: ").Append(TransferProtocol).Append("\n");
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
