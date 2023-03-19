using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The Asset, AssetAccount or DirectoryAccount and how it would be affected by the rule.
  /// </summary>
  [DataContract]
  public class DynamicTaggingRuleTestResult {
    /// <summary>
    /// The Id of the object (Asset, AssetAccount or DirectoryAccount)
    /// </summary>
    /// <value>The Id of the object (Asset, AssetAccount or DirectoryAccount)</value>
    [DataMember(Name="ObjectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectId")]
    public int? ObjectId { get; set; }

    /// <summary>
    /// The name of the object (Asset, AssetAccount or DirectoryAccount)
    /// </summary>
    /// <value>The name of the object (Asset, AssetAccount or DirectoryAccount)</value>
    [DataMember(Name="ObjectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ObjectName")]
    public string ObjectName { get; set; }

    /// <summary>
    /// Gets or Sets TaggingRuleAction
    /// </summary>
    [DataMember(Name="TaggingRuleAction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TaggingRuleAction")]
    public TaggingRuleActionResult TaggingRuleAction { get; set; }

    /// <summary>
    /// Asset Id, intent is to clarify when we have multiple accounts with the same name, which one.
    /// </summary>
    /// <value>Asset Id, intent is to clarify when we have multiple accounts with the same name, which one.</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Asset Name, intent is to clarify when we have multiple asset accounts with the same name, which one.
    /// </summary>
    /// <value>Asset Name, intent is to clarify when we have multiple asset accounts with the same name, which one.</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Domain Name, intent is to clarify when we have multiple accounts with the same name, which one.
    /// </summary>
    /// <value>Domain Name, intent is to clarify when we have multiple accounts with the same name, which one.</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DynamicTaggingRuleTestResult {\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
      sb.Append("  TaggingRuleAction: ").Append(TaggingRuleAction).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
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
