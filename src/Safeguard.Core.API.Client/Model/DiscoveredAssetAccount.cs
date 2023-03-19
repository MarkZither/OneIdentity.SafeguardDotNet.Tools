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
  public class DiscoveredAssetAccount {
    /// <summary>
    /// Name of the discovered account
    /// </summary>
    /// <value>Name of the discovered account</value>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public DiscoveredAccountStatus Status { get; set; }

    /// <summary>
    /// The User ID discovered on the target system
    /// </summary>
    /// <value>The User ID discovered on the target system</value>
    [DataMember(Name="DiscoveredUserId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredUserId")]
    public string DiscoveredUserId { get; set; }

    /// <summary>
    /// The date the account was discovered
    /// </summary>
    /// <value>The date the account was discovered</value>
    [DataMember(Name="DiscoveredDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredDate")]
    public DateTime? DiscoveredDate { get; set; }

    /// <summary>
    /// Name of the asset on which this account was discovered
    /// </summary>
    /// <value>Name of the asset on which this account was discovered</value>
    [DataMember(Name="AssetName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetName")]
    public string AssetName { get; set; }

    /// <summary>
    /// Database ID of the asset on which this account was discovered
    /// </summary>
    /// <value>Database ID of the asset on which this account was discovered</value>
    [DataMember(Name="AssetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetId")]
    public int? AssetId { get; set; }

    /// <summary>
    /// Database identifier for the asset partition on which this account was discovered
    /// </summary>
    /// <value>Database identifier for the asset partition on which this account was discovered</value>
    [DataMember(Name="AssetPartitionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionId")]
    public int? AssetPartitionId { get; set; }

    /// <summary>
    /// Name of the asset partition on which this account was discovered
    /// </summary>
    /// <value>Name of the asset partition on which this account was discovered</value>
    [DataMember(Name="AssetPartitionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssetPartitionName")]
    public string AssetPartitionName { get; set; }

    /// <summary>
    /// Database Id of the account discovery schedule used to discover the account
    /// </summary>
    /// <value>Database Id of the account discovery schedule used to discover the account</value>
    [DataMember(Name="AccountDiscoveryScheduleId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleId")]
    public int? AccountDiscoveryScheduleId { get; set; }

    /// <summary>
    /// Name of account discovery schedule used to discover the account
    /// </summary>
    /// <value>Name of account discovery schedule used to discover the account</value>
    [DataMember(Name="AccountDiscoveryScheduleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountDiscoveryScheduleName")]
    public string AccountDiscoveryScheduleName { get; set; }

    /// <summary>
    /// Domain name where the account was discovered
    /// </summary>
    /// <value>Domain name where the account was discovered</value>
    [DataMember(Name="DomainName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DomainName")]
    public string DomainName { get; set; }

    /// <summary>
    /// The rule that discovered this account
    /// </summary>
    /// <value>The rule that discovered this account</value>
    [DataMember(Name="RuleName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "RuleName")]
    public string RuleName { get; set; }

    /// <summary>
    /// The groups on the target system the user is a member of
    /// </summary>
    /// <value>The groups on the target system the user is a member of</value>
    [DataMember(Name="DiscoveredGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DiscoveredGroups")]
    public List<DiscoveredGroup> DiscoveredGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiscoveredAssetAccount {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  DiscoveredUserId: ").Append(DiscoveredUserId).Append("\n");
      sb.Append("  DiscoveredDate: ").Append(DiscoveredDate).Append("\n");
      sb.Append("  AssetName: ").Append(AssetName).Append("\n");
      sb.Append("  AssetId: ").Append(AssetId).Append("\n");
      sb.Append("  AssetPartitionId: ").Append(AssetPartitionId).Append("\n");
      sb.Append("  AssetPartitionName: ").Append(AssetPartitionName).Append("\n");
      sb.Append("  AccountDiscoveryScheduleId: ").Append(AccountDiscoveryScheduleId).Append("\n");
      sb.Append("  AccountDiscoveryScheduleName: ").Append(AccountDiscoveryScheduleName).Append("\n");
      sb.Append("  DomainName: ").Append(DomainName).Append("\n");
      sb.Append("  RuleName: ").Append(RuleName).Append("\n");
      sb.Append("  DiscoveredGroups: ").Append(DiscoveredGroups).Append("\n");
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
