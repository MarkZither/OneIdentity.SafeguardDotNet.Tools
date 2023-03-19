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
  public class StarlingRegisteredConnectorFromStarling {
    /// <summary>
    /// Gets or Sets RegisteredConnectorId
    /// </summary>
    [DataMember(Name="RegisteredConnectorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RegisteredConnectorId")]
    public string RegisteredConnectorId { get; set; }

    /// <summary>
    /// Gets or Sets ConnectorId
    /// </summary>
    [DataMember(Name="ConnectorId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectorId")]
    public string ConnectorId { get; set; }

    /// <summary>
    /// Gets or Sets ConnectorDisplayName
    /// </summary>
    [DataMember(Name="ConnectorDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ConnectorDisplayName")]
    public string ConnectorDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets SubscriptionId
    /// </summary>
    [DataMember(Name="SubscriptionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SubscriptionId")]
    public string SubscriptionId { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets AvailableVersions
    /// </summary>
    [DataMember(Name="AvailableVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AvailableVersions")]
    public List<string> AvailableVersions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StarlingRegisteredConnectorFromStarling {\n");
      sb.Append("  RegisteredConnectorId: ").Append(RegisteredConnectorId).Append("\n");
      sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
      sb.Append("  ConnectorDisplayName: ").Append(ConnectorDisplayName).Append("\n");
      sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  AvailableVersions: ").Append(AvailableVersions).Append("\n");
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
