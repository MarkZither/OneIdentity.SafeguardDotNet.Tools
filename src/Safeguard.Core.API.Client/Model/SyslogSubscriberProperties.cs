using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Properties for syslog subscribers
  /// </summary>
  [DataContract]
  public class SyslogSubscriberProperties {
    /// <summary>
    /// The syslog server configuration to use
    /// </summary>
    /// <value>The syslog server configuration to use</value>
    [DataMember(Name="SyslogServerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyslogServerId")]
    public int? SyslogServerId { get; set; }

    /// <summary>
    /// Name of the syslog server configuration
    /// </summary>
    /// <value>Name of the syslog server configuration</value>
    [DataMember(Name="SyslogServerName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SyslogServerName")]
    public string SyslogServerName { get; set; }

    /// <summary>
    /// Network address of syslog server. If server ID is not specified than server will be looked up by network address
    /// </summary>
    /// <value>Network address of syslog server. If server ID is not specified than server will be looked up by network address</value>
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
    /// Gets or Sets Facility
    /// </summary>
    [DataMember(Name="Facility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Facility")]
    public SyslogFacility Facility { get; set; }

    /// <summary>
    /// All event properties with this prefix (Only for Json log format)
    /// </summary>
    /// <value>All event properties with this prefix (Only for Json log format)</value>
    [DataMember(Name="KeyPrefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "KeyPrefix")]
    public string KeyPrefix { get; set; }

    /// <summary>
    /// Gets or Sets Protocol
    /// </summary>
    [DataMember(Name="Protocol", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Protocol")]
    public SyslogProtocol Protocol { get; set; }

    /// <summary>
    /// Gets or Sets LogFormat
    /// </summary>
    [DataMember(Name="LogFormat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "LogFormat")]
    public SyslogFormat LogFormat { get; set; }

    /// <summary>
    /// Gets or Sets TcpFraming
    /// </summary>
    [DataMember(Name="TcpFraming", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TcpFraming")]
    public SyslogTcpFraming TcpFraming { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SyslogSubscriberProperties {\n");
      sb.Append("  SyslogServerId: ").Append(SyslogServerId).Append("\n");
      sb.Append("  SyslogServerName: ").Append(SyslogServerName).Append("\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  UseSslEncryption: ").Append(UseSslEncryption).Append("\n");
      sb.Append("  UseClientCertificate: ").Append(UseClientCertificate).Append("\n");
      sb.Append("  VerifySslCertificate: ").Append(VerifySslCertificate).Append("\n");
      sb.Append("  Facility: ").Append(Facility).Append("\n");
      sb.Append("  KeyPrefix: ").Append(KeyPrefix).Append("\n");
      sb.Append("  Protocol: ").Append(Protocol).Append("\n");
      sb.Append("  LogFormat: ").Append(LogFormat).Append("\n");
      sb.Append("  TcpFraming: ").Append(TcpFraming).Append("\n");
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
