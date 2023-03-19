using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Settings related to session access requests
  /// </summary>
  [DataContract]
  public class PlatformSessionFeatureProperties {
    /// <summary>
    /// Whether this platform supports session access requests
    /// </summary>
    /// <value>Whether this platform supports session access requests</value>
    [DataMember(Name="SupportsSessionManagement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SupportsSessionManagement")]
    public bool? SupportsSessionManagement { get; set; }

    /// <summary>
    /// Default port for SSH sessions
    /// </summary>
    /// <value>Default port for SSH sessions</value>
    [DataMember(Name="DefaultSshSessionPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSshSessionPort")]
    public int? DefaultSshSessionPort { get; set; }

    /// <summary>
    /// Default port for Remote Desktop sessions
    /// </summary>
    /// <value>Default port for Remote Desktop sessions</value>
    [DataMember(Name="DefaultRemoteDesktopSessionPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultRemoteDesktopSessionPort")]
    public int? DefaultRemoteDesktopSessionPort { get; set; }

    /// <summary>
    /// Default port for Telnet sessions
    /// </summary>
    /// <value>Default port for Telnet sessions</value>
    [DataMember(Name="DefaultTelnetSessionPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultTelnetSessionPort")]
    public int? DefaultTelnetSessionPort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PlatformSessionFeatureProperties {\n");
      sb.Append("  SupportsSessionManagement: ").Append(SupportsSessionManagement).Append("\n");
      sb.Append("  DefaultSshSessionPort: ").Append(DefaultSshSessionPort).Append("\n");
      sb.Append("  DefaultRemoteDesktopSessionPort: ").Append(DefaultRemoteDesktopSessionPort).Append("\n");
      sb.Append("  DefaultTelnetSessionPort: ").Append(DefaultTelnetSessionPort).Append("\n");
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
