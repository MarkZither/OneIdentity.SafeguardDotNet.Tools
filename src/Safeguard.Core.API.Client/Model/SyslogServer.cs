using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a syslog server where data and events can be sent
  /// </summary>
  [DataContract]
  public class SyslogServer {
    /// <summary>
    /// Unique database ID of this server configuration
    /// </summary>
    /// <value>Unique database ID of this server configuration</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of this server
    /// </summary>
    /// <value>Name of this server</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Network address of syslog server
    /// </summary>
    /// <value>Network address of syslog server</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// Port to connect to syslog server
    /// </summary>
    /// <value>Port to connect to syslog server</value>
    [DataMember(Name="Port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Port")]
    public int? Port { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="Protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Protocol")]
    public SyslogProtocol Protocol { get; set; }

    /// <summary>
    /// Whether to encrypt data with SSL. Only valid when using TCP protocol.
    /// </summary>
    /// <value>Whether to encrypt data with SSL. Only valid when using TCP protocol.</value>
    [DataMember(Name="UseSslEncryption", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseSslEncryption")]
    public bool? UseSslEncryption { get; set; }

    /// <summary>
    /// Whether to authenticate to syslog server with client certificate. Requires that SyslogClientCertificate is configured. Only valid when using SSL encryption
    /// </summary>
    /// <value>Whether to authenticate to syslog server with client certificate. Requires that SyslogClientCertificate is configured. Only valid when using SSL encryption</value>
    [DataMember(Name="UseClientCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UseClientCertificate")]
    public bool? UseClientCertificate { get; set; }

    /// <summary>
    /// Verify SSL certificate if using SSL. Only valid when using SSL encryption
    /// </summary>
    /// <value>Verify SSL certificate if using SSL. Only valid when using SSL encryption</value>
    [DataMember(Name="VerifySslCertificate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VerifySslCertificate")]
    public bool? VerifySslCertificate { get; set; }

    /// <summary>
    /// Gets or Sets TcpFraming
    /// </summary>
    [DataMember(Name="TcpFraming", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TcpFraming")]
    public SyslogTcpFraming TcpFraming { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SyslogServer {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  UseSslEncryption: ").Append(UseSslEncryption).Append("\n");
      sb.Append("  UseClientCertificate: ").Append(UseClientCertificate).Append("\n");
      sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
      sb.Append("  TcpFraming: ").Append(TcpFraming).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
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
