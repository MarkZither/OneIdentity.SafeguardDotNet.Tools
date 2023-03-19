using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a policy that an asset/account group is assigned to
  /// </summary>
  [DataContract]
  public class GroupPolicies {
    /// <summary>
    /// Database ID of the policy
    /// </summary>
    /// <value>Database ID of the policy</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Name of the policy
    /// </summary>
    /// <value>Name of the policy</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Database ID of the role the policy belongs to
    /// </summary>
    /// <value>Database ID of the role the policy belongs to</value>
    [DataMember(Name="RoleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleId")]
    public int? RoleId { get; set; }

    /// <summary>
    /// Name of the role the policy belongs to
    /// </summary>
    /// <value>Name of the role the policy belongs to</value>
    [DataMember(Name="RoleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RoleName")]
    public string RoleName { get; set; }

    /// <summary>
    /// Number of accounts assigned to the policy
    /// </summary>
    /// <value>Number of accounts assigned to the policy</value>
    [DataMember(Name="PolicyAccountCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAccountCount")]
    public int? PolicyAccountCount { get; set; }

    /// <summary>
    /// Number of account groups assigned to the policy
    /// </summary>
    /// <value>Number of account groups assigned to the policy</value>
    [DataMember(Name="PolicyAccountGroupCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAccountGroupCount")]
    public int? PolicyAccountGroupCount { get; set; }

    /// <summary>
    /// Number of assets assigned to the policy
    /// </summary>
    /// <value>Number of assets assigned to the policy</value>
    [DataMember(Name="PolicyAssetCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAssetCount")]
    public int? PolicyAssetCount { get; set; }

    /// <summary>
    /// Number of asset groups assigned to the policy
    /// </summary>
    /// <value>Number of asset groups assigned to the policy</value>
    [DataMember(Name="PolicyAssetGroupCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAssetGroupCount")]
    public int? PolicyAssetGroupCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GroupPolicies {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  RoleId: ").Append(RoleId).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  PolicyAccountCount: ").Append(PolicyAccountCount).Append("\n");
      sb.Append("  PolicyAccountGroupCount: ").Append(PolicyAccountGroupCount).Append("\n");
      sb.Append("  PolicyAssetCount: ").Append(PolicyAssetCount).Append("\n");
      sb.Append("  PolicyAssetGroupCount: ").Append(PolicyAssetGroupCount).Append("\n");
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
