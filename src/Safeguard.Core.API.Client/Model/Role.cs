using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Roles in Pangaea are made up of a members, security scopes, and permissions.  * Members consist of users or groups.  * Permissions determine access to resources on the appliance.  * Security scopes determine access to assets such as assets and accounts. This access to assets is managed via policies (i.e. groups of settings)
  /// </summary>
  [DataContract]
  public class Role {
    /// <summary>
    /// The database ID of the role (Read-only)
    /// </summary>
    /// <value>The database ID of the role (Read-only)</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the role
    /// </summary>
    /// <value>The name of the role</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// The priority of this role. Used for resolving permission conflicts.  Set to 0 to add as the lowest priority role. Max role priority plus 1.
    /// </summary>
    /// <value>The priority of this role. Used for resolving permission conflicts.  Set to 0 to add as the lowest priority role. Max role priority plus 1.</value>
    [DataMember(Name="Priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Description of the role
    /// </summary>
    /// <value>Description of the role</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Date/time after which the associated policy/role will cease to be active
    /// </summary>
    /// <value>Date/time after which the associated policy/role will cease to be active</value>
    [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ExpirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Whether this policy is expired.  (Read-only)
    /// </summary>
    /// <value>Whether this policy is expired.  (Read-only)</value>
    [DataMember(Name="IsExpired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsExpired")]
    public bool? IsExpired { get; set; }

    /// <summary>
    /// Whether this role has policies that are expired.  (Read-only)
    /// </summary>
    /// <value>Whether this role has policies that are expired.  (Read-only)</value>
    [DataMember(Name="HasExpiredPolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasExpiredPolicies")]
    public bool? HasExpiredPolicies { get; set; }

    /// <summary>
    /// Whether this role has policies that have invalid connection policies.  (Read-only)
    /// </summary>
    /// <value>Whether this role has policies that have invalid connection policies.  (Read-only)</value>
    [DataMember(Name="HasInvalidPolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HasInvalidPolicies")]
    public bool? HasInvalidPolicies { get; set; }

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
    /// Number of users that are a member of this role (Read-only)
    /// </summary>
    /// <value>Number of users that are a member of this role (Read-only)</value>
    [DataMember(Name="UserCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserCount")]
    public int? UserCount { get; set; }

    /// <summary>
    /// Number of accounts that have policies belonging to this role (Read-only)
    /// </summary>
    /// <value>Number of accounts that have policies belonging to this role (Read-only)</value>
    [DataMember(Name="AccountCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountCount")]
    public int? AccountCount { get; set; }

    /// <summary>
    /// Number of assets that have policies belonging to this role (Read-only)
    /// </summary>
    /// <value>Number of assets that have policies belonging to this role (Read-only)</value>
    [DataMember(Name="AssetCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetCount")]
    public int? AssetCount { get; set; }

    /// <summary>
    /// Number of policies belonging to this role (Read-only)
    /// </summary>
    /// <value>Number of policies belonging to this role (Read-only)</value>
    [DataMember(Name="PolicyCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyCount")]
    public int? PolicyCount { get; set; }

    /// <summary>
    /// Gets or Sets HourlyRestrictionProperties
    /// </summary>
    [DataMember(Name="HourlyRestrictionProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HourlyRestrictionProperties")]
    public HourlyRestrictionProperties HourlyRestrictionProperties { get; set; }

    /// <summary>
    /// Identities that are members of this role. Requesters for password policies assigned to this role.
    /// </summary>
    /// <value>Identities that are members of this role. Requesters for password policies assigned to this role.</value>
    [DataMember(Name="Members", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Members")]
    public List<Identity> Members { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Role {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
      sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
      sb.Append("  HasExpiredPolicies: ").Append(HasExpiredPolicies).Append("\n");
      sb.Append("  HasInvalidPolicies: ").Append(HasInvalidPolicies).Append("\n");
      sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
      sb.Append("  CreatedByUserId: ").Append(CreatedByUserId).Append("\n");
      sb.Append("  CreatedByUserDisplayName: ").Append(CreatedByUserDisplayName).Append("\n");
      sb.Append("  UserCount: ").Append(UserCount).Append("\n");
      sb.Append("  AccountCount: ").Append(AccountCount).Append("\n");
      sb.Append("  AssetCount: ").Append(AssetCount).Append("\n");
      sb.Append("  PolicyCount: ").Append(PolicyCount).Append("\n");
      sb.Append("  HourlyRestrictionProperties: ").Append(HourlyRestrictionProperties).Append("\n");
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
