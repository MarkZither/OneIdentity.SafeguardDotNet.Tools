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
  public class StarlingRegisteredConnector {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets RegisteredConnectorId
    /// </summary>
    [DataMember(Name="RegisteredConnectorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegisteredConnectorId")]
    public string RegisteredConnectorId { get; set; }

    /// <summary>
    /// Gets or Sets RegisteredConnectorDisplayName
    /// </summary>
    [DataMember(Name="RegisteredConnectorDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegisteredConnectorDisplayName")]
    public string RegisteredConnectorDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets StarlingConnectorId
    /// </summary>
    [DataMember(Name="StarlingConnectorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StarlingConnectorId")]
    public string StarlingConnectorId { get; set; }

    /// <summary>
    /// Gets or Sets StarlingConnectorVersion
    /// </summary>
    [DataMember(Name="StarlingConnectorVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "StarlingConnectorVersion")]
    public string StarlingConnectorVersion { get; set; }

    /// <summary>
    /// Gets or Sets Platform
    /// </summary>
    [DataMember(Name="Platform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Platform")]
    public AssetPlatform Platform { get; set; }

    /// <summary>
    /// Gets or Sets VisibleToAllPartitions
    /// </summary>
    [DataMember(Name="VisibleToAllPartitions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VisibleToAllPartitions")]
    public bool? VisibleToAllPartitions { get; set; }

    /// <summary>
    /// Gets or Sets VisibleToPartitions
    /// </summary>
    [DataMember(Name="VisibleToPartitions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VisibleToPartitions")]
    public List<AssetPartition> VisibleToPartitions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StarlingRegisteredConnector {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RegisteredConnectorId: ").Append(RegisteredConnectorId).Append("\n");
      sb.Append("  RegisteredConnectorDisplayName: ").Append(RegisteredConnectorDisplayName).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  StarlingConnectorId: ").Append(StarlingConnectorId).Append("\n");
      sb.Append("  StarlingConnectorVersion: ").Append(StarlingConnectorVersion).Append("\n");
      sb.Append("  Platform: ").Append(Platform).Append("\n");
      sb.Append("  VisibleToAllPartitions: ").Append(VisibleToAllPartitions).Append("\n");
      sb.Append("  VisibleToPartitions: ").Append(VisibleToPartitions).Append("\n");
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
