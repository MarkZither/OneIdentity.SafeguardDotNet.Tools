using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a collection of assets and accounts along with management configuratino
  /// </summary>
  [DataContract]
  public class AssetPartition {
    /// <summary>
    /// Database ID of the AssetPartition
    /// </summary>
    /// <value>Database ID of the AssetPartition</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the partition
    /// </summary>
    /// <value>Name of the partition</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the partition
    /// </summary>
    /// <value>Description of the partition</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

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
    /// List of Identities that own this partition
    /// </summary>
    /// <value>List of Identities that own this partition</value>
    [DataMember(Name="ManagedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ManagedBy")]
    public List<Identity> ManagedBy { get; set; }

    /// <summary>
    /// Default profile for all assets in this partition
    /// </summary>
    /// <value>Default profile for all assets in this partition</value>
    [DataMember(Name="DefaultProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultProfileId")]
    public int? DefaultProfileId { get; set; }

    /// <summary>
    /// Name of the default profile for this partition (Read-only)
    /// </summary>
    /// <value>Name of the default profile for this partition (Read-only)</value>
    [DataMember(Name="DefaultProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultProfileName")]
    public string DefaultProfileName { get; set; }

    /// <summary>
    /// Default SSH key profile for all assets in this partition
    /// </summary>
    /// <value>Default SSH key profile for all assets in this partition</value>
    [DataMember(Name="DefaultSshKeyProfileId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSshKeyProfileId")]
    public int? DefaultSshKeyProfileId { get; set; }

    /// <summary>
    /// Name of the default SSH key profile for this partition (Read-only)
    /// </summary>
    /// <value>Name of the default SSH key profile for this partition (Read-only)</value>
    [DataMember(Name="DefaultSshKeyProfileName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultSshKeyProfileName")]
    public string DefaultSshKeyProfileName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetPartition {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  ManagedBy: ").Append(ManagedBy).Append("\n");
      sb.Append("  DefaultProfileId: ").Append(DefaultProfileId).Append("\n");
      sb.Append("  DefaultProfileName: ").Append(DefaultProfileName).Append("\n");
      sb.Append("  DefaultSshKeyProfileId: ").Append(DefaultSshKeyProfileId).Append("\n");
      sb.Append("  DefaultSshKeyProfileName: ").Append(DefaultSshKeyProfileName).Append("\n");
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
