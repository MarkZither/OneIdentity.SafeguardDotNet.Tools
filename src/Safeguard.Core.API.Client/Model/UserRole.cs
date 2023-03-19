using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a role that a user belongs to plus how that membership was granted
  /// </summary>
  [DataContract]
  public class UserRole {
    /// <summary>
    /// Database ID of the role
    /// </summary>
    /// <value>Database ID of the role</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the role
    /// </summary>
    /// <value>Name of the role</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Number of accounts managed by the role
    /// </summary>
    /// <value>Number of accounts managed by the role</value>
    [DataMember(Name="AccountCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCount")]
    public int? AccountCount { get; set; }

    /// <summary>
    /// Number of users that are members of the role
    /// </summary>
    /// <value>Number of users that are members of the role</value>
    [DataMember(Name="UserCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserCount")]
    public int? UserCount { get; set; }

    /// <summary>
    /// Number of policies assigned to the role
    /// </summary>
    /// <value>Number of policies assigned to the role</value>
    [DataMember(Name="PolicyCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyCount")]
    public int? PolicyCount { get; set; }

    /// <summary>
    /// How membership in this role was explicitly granted (Read-Only)
    /// </summary>
    /// <value>How membership in this role was explicitly granted (Read-Only)</value>
    [DataMember(Name="Membership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Membership")]
    public List<UserRoleMembership> Membership { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRole {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  AccountCount: ").Append(AccountCount).Append("\n");
      sb.Append("  UserCount: ").Append(UserCount).Append("\n");
      sb.Append("  PolicyCount: ").Append(PolicyCount).Append("\n");
      sb.Append("  Membership: ").Append(Membership).Append("\n");
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
