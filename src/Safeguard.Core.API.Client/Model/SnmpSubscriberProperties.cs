using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents configuration for an SNMP event subscriber
  /// </summary>
  [DataContract]
  public class SnmpSubscriberProperties {
    /// <summary>
    /// Subscriber SNMP network address
    /// </summary>
    /// <value>Subscriber SNMP network address</value>
    [DataMember(Name="NetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkAddress")]
    public string NetworkAddress { get; set; }

    /// <summary>
    /// UDP port number for SNMP traps
    /// </summary>
    /// <value>UDP port number for SNMP traps</value>
    [DataMember(Name="Port", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Port")]
    public int? Port { get; set; }

    /// <summary>
    /// SNMP community
    /// </summary>
    /// <value>SNMP community</value>
    [DataMember(Name="Community", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Community")]
    public string Community { get; set; }

    /// <summary>
    /// SNMP version
    /// </summary>
    /// <value>SNMP version</value>
    [DataMember(Name="Version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Version")]
    public int? Version { get; set; }

    /// <summary>
    /// SNMP engine ID (between 10 and 64 hex characters, 0x is optional). Will be generated based on ApplianceId if not supplied. (v3 only)
    /// </summary>
    /// <value>SNMP engine ID (between 10 and 64 hex characters, 0x is optional). Will be generated based on ApplianceId if not supplied. (v3 only)</value>
    [DataMember(Name="EngineId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EngineId")]
    public string EngineId { get; set; }

    /// <summary>
    /// SNMP authentication username (v3 only)
    /// </summary>
    /// <value>SNMP authentication username (v3 only)</value>
    [DataMember(Name="AuthenticationUserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationUserName")]
    public string AuthenticationUserName { get; set; }

    /// <summary>
    /// Gets or Sets AuthenticationType
    /// </summary>
    [DataMember(Name="AuthenticationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationType")]
    public SnmpAuthenticationType AuthenticationType { get; set; }

    /// <summary>
    /// SNMP authentication password (v3 only)
    /// </summary>
    /// <value>SNMP authentication password (v3 only)</value>
    [DataMember(Name="AuthenticationPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AuthenticationPassword")]
    public string AuthenticationPassword { get; set; }

    /// <summary>
    /// Has SNMP authentication password (v3 only) (Read-Only)
    /// </summary>
    /// <value>Has SNMP authentication password (v3 only) (Read-Only)</value>
    [DataMember(Name="HasAuthenticationPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasAuthenticationPassword")]
    public bool? HasAuthenticationPassword { get; set; }

    /// <summary>
    /// Gets or Sets EncryptionType
    /// </summary>
    [DataMember(Name="EncryptionType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EncryptionType")]
    public SnmpEncryptionType EncryptionType { get; set; }

    /// <summary>
    /// SNMP encryption password (v3 only)
    /// </summary>
    /// <value>SNMP encryption password (v3 only)</value>
    [DataMember(Name="EncryptionPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EncryptionPassword")]
    public string EncryptionPassword { get; set; }

    /// <summary>
    /// Has SNMP encryption password (v3 only) (Read-Only)
    /// </summary>
    /// <value>Has SNMP encryption password (v3 only) (Read-Only)</value>
    [DataMember(Name="HasEncryptionPassword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasEncryptionPassword")]
    public bool? HasEncryptionPassword { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SnmpSubscriberProperties {\n");
      sb.Append("  NetworkAddress: ").Append(NetworkAddress).Append("\n");
      sb.Append("  Port: ").Append(Port).Append("\n");
      sb.Append("  Community: ").Append(Community).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  EngineId: ").Append(EngineId).Append("\n");
      sb.Append("  AuthenticationUserName: ").Append(AuthenticationUserName).Append("\n");
      sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
      sb.Append("  AuthenticationPassword: ").Append(AuthenticationPassword).Append("\n");
      sb.Append("  HasAuthenticationPassword: ").Append(HasAuthenticationPassword).Append("\n");
      sb.Append("  EncryptionType: ").Append(EncryptionType).Append("\n");
      sb.Append("  EncryptionPassword: ").Append(EncryptionPassword).Append("\n");
      sb.Append("  HasEncryptionPassword: ").Append(HasEncryptionPassword).Append("\n");
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
