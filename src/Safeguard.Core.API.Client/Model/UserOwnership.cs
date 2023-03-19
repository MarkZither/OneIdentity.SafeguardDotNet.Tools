using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents an application user ownership.
  /// </summary>
  [DataContract]
  public class UserOwnership {
    /// <summary>
    /// The owned items's unique id.  This is a system-assigned value that is generated from the sql view. (Read-only)
    /// </summary>
    /// <value>The owned items's unique id.  This is a system-assigned value that is generated from the sql view. (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public string Id { get; set; }

    /// <summary>
    /// Ownership item Id; Asset, Account, Partition.
    /// </summary>
    /// <value>Ownership item Id; Asset, Account, Partition.</value>
    [DataMember(Name="OwnerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerId")]
    public int? OwnerId { get; set; }

    /// <summary>
    /// Ownership User Id.
    /// </summary>
    /// <value>Ownership User Id.</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// Gets or Sets OwnershipType
    /// </summary>
    [DataMember(Name="OwnershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnershipType")]
    public OwnershipType OwnershipType { get; set; }

    /// <summary>
    /// Ownership Object Name.
    /// </summary>
    /// <value>Ownership Object Name.</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Ownership was granted via the user account directly.
    /// </summary>
    /// <value>Ownership was granted via the user account directly.</value>
    [DataMember(Name="ViaSelf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ViaSelf")]
    public bool? ViaSelf { get; set; }

    /// <summary>
    /// Ownership was granted via group(s) membership directly.
    /// </summary>
    /// <value>Ownership was granted via group(s) membership directly.</value>
    [DataMember(Name="ViaGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ViaGroups")]
    public List<Identity> ViaGroups { get; set; }

    /// <summary>
    /// Ownership was granted via tag(s), either due to the user being an assigned owner of the tag or   a group the user belongs to is an assigned owner of the tag.
    /// </summary>
    /// <value>Ownership was granted via tag(s), either due to the user being an assigned owner of the tag or   a group the user belongs to is an assigned owner of the tag.</value>
    [DataMember(Name="ViaTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ViaTags")]
    public List<PartitionTag> ViaTags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserOwnership {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  OwnershipType: ").Append(OwnershipType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ViaSelf: ").Append(ViaSelf).Append("\n");
      sb.Append("  ViaGroups: ").Append(ViaGroups).Append("\n");
      sb.Append("  ViaTags: ").Append(ViaTags).Append("\n");
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
