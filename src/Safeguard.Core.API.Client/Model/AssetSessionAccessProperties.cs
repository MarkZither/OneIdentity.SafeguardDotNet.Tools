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
  public class AssetSessionAccessProperties {
    /// <summary>
    /// Whether to allow session requests to be made to this asset using linked or policy-specific accounts
    /// </summary>
    /// <value>Whether to allow session requests to be made to this asset using linked or policy-specific accounts</value>
    [DataMember(Name="AllowSessionRequests", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowSessionRequests")]
    public bool? AllowSessionRequests { get; set; }

    /// <summary>
    /// Port for SSH sessions
    /// </summary>
    /// <value>Port for SSH sessions</value>
    [DataMember(Name="SshSessionPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshSessionPort")]
    public int? SshSessionPort { get; set; }

    /// <summary>
    /// Port for Remote Desktop sessions
    /// </summary>
    /// <value>Port for Remote Desktop sessions</value>
    [DataMember(Name="RemoteDesktopSessionPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RemoteDesktopSessionPort")]
    public int? RemoteDesktopSessionPort { get; set; }

    /// <summary>
    /// Port for Telnet sessions
    /// </summary>
    /// <value>Port for Telnet sessions</value>
    [DataMember(Name="TelnetSessionPort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TelnetSessionPort")]
    public int? TelnetSessionPort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetSessionAccessProperties {\n");
      sb.Append("  AllowSessionRequests: ").Append(AllowSessionRequests).Append("\n");
      sb.Append("  SshSessionPort: ").Append(SshSessionPort).Append("\n");
      sb.Append("  RemoteDesktopSessionPort: ").Append(RemoteDesktopSessionPort).Append("\n");
      sb.Append("  TelnetSessionPort: ").Append(TelnetSessionPort).Append("\n");
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
