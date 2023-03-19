using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents a policy that an account belongs to plus how that membership was granted
  /// </summary>
  [DataContract]
  public class AccountPolicy {
    /// <summary>
    /// Database ID of the policy the account belongs to
    /// </summary>
    /// <value>Database ID of the policy the account belongs to</value>
    [DataMember(Name="PolicyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyId")]
    public int? PolicyId { get; set; }

    /// <summary>
    /// Name of the policy the account belongs to
    /// </summary>
    /// <value>Name of the policy the account belongs to</value>
    [DataMember(Name="PolicyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyName")]
    public string PolicyName { get; set; }

    /// <summary>
    /// Gets or Sets AccessRequestType
    /// </summary>
    [DataMember(Name="AccessRequestType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccessRequestType")]
    public AccessRequestType AccessRequestType { get; set; }

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
    /// Database ID of the account
    /// </summary>
    /// <value>Database ID of the account</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account
    /// </summary>
    /// <value>Name of the account</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Database ID of the asset the account belongs to
    /// </summary>
    /// <value>Database ID of the asset the account belongs to</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset the account belongs to
    /// </summary>
    /// <value>Name of the asset the account belongs to</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Number of assets in the policy
    /// </summary>
    /// <value>Number of assets in the policy</value>
    [DataMember(Name="PolicyAssetCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAssetCount")]
    public int? PolicyAssetCount { get; set; }

    /// <summary>
    /// Number of asset groups in the policy
    /// </summary>
    /// <value>Number of asset groups in the policy</value>
    [DataMember(Name="PolicyAssetGroupCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAssetGroupCount")]
    public int? PolicyAssetGroupCount { get; set; }

    /// <summary>
    /// Number of accounts in the policy
    /// </summary>
    /// <value>Number of accounts in the policy</value>
    [DataMember(Name="PolicyAccountCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAccountCount")]
    public int? PolicyAccountCount { get; set; }

    /// <summary>
    /// Number of account groups in the policy
    /// </summary>
    /// <value>Number of account groups in the policy</value>
    [DataMember(Name="PolicyAccountGroupCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PolicyAccountGroupCount")]
    public int? PolicyAccountGroupCount { get; set; }

    /// <summary>
    /// How this policy membership was explicitly granted (Read-Only)
    /// </summary>
    /// <value>How this policy membership was explicitly granted (Read-Only)</value>
    [DataMember(Name="Membership", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Membership")]
    public List<AccountPolicyMembership> Membership { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountPolicy {\n");
      sb.Append("  PolicyId: ").Append(PolicyId).Append("\n");
      sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
      sb.Append("  AccessRequestType: ").Append(AccessRequestType).Append("\n");
      sb.Append("  RoleId: ").Append(RoleId).Append("\n");
      sb.Append("  RoleName: ").Append(RoleName).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  PolicyAssetCount: ").Append(PolicyAssetCount).Append("\n");
      sb.Append("  PolicyAssetGroupCount: ").Append(PolicyAssetGroupCount).Append("\n");
      sb.Append("  PolicyAccountCount: ").Append(PolicyAccountCount).Append("\n");
      sb.Append("  PolicyAccountGroupCount: ").Append(PolicyAccountGroupCount).Append("\n");
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
