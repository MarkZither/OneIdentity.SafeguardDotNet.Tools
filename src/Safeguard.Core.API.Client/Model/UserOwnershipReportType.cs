using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserOwnershipReportType {
    /// <summary>
    /// Gets or Sets OwnershipType
    /// </summary>
    [DataMember(Name="OwnershipType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnershipType")]
    public OwnershipType OwnershipType { get; set; }

    /// <summary>
    /// ID of the owned item (PartitionId, AssetId, AccountId, UserId, TagId)
    /// </summary>
    /// <value>ID of the owned item (PartitionId, AssetId, AccountId, UserId, TagId)</value>
    [DataMember(Name="ItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ItemId")]
    public int? ItemId { get; set; }

    /// <summary>
    /// ID of the partition
    /// </summary>
    /// <value>ID of the partition</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the partition
    /// </summary>
    /// <value>Name of the partition</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// ID of the asset owne
    /// </summary>
    /// <value>ID of the asset owne</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Name of the asset owned
    /// </summary>
    /// <value>Name of the asset owned</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Network address of the asset owned
    /// </summary>
    /// <value>Network address of the asset owned</value>
    [DataMember(Name="AssetNetworkAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetNetworkAddress")]
    public string AssetNetworkAddress { get; set; }

    /// <summary>
    /// ID of the account owned
    /// </summary>
    /// <value>ID of the account owned</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Name of the account owned
    /// </summary>
    /// <value>Name of the account owned</value>
    [DataMember(Name="AccountName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountName")]
    public string AccountName { get; set; }

    /// <summary>
    /// Domain name of the account owned
    /// </summary>
    /// <value>Domain name of the account owned</value>
    [DataMember(Name="AccountDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDomainName")]
    public string AccountDomainName { get; set; }

    /// <summary>
    /// ID of the tag (applies to tag ownership report)
    /// </summary>
    /// <value>ID of the tag (applies to tag ownership report)</value>
    [DataMember(Name="TagId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TagId")]
    public int? TagId { get; set; }

    /// <summary>
    /// Name of the tag (applies to tag ownership report)
    /// </summary>
    /// <value>Name of the tag (applies to tag ownership report)</value>
    [DataMember(Name="TagName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "TagName")]
    public string TagName { get; set; }

    /// <summary>
    /// ID of the user who is an owner
    /// </summary>
    /// <value>ID of the user who is an owner</value>
    [DataMember(Name="UserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserId")]
    public int? UserId { get; set; }

    /// <summary>
    /// DisplayName of the user who is an owner
    /// </summary>
    /// <value>DisplayName of the user who is an owner</value>
    [DataMember(Name="UserDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDisplayName")]
    public string UserDisplayName { get; set; }

    /// <summary>
    /// UserName of user who is an owner
    /// </summary>
    /// <value>UserName of user who is an owner</value>
    [DataMember(Name="UserName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserName")]
    public string UserName { get; set; }

    /// <summary>
    /// DomainName of user who is an owner
    /// </summary>
    /// <value>DomainName of user who is an owner</value>
    [DataMember(Name="UserDomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "UserDomainName")]
    public string UserDomainName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserOwnershipReportType {\n");
      sb.Append("  OwnershipType: ").Append(OwnershipType).Append("\n");
      sb.Append("  ItemId: ").Append(ItemId).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetNetworkAddress: ").Append(AssetNetworkAddress).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountName: ").Append(AccountName).Append("\n");
      sb.Append("  AccountDomainName: ").Append(AccountDomainName).Append("\n");
      sb.Append("  TagId: ").Append(TagId).Append("\n");
      sb.Append("  TagName: ").Append(TagName).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      sb.Append("  UserDomainName: ").Append(UserDomainName).Append("\n");
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
