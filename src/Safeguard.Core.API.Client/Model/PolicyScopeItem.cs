using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Represents requestable items governed by policy
  /// </summary>
  [DataContract]
  public class PolicyScopeItem {
    /// <summary>
    /// Database Id of the scope item
    /// </summary>
    /// <value>Database Id of the scope item</value>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// DisplayName of the scope item (Read-only)
    /// </summary>
    /// <value>DisplayName of the scope item (Read-only)</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the scope item (Read-only)
    /// </summary>
    /// <value>Description of the scope item (Read-only)</value>
    [DataMember(Name="Description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets ScopeItemType
    /// </summary>
    [DataMember(Name="ScopeItemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ScopeItemType")]
    public PolicyScopeItemType ScopeItemType { get; set; }

    /// <summary>
    /// Gets or Sets Account
    /// </summary>
    [DataMember(Name="Account", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Account")]
    public PolicyAccount Account { get; set; }

    /// <summary>
    /// Gets or Sets Asset
    /// </summary>
    [DataMember(Name="Asset", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Asset")]
    public PolicyAsset Asset { get; set; }

    /// <summary>
    /// Gets or Sets AccountGroup
    /// </summary>
    [DataMember(Name="AccountGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountGroup")]
    public AccountGroup AccountGroup { get; set; }

    /// <summary>
    /// Gets or Sets AssetGroup
    /// </summary>
    [DataMember(Name="AssetGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetGroup")]
    public AssetGroup AssetGroup { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PolicyScopeItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ScopeItemType: ").Append(ScopeItemType).Append("\n");
      sb.Append("  Account: ").Append(Account).Append("\n");
      sb.Append("  Asset: ").Append(Asset).Append("\n");
      sb.Append("  AccountGroup: ").Append(AccountGroup).Append("\n");
      sb.Append("  AssetGroup: ").Append(AssetGroup).Append("\n");
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
