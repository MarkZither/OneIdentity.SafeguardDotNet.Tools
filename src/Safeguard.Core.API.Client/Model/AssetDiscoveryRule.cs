using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Rule to apply to discovered assets
  /// </summary>
  [DataContract]
  public class AssetDiscoveryRule {
    /// <summary>
    /// Name of the discovery rule
    /// </summary>
    /// <value>Name of the discovery rule</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets AssetTemplate
    /// </summary>
    [DataMember(Name="AssetTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetTemplate")]
    public AssetTemplate AssetTemplate { get; set; }

    /// <summary>
    /// Conditions to determine which assets to add to database
    /// </summary>
    /// <value>Conditions to determine which assets to add to database</value>
    [DataMember(Name="Conditions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Conditions")]
    public List<AssetDiscoveryCondition> Conditions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetDiscoveryRule {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AssetTemplate: ").Append(AssetTemplate).Append("\n");
      sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
