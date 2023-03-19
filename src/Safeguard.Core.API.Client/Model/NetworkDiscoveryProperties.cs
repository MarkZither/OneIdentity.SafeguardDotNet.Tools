using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Properties used when using Network DiscoveryType
  /// </summary>
  [DataContract]
  public class NetworkDiscoveryProperties {
    /// <summary>
    /// Gets or Sets ScanOptions
    /// </summary>
    [DataMember(Name="ScanOptions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScanOptions")]
    public NetworkDiscoveryOptions ScanOptions { get; set; }

    /// <summary>
    /// Set of ip ranges to apply to the network asset discovery query
    /// </summary>
    /// <value>Set of ip ranges to apply to the network asset discovery query</value>
    [DataMember(Name="ScanRules", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScanRules")]
    public List<AssetDiscoveryNetScanRule> ScanRules { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class NetworkDiscoveryProperties {\n");
      sb.Append("  ScanOptions: ").Append(ScanOptions).Append("\n");
      sb.Append("  ScanRules: ").Append(ScanRules).Append("\n");
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
