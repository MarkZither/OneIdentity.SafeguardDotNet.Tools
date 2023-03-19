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
  public class PartitionTag {
    /// <summary>
    /// The ID of the tag
    /// </summary>
    /// <value>The ID of the tag</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The ID of the partition that this tag is associated with
    /// </summary>
    /// <value>The ID of the partition that this tag is associated with</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// The name of the partition that this tag is associated with
    /// </summary>
    /// <value>The name of the partition that this tag is associated with</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// The name of the tag
    /// </summary>
    /// <value>The name of the tag</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The description of the tag
    /// </summary>
    /// <value>The description of the tag</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets AssetTaggingRule
    /// </summary>
    [DataMember(Name="AssetTaggingRule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetTaggingRule")]
    public TaggingGroupingRule AssetTaggingRule { get; set; }

    /// <summary>
    /// Gets or Sets AssetAccountTaggingRule
    /// </summary>
    [DataMember(Name="AssetAccountTaggingRule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetAccountTaggingRule")]
    public TaggingGroupingRule AssetAccountTaggingRule { get; set; }

    /// <summary>
    /// List of Identities that manage this asset
    /// </summary>
    /// <value>List of Identities that manage this asset</value>
    [DataMember(Name="ManagedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedBy")]
    public List<Identity> ManagedBy { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartitionTag {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  AssetTaggingRule: ").Append(AssetTaggingRule).Append("\n");
      sb.Append("  AssetAccountTaggingRule: ").Append(AssetAccountTaggingRule).Append("\n");
      sb.Append("  ManagedBy: ").Append(ManagedBy).Append("\n");
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
