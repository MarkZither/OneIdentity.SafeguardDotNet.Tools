using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a member of a policy
  /// </summary>
  [DataContract]
  public class AssetPolicyMembership {
    /// <summary>
    /// Database ID of the policy
    /// </summary>
    /// <value>Database ID of the policy</value>
    [DataMember(Name="PolicyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyId")]
    public int? PolicyId { get; set; }

    /// <summary>
    /// Database ID of the account that is managed by the policy
    /// </summary>
    /// <value>Database ID of the account that is managed by the policy</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Database ID of the policy member that manages the account
    /// </summary>
    /// <value>Database ID of the policy member that manages the account</value>
    [DataMember(Name="PolicyMemberId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyMemberId")]
    public int? PolicyMemberId { get; set; }

    /// <summary>
    /// Name of the policy member
    /// </summary>
    /// <value>Name of the policy member</value>
    [DataMember(Name="PolicyMemberName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyMemberName")]
    public string PolicyMemberName { get; set; }

    /// <summary>
    /// Whether the policy member is an asset or an asset group
    /// </summary>
    /// <value>Whether the policy member is an asset or an asset group</value>
    [DataMember(Name="PolicyMemberIsAssetGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyMemberIsAssetGroup")]
    public bool? PolicyMemberIsAssetGroup { get; set; }

    /// <summary>
    /// Whether the policy member is an asset or an account group
    /// </summary>
    /// <value>Whether the policy member is an asset or an account group</value>
    [DataMember(Name="PolicyMemberIsAccountGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyMemberIsAccountGroup")]
    public bool? PolicyMemberIsAccountGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssetPolicyMembership {\n");
      sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  PolicyMemberId: ").Append(PolicyMemberId).Append("\n");
      sb.Append("  PolicyMemberName: ").Append(PolicyMemberName).Append("\n");
      sb.Append("  PolicyMemberIsAssetGroup: ").Append(PolicyMemberIsAssetGroup).Append("\n");
      sb.Append("  PolicyMemberIsAccountGroup: ").Append(PolicyMemberIsAccountGroup).Append("\n");
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
