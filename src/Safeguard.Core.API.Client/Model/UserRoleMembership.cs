using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a member of a role
  /// </summary>
  [DataContract]
  public class UserRoleMembership {
    /// <summary>
    /// Database ID of the role member
    /// </summary>
    /// <value>Database ID of the role member</value>
    [DataMember(Name="RoleMemberId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleMemberId")]
    public int? RoleMemberId { get; set; }

    /// <summary>
    /// Display name of the role member
    /// </summary>
    /// <value>Display name of the role member</value>
    [DataMember(Name="RoleMemberDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleMemberDisplayName")]
    public string RoleMemberDisplayName { get; set; }

    /// <summary>
    /// Whether or not the role member is a group or a user
    /// </summary>
    /// <value>Whether or not the role member is a group or a user</value>
    [DataMember(Name="RoleMemberIsUserGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleMemberIsUserGroup")]
    public bool? RoleMemberIsUserGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRoleMembership {\n");
      sb.Append("  RoleMemberId: ").Append(RoleMemberId).Append("\n");
      sb.Append("  RoleMemberDisplayName: ").Append(RoleMemberDisplayName).Append("\n");
      sb.Append("  RoleMemberIsUserGroup: ").Append(RoleMemberIsUserGroup).Append("\n");
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
