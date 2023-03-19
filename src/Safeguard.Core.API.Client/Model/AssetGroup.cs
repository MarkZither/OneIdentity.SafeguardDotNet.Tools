using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a group of assets on the appliance for use in session policy.  NOTE: Only assets that support session access are allowed
  /// </summary>
  [DataContract]
  public class AssetGroup {
    /// <summary>
    /// Id of the table entry
    /// </summary>
    /// <value>Id of the table entry</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the asset group
    /// </summary>
    /// <value>The name of the asset group</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description regarding the asset group
    /// </summary>
    /// <value>Description regarding the asset group</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether or not this is a dynamic asset group
    /// </summary>
    /// <value>Whether or not this is a dynamic asset group</value>
    [DataMember(Name="IsDynamic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsDynamic")]
    public bool? IsDynamic { get; set; }

    /// <summary>
    /// Set of policy assets that are assigned to this asset group
    /// </summary>
    /// <value>Set of policy assets that are assigned to this asset group</value>
    [DataMember(Name="Assets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Assets")]
    public List<PolicyAsset> Assets { get; set; }

    /// <summary>
    /// Gets or Sets AssetGroupingRule
    /// </summary>
    [DataMember(Name="AssetGroupingRule", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetGroupingRule")]
    public TaggingGroupingRule AssetGroupingRule { get; set; }

    /// <summary>
    /// Date this entity was created (Read-only)
    /// </summary>
    /// <value>Date this entity was created (Read-only)</value>
    [DataMember(Name="CreatedDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedDate")]
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// The database ID of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The database ID of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserId")]
    public int? CreatedByUserId { get; set; }

    /// <summary>
    /// The display name of the user that created this entity (Read-only)
    /// </summary>
    /// <value>The display name of the user that created this entity (Read-only)</value>
    [DataMember(Name="CreatedByUserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CreatedByUserDisplayName")]
    public string CreatedByUserDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetGroup {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsDynamic: ").Append(IsDynamic).Append("\n");
      sb.Append("  Assets: ").Append(Assets).Append("\n");
      sb.Append("  AssetGroupingRule: ").Append(AssetGroupingRule).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
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
