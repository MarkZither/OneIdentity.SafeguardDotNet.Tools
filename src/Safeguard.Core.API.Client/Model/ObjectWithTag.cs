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
  public class ObjectWithTag {
    /// <summary>
    /// Id of the object
    /// </summary>
    /// <value>Id of the object</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the object
    /// </summary>
    /// <value>Name of the object</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Domain name of the object
    /// </summary>
    /// <value>Domain name of the object</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public TaggingGroupingObjectType Type { get; set; }

    /// <summary>
    /// Whether the tag was statically or dynamically assigned
    /// </summary>
    /// <value>Whether the tag was statically or dynamically assigned</value>
    [DataMember(Name="IsStatic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsStatic")]
    public bool? IsStatic { get; set; }

    /// <summary>
    /// Asset Id, intent is to clarify when we have multiple asset accounts with the same name, which one.  Will be null for directory accounts and redundant for assets.
    /// </summary>
    /// <value>Asset Id, intent is to clarify when we have multiple asset accounts with the same name, which one.  Will be null for directory accounts and redundant for assets.</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Asset Name, intent is to clarify when we have multiple asset accounts with the same name, which one.  Will be null for directory accounts and redundant for assets.
    /// </summary>
    /// <value>Asset Name, intent is to clarify when we have multiple asset accounts with the same name, which one.  Will be null for directory accounts and redundant for assets.</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ObjectWithTag {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  IsStatic: ").Append(IsStatic).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
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
