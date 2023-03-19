using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a set of network subnets that are used to associate assets with appliances that will  provide services to those assets e.g., password check/change and access request sessions. This association  is automatically assigned based on IP address but can be manually overridden by the user.
  /// </summary>
  [DataContract]
  public class ManagedNetwork {
    /// <summary>
    /// Unique database ID of this entity
    /// </summary>
    /// <value>Unique database ID of this entity</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of this entity
    /// </summary>
    /// <value>Name of this entity</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of this entity
    /// </summary>
    /// <value>Description of this entity</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether this is a system owned entity. If true, entity cannot be modified or deleted.
    /// </summary>
    /// <value>Whether this is a system owned entity. If true, entity cannot be modified or deleted.</value>
    [DataMember(Name="IsSystemOwned", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsSystemOwned")]
    public bool? IsSystemOwned { get; set; }

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
    /// Set of subnets managed by this entity. A subnet may not be assigned  to multiple managed networks though overlapping subnets are allowed.
    /// </summary>
    /// <value>Set of subnets managed by this entity. A subnet may not be assigned  to multiple managed networks though overlapping subnets are allowed.</value>
    [DataMember(Name="Subnets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Subnets")]
    public List<NetworkSubnet> Subnets { get; set; }

    /// <summary>
    /// Set of network members that are assigned to managed this network
    /// </summary>
    /// <value>Set of network members that are assigned to managed this network</value>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<NetworkMember> Members { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ManagedNetwork {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  IsSystemOwned: ").Append(IsSystemOwned).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  Subnets: ").Append(Subnets).Append("\n");
      sb.Append("  Members: ").Append(Members).Append("\n");
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
