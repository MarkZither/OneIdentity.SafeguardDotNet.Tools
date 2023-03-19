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
  public class SessionsLaunchData {
    /// <summary>
    /// Gets or Sets Token
    /// </summary>
    [DataMember(Name="Token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [DataMember(Name="SessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SessionId")]
    public int? SessionId { get; set; }

    /// <summary>
    /// Gets or Sets SpsInitiate
    /// </summary>
    [DataMember(Name="SpsInitiate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SpsInitiate")]
    public bool? SpsInitiate { get; set; }

    /// <summary>
    /// Gets or Sets SshConnectionString
    /// </summary>
    [DataMember(Name="SshConnectionString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SshConnectionString")]
    public string SshConnectionString { get; set; }

    /// <summary>
    /// Gets or Sets TelnetConnectionString
    /// </summary>
    [DataMember(Name="TelnetConnectionString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TelnetConnectionString")]
    public string TelnetConnectionString { get; set; }

    /// <summary>
    /// Gets or Sets RdpConnectionString
    /// </summary>
    [DataMember(Name="RdpConnectionString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RdpConnectionString")]
    public string RdpConnectionString { get; set; }

    /// <summary>
    /// Gets or Sets RdpConnectionFile
    /// </summary>
    [DataMember(Name="RdpConnectionFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RdpConnectionFile")]
    public string RdpConnectionFile { get; set; }

    /// <summary>
    /// Gets or Sets RdpHostComputer
    /// </summary>
    [DataMember(Name="RdpHostComputer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RdpHostComputer")]
    public string RdpHostComputer { get; set; }

    /// <summary>
    /// Gets or Sets ConnectionUri
    /// </summary>
    [DataMember(Name="ConnectionUri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectionUri")]
    public string ConnectionUri { get; set; }

    /// <summary>
    /// Gets or Sets SraConnectionUri
    /// </summary>
    [DataMember(Name="SraConnectionUri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SraConnectionUri")]
    public string SraConnectionUri { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SessionsLaunchData {\n");
      sb.Append("  Token: ").Append(Token).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  SpsInitiate: ").Append(SpsInitiate).Append("\n");
      sb.Append("  SshConnectionString: ").Append(SshConnectionString).Append("\n");
      sb.Append("  TelnetConnectionString: ").Append(TelnetConnectionString).Append("\n");
      sb.Append("  RdpConnectionString: ").Append(RdpConnectionString).Append("\n");
      sb.Append("  RdpConnectionFile: ").Append(RdpConnectionFile).Append("\n");
      sb.Append("  RdpHostComputer: ").Append(RdpHostComputer).Append("\n");
      sb.Append("  ConnectionUri: ").Append(ConnectionUri).Append("\n");
      sb.Append("  SraConnectionUri: ").Append(SraConnectionUri).Append("\n");
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
