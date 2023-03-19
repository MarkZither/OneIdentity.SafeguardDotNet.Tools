using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Parameters for testing asset discovery rules
  /// </summary>
  [DataContract]
  public class TestAssetDiscoveryParameters {
    /// <summary>
    /// Name of the discovery job to show in audit log
    /// </summary>
    /// <value>Name of the discovery job to show in audit log</value>
    [DataMember(Name="AssetDiscoveryJobName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetDiscoveryJobName")]
    public string AssetDiscoveryJobName { get; set; }

    /// <summary>
    /// Gets or Sets DiscoveryType
    /// </summary>
    [DataMember(Name="DiscoveryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveryType")]
    public AssetDiscoveryType DiscoveryType { get; set; }

    /// <summary>
    /// Name of the discovery rule to show in audit log
    /// </summary>
    /// <value>Name of the discovery rule to show in audit log</value>
    [DataMember(Name="RuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleName")]
    public string RuleName { get; set; }

    /// <summary>
    /// Discovery conditions to test
    /// </summary>
    /// <value>Discovery conditions to test</value>
    [DataMember(Name="Conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Conditions")]
    public List<AssetDiscoveryCondition> Conditions { get; set; }

    /// <summary>
    /// Gets or Sets DirectoryDiscoveryProperties
    /// </summary>
    [DataMember(Name="DirectoryDiscoveryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DirectoryDiscoveryProperties")]
    public DirectoryDiscoveryProperties DirectoryDiscoveryProperties { get; set; }

    /// <summary>
    /// Gets or Sets NetworkDiscoveryProperties
    /// </summary>
    [DataMember(Name="NetworkDiscoveryProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "NetworkDiscoveryProperties")]
    public NetworkDiscoveryProperties NetworkDiscoveryProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TestAssetDiscoveryParameters {\n");
      sb.Append("  AssetDiscoveryJobName: ").Append(AssetDiscoveryJobName).Append("\n");
      sb.Append("  DiscoveryType: ").Append(DiscoveryType).Append("\n");
      sb.Append("  RuleName: ").Append(RuleName).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
      sb.Append("  DirectoryDiscoveryProperties: ").Append(DirectoryDiscoveryProperties).Append("\n");
      sb.Append("  NetworkDiscoveryProperties: ").Append(NetworkDiscoveryProperties).Append("\n");
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
