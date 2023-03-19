using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Rule to apply to discover network assets
  /// </summary>
  [DataContract]
  public class AssetDiscoveryNetScanRule {
    /// <summary>
    /// Starting Ip
    /// </summary>
    /// <value>Starting Ip</value>
    [DataMember(Name="StartIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StartIp")]
    public string StartIp { get; set; }

    /// <summary>
    /// Ending Ip
    /// </summary>
    /// <value>Ending Ip</value>
    [DataMember(Name="EndIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EndIp")]
    public string EndIp { get; set; }

    /// <summary>
    /// Set Of Ips to exclude in network asset discovery scan request
    /// </summary>
    /// <value>Set Of Ips to exclude in network asset discovery scan request</value>
    [DataMember(Name="ExcludeIps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExcludeIps")]
    public List<string> ExcludeIps { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDiscoveryNetScanRule {\n");
      sb.Append("  StartIp: ").Append(StartIp).Append("\n");
      sb.Append("  EndIp: ").Append(EndIp).Append("\n");
      sb.Append("  ExcludeIps: ").Append(ExcludeIps).Append("\n");
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
